using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto(null, 500.00, 10);


            p.SetNome("T");

            Console.WriteLine(p.GetNome());
           
          

          
            

        }
    }
}
