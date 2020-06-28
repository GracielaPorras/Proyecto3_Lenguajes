using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models.ModelosCliente
{
    public class GimnasioModel
    {
        [JsonProperty("Id")]
        public string id { get; set; }
        [JsonProperty("Logo")]
        public string logo { get; set; }
        [JsonProperty("Nombre")]
        public string nombre { get; set; }
        [JsonProperty("Ubicacion")]
        public string ubicacion { get; set; }
    }
}
