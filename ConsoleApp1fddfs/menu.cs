using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1fddfs
{
    class menu
    {
        operaciones myOperation = new operaciones(0, 0);

        public void Menu()
        {




            myOperation.setTotal(1000);
            Console.WriteLine("TOTAL" + myOperation.getTotal());





        }
    }
}
