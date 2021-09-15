using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1fddfs
{
    class operaciones
    {
        private double total;
        private double valorRemeras;

        public operaciones(double total, double valorRemeras) 
        {
            this.total = total;
            this.valorRemeras = valorRemeras;
        }


        public void setTotal(double totalCompra)
        {
            this.total = totalCompra;
        }

        public double getTotal()
        {
            return this.total;
        }

    }
}
