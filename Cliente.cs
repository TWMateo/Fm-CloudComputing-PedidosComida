using System.ComponentModel.DataAnnotations;

namespace PedidosComida.Modelos
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public String cedula { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String telefono { get; set; }

        //Relaciones
        public List<PedidoComida>? Pedidos { get; set; }
    }
}