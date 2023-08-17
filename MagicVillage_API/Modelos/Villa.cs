using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVillage_API.Modelos
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string detalle { get; set; }

        [Required]
        public double tarifa { get; set; }

        public int ocupantes { get; set; }

        public double metrosCuadrados { get; set; }

        public string imagenUrl { get; set; }

        public string amenidad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
