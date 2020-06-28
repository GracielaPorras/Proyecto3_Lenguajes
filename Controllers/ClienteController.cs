using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models;
using Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models.ModelosCliente;

namespace Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Controllers
{
    public class ClienteController : Controller
    {
        private string url { get; set; }
        private WebRequest web { get; set; }
        private HttpWebResponse resp { get; set; }
        private HttpWebRequest req { get; set; }

        public ClienteController()
        {
            url = "http://localhost:55124/api/values";
        }

        public void conexion(string parametros, string metodo)
        {
            string dir = String.Format(url + parametros);
            web = WebRequest.Create(dir);
            web.Method = metodo;
            resp = (HttpWebResponse)web.GetResponse();

            req = (HttpWebRequest)WebRequest.Create(url);
            req.ContentType = "application/json";
            req.Method = metodo;

        }
        public IActionResult Index()
        {
            
            List<GimnasioModel> gimnasios = null;
            conexion("/consultarGimnasios", "GET");
            string json = null;
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            json = sr.ReadToEnd();
            gimnasios = System.Text.Json.JsonSerializer.Deserialize<List<GimnasioModel>>(json);

            sr.Close();
            resp.Close();

            ViewBag.Gimnasios = gimnasios;
            
            return View();
        }

        public IActionResult loginCliente(string id_gym, string logo_gym)
        {
            HttpContext.Session.SetString("ClienteGymActual", id_gym);
            return View("loginCliente", logo_gym);
        }
    }
}
