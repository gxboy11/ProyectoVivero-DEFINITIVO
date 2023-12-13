namespace Proyecto.Domain.DTOs.Productos
{
    public class CarritoItem
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
