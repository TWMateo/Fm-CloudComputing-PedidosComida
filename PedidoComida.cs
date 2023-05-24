using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosComida.Modelos
{
    public class PedidoComida
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }

        public double Total { get; set; }

        //Relaciones
        public int ClienteIdCliente { get; set; } //FK
        public Cliente? Cliente { get; set; }
    }
}
