using System.ComponentModel.DataAnnotations;

namespace MagicVillage_API.Modelos.DTO
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [Required]
        public int ocupantes { get; set;}
        [Required]
        public double metrosCuadrados { get; set; }

        public string detalle { get; set; }

        [Required]
        public double tarifa { get; set; }
        [Required]
        public string imagenUrl { get; set; }

        public string amenidad { get; set; }

    }
}
