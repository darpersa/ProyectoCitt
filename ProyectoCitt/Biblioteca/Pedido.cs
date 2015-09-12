using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    class Pedido
    {
        private String _pedido;
        private int _idPedido;
       
        public int IdPedido
        {
            get { return _idPedido; }
            set { _idPedido = value; }
        }
        

        public String Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }

        public Pedido(String pedido, int idPedido)
        {
            _pedido = pedido;
            _idPedido = idPedido;
        }
    }
}
