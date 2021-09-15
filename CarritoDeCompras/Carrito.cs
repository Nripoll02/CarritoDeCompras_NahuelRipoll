using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class Carrito
    {
        private int contador;
        private double descuento;
        private double total;
        private double cuentaFinal;



        public Carrito()
        {
            contador = 0;

        }
        public int Contador
        {
            get { return this.contador; }
            set { this.contador = value; }
        }

        public Carrito(double CuentaFinal = 0.0)
        {
            this.CuentaFinal = cuentaFinal;

        }
        public double CuentaFinal
        {
            get { return this.cuentaFinal; }
            set { this.cuentaFinal = value; }
        }
        public Carrito(int descuento = 0)
        {
            this.descuento = descuento;

        }
        public double Descuento
        {
            get { return this.descuento; }
            set { this.descuento = value; }
        }
        public Carrito(double total = 0)
        {
            this.total = total;

        }
        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
    }
}
