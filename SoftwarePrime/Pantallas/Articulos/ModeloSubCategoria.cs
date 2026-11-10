using System;

namespace SoftwarePrime.Pantallas.Articulos
{
    public class ModeloSubCategoria
    {
        public int ID_Subcategoria { get; set; }
        public string Nombre_SubCategoria { get; set; }
        public int ID_Categoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ModeloSubCategoria()
        {
            Activo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
