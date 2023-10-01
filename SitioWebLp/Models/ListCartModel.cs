using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebLp.Models
{
    public class ListCartModel
    {
        public int id { get; set; }
        public string foto { get; set; }
        public string nombre { get; set; }
        public int cant { get; set; }
        public decimal precio { get; set; }
    }
}