namespace AcmePedidos.Models
{
    public class XMLPedido
    {
        public envioPedidoAcme envioPedidoAcme { get; set; }
    }

    public class envioPedidoAcme
    {
        public envioPedidoRequest EnvioPedidoRequest { get; set; }
    }
    public class envioPedidoRequest
    {
        public string pedido { get; set; }
        public string Cantidad { get; set; }
        public string EAN { get; set; }
        public string Producto { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
    }
}
