using System.ComponentModel.DataAnnotations;

namespace CustAPI.Entities
{
    public class Libros
    {
        [Key]
        public int id_libro { get; set; }
        public string titulo_libro { get; set; }
        public int anio_libro { get; set; }
        public string genero_libro { get; set; }
        public int paginas_libro { get; set; }
        public int editorial_id { get; set; }
        public int autor_id { get; set; }
    }
}
