using System.ComponentModel.DataAnnotations;

namespace WebApplication1Test.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage ="Escriba un nombre")]
        [MinLength(20, ErrorMessage = "Escriba un minimo de 20 caracteres")]
        [MaxLength(50, ErrorMessage = "Escriba un maximo de 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Escriba una cedula")]
        [RegularExpression("^[0-9]{9}$")]
        public string Cedula { get; set; }
        public string Descripcion { get; set; }
    }
}
