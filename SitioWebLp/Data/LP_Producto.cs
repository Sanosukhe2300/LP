namespace SitioWebLp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LP_Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string TipoProducto { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        public string Foto1 { get; set; }

        public string Foto2 { get; set; }

        public decimal Precio { get; set; }
    }
}
