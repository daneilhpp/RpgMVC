namespace RpgMVC.Models
{
    public class PersonagemHabilidadesViewModel
    {
        public int id{get;set;}
        public PersonagemViewModel Personagem{get;set;}
        public int HabilidadeId{get;set;}
        public HabilidadeViewModel Habilidade{get;set;}
    }
}