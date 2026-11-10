using System;

namespace SoftwarePrime.Pantallas.Compras
{
    public class CategoriaCompra
    {
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }

        public CategoriaCompra()
        {
            Activo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
