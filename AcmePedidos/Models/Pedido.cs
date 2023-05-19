namespace AcmePedidos.Models
{
    public class Pedido
    {
        public enviarPedido enviarPedido { get; set; }
    }

    public class PedidoResponse
    {
        public enviarPedidoRespuesta enviarPedidoRespuesta { get; set; }
    }

    public class enviarPedido
    {
        public string numPedido { get; set; }
        public string cantidadPedido { get; set; }
        public string codigoEAN { get; set; } 
        public string nombreProducto { get; set; }
        public string numDocumento { get; set; }
        public string direccion { get; set; }
    }

    public class enviarPedidoRespuesta
    {
        public string codigoEnvio { get; set; }
        public string estado { get; set; }
    }
}
