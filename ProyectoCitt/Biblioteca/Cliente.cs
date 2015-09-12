using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    class Cliente
    {
        private int _telefono;
        private String _nombre;
        private String _apellido;
        private List<Pedido> _cocina;
              
        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Cliente(int telefono, String apellido, String nombre)
        {
            _telefono = telefono;
            _apellido = apellido;
            _nombre = nombre;
            _cocina = new List<Pedido>();
        }


        public int existe(int id)
        {
            for (int i = 0; i < _cocina.Count(); i++)
            {
                if (_cocina[i] != null && _cocina[i].IdPedido.CompareTo(id) == 0)
                    return i;
            }
            return -1;
        }

        public void agregarPedido(Pedido id)
        {
            if (existe(id.IdPedido) == -1)
                _cocina.Add(id);
        }

        public void eliminar(Pedido id)
        {
            if (existe(id.IdPedido) != -1)
                _cocina.Remove(id);
        }
    }
}
