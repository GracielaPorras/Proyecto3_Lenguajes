using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models
{
    public class Gimnasio
    {
        [JsonProperty("Id")]
        public string id { get; set; }

        [JsonProperty("Nombre")]
        public string nombre { get; set; }

        [JsonProperty("Password")]
        public string password { get; set; }

        [JsonProperty("Descripcion")]
        public string descripcion { get; set; }

        [JsonProperty("Ubicacion")]
        public string ubicacion { get; set; }

        [JsonProperty("Tel")]
        public string tel { get; set; }

        [JsonProperty("Correo")]
        public string correo { get; set; }

        [JsonProperty("Capacidad")]
        public string capacidad { get; set; }

        [JsonProperty("porcentaje")]
        public string porcentaje { get; set; }

        [JsonProperty("Logo")]
        public string logo { get; set; }
    }
}
