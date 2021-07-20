using System.Collections.Generic;

namespace RpgMvc.Models
{
    public class UsuarioViewModel
    {
        public int MyProperty { get; set; }
        public string Username { get; set; }
        public string PasswordString { get; set; }
        public byte[] Foto { get; set; }   
    
        public List<PersonagemViewModel> Personagens { get; set;}

    }
}