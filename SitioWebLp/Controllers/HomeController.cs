using SitioWebLp.Data;
using SitioWebLp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebLp.Controllers
{
    public class HomeController : Controller
    {
        //Instanciamos al contexto de la base de datos
        ContextModelDb db = new ContextModelDb();

        public ActionResult Index()
        {
            List<IndexViewModel> listModel = new List<IndexViewModel>();
            
            var query = db.LP_Producto.ToList();

            if (query.Any())
            {
                listModel = query.Select(s => new IndexViewModel()
                {
                    nombre = s.Nombre,
                    foto1 = string.Format("data:image/png;base64,{0}", s.Foto1),
                    precio = string.Format("${0}", s.Precio.ToString()),
                    precioAnterior = string.Format("${0}", (s.Precio - (0.20m * s.Precio)).ToString("N2"))

                }).ToList();
            }           

            return View(listModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}