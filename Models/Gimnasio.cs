using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models
{
    public class Gimnasio
    {
        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("Ubicacion")]
        public string Ubicacion { get; set; }

        [JsonProperty("Tel")]
        public string Tel { get; set; }

        [JsonProperty("Correo")]
        public string Correo { get; set; }

        [JsonProperty("Capacidad")]
        public int Capacidad { get; set; }

        [JsonProperty("porcentaje")]
        public float porcentaje { get; set; }

        [JsonProperty("Logo")]
        public string Logo { get; set; }
    }
}
