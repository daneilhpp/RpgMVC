using RpgMVC.Models.Enums;

namespace RpgMVC.Models
{
    public class PersonagemViewModel
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public int LifePoints {get;set;}
        public int Strength {get;set;}
        public int Defense {get;set;}
        public int Inteligence {get;set;}
        public ClasseEnum Classes {get;set;}
        public byte[] FotoPersonagem{get;set;}
        
        public int Disputas{get;set;}
        public int Vitorias{get;set;}
        public int Derrotas{get;set;}

        //[JsonIgnore]
        //public Usuario Usuario{get;set;}

        //[JsonIgnore]
        //public Arma Arma{get;set;}
        //public List<PersonagemHabilidade> PersonagemHabilidade{get;set;}
    }
}