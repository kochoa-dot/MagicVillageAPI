using System.ComponentModel.DataAnnotations;

namespace MagicVillage_API.Modelos.DTO
{
    public class VillaCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public int ocupantes { get; set;}

        public double metrosCuadrados { get; set; }

        public string detalle { get; set; }

        [Required]
        public double tarifa { get; set; }

        public string imagenUrl { get; set; }

        public string amenidad { get; set; }

    }
}
