using MagicVillage_API.Modelos.DTO;

namespace MagicVillage_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id = 1, Nombre = "Vista a la piscina", ocupantes = 3, metrosCuadrados = 50},
            new VillaDto{Id = 2, Nombre = "Vista a la playa", ocupantes = 4, metrosCuadrados = 80 }
        };
    }
}
