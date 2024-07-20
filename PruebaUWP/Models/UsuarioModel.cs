using System.Collections.Generic;

namespace PruebaUWP.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public List<PerfilModel> Perfiles { get; set; }
    }
}