using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc;
using Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Models;
using Microsoft.AspNetCore.WebUtilities;
using System.Web.Helpers;
using Newtonsoft.Json.Linq;

namespace Proyecto3LenguajesISemestre_ModuloAdmin_Graciela_Randall.Controllers
{
    public class GimnasioController : Controller
    {
        // GET: GimnasioController

        private string url { get; set; }
        private WebRequest web { get; set; }
        private HttpWebResponse resp { get; set; }
        private HttpWebRequest req { get; set; }

        public GimnasioController()
        {
            url = "http://localhost:55124/api/values";
        }

        public void conexion(string parametros, string metodo)
        {
            string dir = String.Format(url + parametros);
            req = (HttpWebRequest)WebRequest.Create(dir);

            req.ContentType = "application/json";
            req.Method = metodo;

        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexGym()
        {
            return View();
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult Registrarse()
        {
            return View();
        }

        public ActionResult Principal()
        {
            return View();
        }

        // GET: GimnasioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GimnasioController/Create
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult RegistraGYM(Gimnasio GYM)
        {
            string responseBody = "";

            conexion("/registrarse", "POST");
            string json = JsonSerializer.Serialize(GYM);

            StreamWriter stream = new StreamWriter(req.GetRequestStream());

            stream.Write(json);
            stream.Flush();
            stream.Close();

            try
            {
                using (WebResponse response = req.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) System.Diagnostics.Debug.WriteLine("NULL"); ;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            System.Diagnostics.Debug.WriteLine("repuesta*************"+responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine("**********error*************");
                // Handle error
            }

            Respuesta respuesta = Newtonsoft.Json.JsonConvert.DeserializeObject<Respuesta>(responseBody);

            if (respuesta.Resultado == "2")
            {
                return View("Principal");
            }
            else
            {
                return View("Registrarse", "El usuario ya existe");
            }

            
        }

        public ActionResult IniciarGYM(Gimnasio GYM)
        {
            string responseBody = "";

            conexion("/iniciar", "POST");
            string json = JsonSerializer.Serialize(GYM);

            StreamWriter stream = new StreamWriter(req.GetRequestStream());

            stream.Write(json);
            stream.Flush();
            stream.Close();

            try
            {
                using (WebResponse response = req.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) System.Diagnostics.Debug.WriteLine("NULL"); ;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            System.Diagnostics.Debug.WriteLine("repuesta*************" + responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine("**********error*************");
                // Handle error
            };

            //var obj = JObject.Parse(responseBody);
            
            Respuesta respuesta= Newtonsoft.Json.JsonConvert.DeserializeObject<Respuesta>(responseBody);
            if (respuesta.Resultado == "1")
            {
                return View("Principal");
            }
            else
            {
                return View("IniciarSesion", "Usuario y contraseña inválidos");
            }


        }

    }

}

