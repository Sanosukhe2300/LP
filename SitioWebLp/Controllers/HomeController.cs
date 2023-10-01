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

        /// <summary>
        /// Action para cargar el index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<IndexViewModel> listModel = new List<IndexViewModel>();
            
            var query = db.LP_Producto.ToList();

            if (query.Any())
            {
                //Guardamos la lista de productos en una variable de session
                Session["ListaProductos"] = query;

                listModel = query.Select(s => new IndexViewModel()
                {
                    id = s.Id,
                    nombre = s.Nombre,
                    foto1 = string.Format("data:image/png;base64,{0}", s.Foto1),
                    precio = string.Format("${0}", s.Precio.ToString()),
                    precioAnterior = string.Format("${0}", (s.Precio - (0.20m * s.Precio)).ToString("N2"))

                }).ToList();
            }           

            return View(listModel);
        }



        /// <summary>
        /// Action con la logica de el carrito de compras
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public PartialViewResult CartMant(List<int> request)
        {
            List<ListCartModel> model = new List<ListCartModel>();
            int cantidad = 0;
            decimal precioTotal = 0.00M;

            if (request.Any())
            {
                List<LP_Producto> listaProductos = (List<LP_Producto>)Session["ListaProductos"];
                foreach (var item in request)
                {
                    cantidad++;
                   
                    var linePro = model.FirstOrDefault(f => f.id == item);
                    if(linePro == null)
                    {
                        var lint = listaProductos.First(f => f.Id == item);
                        model.Add(new ListCartModel() { foto = string.Format("data:image/png;base64,{0}", lint.Foto1), id = lint.Id, cant = 1, precio = lint.Precio, nombre = lint.Nombre });
                        precioTotal += lint.Precio;
                    }
                    else
                    {
                        precioTotal += linePro.precio;
                        linePro.cant += 1;
                        linePro.precio += linePro.precio;
                        
                    }
                }
            }

            ViewBag.Cantidad = cantidad;
            ViewBag.PrecioTotal = precioTotal;

            return PartialView("_CartMant",model);
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