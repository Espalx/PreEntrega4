using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class ProductoVendido
    {
        // propiedades de la clase
        private int Id { get; set; }
        private int Stock { get; set; }
        private int IdProducto { get; set; }
        private int IdVenta { get; set; }

        // metodos de acceso a los compos encampulados
        public int id
        {
            get => Id; set => Id = value;
        }
        public int stock
        {
            get => Stock; set => Stock = value;
        }
        public int idproducto
        {
            get => IdProducto; set => IdProducto = value;
        }
        public int idventa
        {
            get => IdVenta; set => IdVenta = value;
        }
        public ProductoVendido()
        {

        }
        public ProductoVendido(int id, int stock, int idproducto, int idventa)
        {
            this.Id = id;
            this.Stock = stock;
            this.IdProducto = idproducto;
            this.IdVenta = idventa;
        }

        public override string ToString()
        {
            return $"Id:{Id} Stock: {Stock} \"IdProducto: {IdProducto} \"IdVenta: {IdVenta} ";
        }
    }

}

