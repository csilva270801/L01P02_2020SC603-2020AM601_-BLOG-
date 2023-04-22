using System.ComponentModel.DataAnnotations;

namespace L01P02_2020SC603_2020AM601.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public int usuarioId { get; set; }
    }
}
