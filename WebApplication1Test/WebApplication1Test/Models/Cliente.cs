using System.ComponentModel.DataAnnotations;

namespace WebApplication1Test.Models
{
    public class Cliente
    {
        //Añadir el atributo [Key] si quiero llamar al id como yo quiera
        [Key]
        public int id_cliente { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
    }
}
