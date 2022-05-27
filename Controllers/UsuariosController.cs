using Microsoft.AspNetCore.Mvc;
using RpgMVC.Models;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace RpgMVC.Controllers
{
    public class UsuariosController : Controller
    {
        public string uriBase = "http://localhost:5000/Usuarios/";

            
        [HttpGet]
        public ActionResult Index()
        {
            return View("CadastrarUsuario");
        }

        [HttpGet]
        public ActionResult IndexLogin()
        {
            return View("AutenticarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(UsuarioViewModel u)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Autenticar";

                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);

                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    HttpContext.Session.SetString("SessionTokenUsuario", serialized);
                    TempData["Mensagem"] = string.Format("Bem-vindo {0}!!!",u.Username);
                    return RedirectToAction("Index","Personagens");
                }
                else
                {
                    throw new System.Exception(serialized);
                }
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return IndexLogin();
            }
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(UsuarioViewModel u)
        {
            try
            {
               HttpClient httpClient = new HttpClient();
               string uriComplementar = "Registrar";

               var content = new StringContent(JsonConvert.SerializeObject(u));
               content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
               HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

               string serialized = await response.Content.ReadAsStringAsync();

               if(response.StatusCode == System.Net.HttpStatusCode.OK)
               {
                   TempData["Mensagem"] = string.Format("Usuário {0} Registrado com sucesso! Faça login para acessar.",u.Username);

                   return View("AutenticarUsuario");
               }
               else
                    throw new System.Exception(serialized);
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}