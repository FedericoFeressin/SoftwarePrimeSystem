using System;

namespace SoftwarePrime.Pantallas.EstadoContable
{
    public class ModeloMovimiento
    {
        public int ID_Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; } // "Venta", "Compra", "Compra Varia"
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Egreso { get; set; }
        public int? ID_Venta { get; set; }
        public int? ID_Compra { get; set; }
        public string Referencia { get; set; }
    }

    public class ModeloEstadoContable
    {
        public decimal TotalIngresosPorVentas { get; set; }
        public decimal TotalEgresosPorCompras { get; set; }
        public decimal TotalEgresosPorComprasVarias { get; set; }
        public decimal TotalInsumosEnStock { get; set; }
        public int CantidadComprasInsumos { get; set; }
        public int CantidadVentasInsumos { get; set; }
        public int CantidadComprasVarias { get; set; }
        public decimal SaldoTotal { get; set; }
    }
}
