using System.ComponentModel.DataAnnotations;
namespace api_db.Models
{
    public class Clientes
    {
        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string cp { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}