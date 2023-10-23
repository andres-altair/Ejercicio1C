using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1C.Servicios
{
    internal class solicitarC : solicitarI
    {
        public int solicitar()
        {
            Console.WriteLine("escribe un numero entero");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
