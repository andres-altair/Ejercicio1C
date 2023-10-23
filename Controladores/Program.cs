using Ejercicio1C.Servicios;

namespace Ejercicio1C.Controladores
{
    class program
    {
        /// <summary>
        /// metodo por donde entra la aplicacion
        /// 231023-aamd
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            solicitarI si = new solicitarC();
            int a = si.solicitar();
            if (a % 2 == 0)
            {
                Console.WriteLine("numero par");
            }
            else { Console.WriteLine("no es par "); }





        }
    }
}