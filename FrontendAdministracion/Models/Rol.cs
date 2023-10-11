using System.ComponentModel.DataAnnotations;

namespace FrontendAdministracion.Models
{
    public class Rol
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
    }
}
