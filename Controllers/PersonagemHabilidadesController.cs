using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Collections.Generic;
using RpgMVC.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace RpgMVC.Controllers
{
    public class PersonagemHabilidadesController : Controller
    {
        public string uriBase = "http://localhost:5000/PersonagemHabilidades/";

        [HttpGet("PersonagemHabilidades/{id}")]
        public async Task<ActionResult> IndexAsync(int id)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);

                HttpResponseMessage response = await httpClient.GetAsync(uriBase + id.ToString());
                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<PersonagemHabilidadesViewModel> lista = await Task.Run(() => 
                    JsonConvert.DeserializeObject<List<PersonagemHabilidadesViewModel>>(serialized));

                    return View(lista);
                }
                else
                    throw new System.Exception(serialized);
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;                
                return RedirectToAction("Index");
            }
        }

        [HttpGet("Delete/{habilidadeId}/{personagemId}")]
        public async Task<ActionResult> DeleteAsync(int habilidadeId, int personagemId)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "DeletarPersonagemHabilidade";
                string token = HttpContext.Session.GetString("SessionTokenUsuario");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);

                PersonagemHabilidadesViewModel ph = new PersonagemHabilidadesViewModel();
                ph.HabilidadeId = habilidadeId;
                ph.PersonagemId = personagemId;
                
                var content = new StringContent(JsonConvert.SerializeObject(ph));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);
                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    TempData["Mensagem"] = "Habilidade removida com sucesso";
                else
                    throw new System.Exception(serialized);
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
            }
            return RedirectToAction("Index", new {Id = personagemId});
        }

        [HttpGet]
        public async Task<ActionResult> CreateAsync(int id, string nome)
        {
            try
            {
                string uriComplementar = "GetHabilidades";
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);
                HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);

                string serialized = await response.Content.ReadAsStringAsync();
                List<HabilidadeViewModel> habilidades = await Task.Run(() => 
                JsonConvert.DeserializeObject<List<HabilidadeViewModel>>(serialized));
                ViewBag.ListaHabilidades = habilidades;

                PersonagemHabilidadesViewModel ph = new PersonagemHabilidadesViewModel();
                ph.Personagem = new PersonagemViewModel();
                ph.Habilidade = new HabilidadeViewModel();
                ph.PersonagemId = id;
                ph.Personagem.Name = nome;
                
                return View(ph);
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Create", new {id, nome});
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateAsync(PersonagemHabilidadesViewModel ph)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenUsuario");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);

                var content = new StringContent(JsonConvert.SerializeObject(ph));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase,content);
                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    TempData["Mensagem"] = "Habilidade cadastrada com sucesso";
                else
                    throw new System.Exception(serialized);
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
            }
            return RedirectToAction("Index",new{id = ph.PersonagemId});
        }

        
    }
}