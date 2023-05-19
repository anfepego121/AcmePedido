using Microsoft.AspNetCore.Mvc;
using AcmePedidos.Models;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

namespace AcmePedidos.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class ClienteController : ControllerBase
    {


        [HttpPost]
        [Route("enviar")]
        public dynamic enviarPedido(Pedido enviarPedido)
        {
            XMLPedido PedidoXML = new XMLPedido();
            envioPedidoAcme envioPedidoAcme = new envioPedidoAcme();
            envioPedidoRequest envioRequest= new envioPedidoRequest
            {
                pedido = enviarPedido.enviarPedido.numPedido,
                Cantidad = enviarPedido.enviarPedido.cantidadPedido,
                EAN = enviarPedido.enviarPedido.codigoEAN,
                Producto = enviarPedido.enviarPedido.nombreProducto,
                Cedula = enviarPedido.enviarPedido.numDocumento,
                Direccion = enviarPedido.enviarPedido.direccion

            };
            envioPedidoAcme.EnvioPedidoRequest = envioRequest;
            PedidoXML.envioPedidoAcme = envioPedidoAcme;

            XmlSerializer request = new XmlSerializer(typeof(XMLPedido));

            using (StreamWriter streamWriter = new StreamWriter("D:\\PedidoRequest.xml"))
            {
                request.Serialize(streamWriter, PedidoXML);
            }

            PedidoResponse pedidoResponse = new PedidoResponse();
            enviarPedidoRespuesta enviarPedidoRespuesta = new enviarPedidoRespuesta
            {
                codigoEnvio = "80375472",
                estado = "Entregado exitosamente al cliente"
            };
            pedidoResponse.enviarPedidoRespuesta = enviarPedidoRespuesta;

            XmlSerializer response = new XmlSerializer(typeof(PedidoResponse));

            using (StreamWriter streamWriter = new StreamWriter("D:\\PedidoResponse.xml"))
            {
                response.Serialize(streamWriter, pedidoResponse);
            }

            return pedidoResponse;
        }

        
    }
}
