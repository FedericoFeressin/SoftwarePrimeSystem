using System;

namespace SoftwarePrime.Pantallas.Articulos
{
    public class ModeloCategoria
    {
        public int ID_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ModeloCategoria()
        {
            Activo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
