using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ArbolBinarioDeBusqueda arbolBinario = new ArbolBinarioDeBusqueda(20);
            arbolBinario.Insertar(500);
            arbolBinario.Insertar(470);
            arbolBinario.Insertar(501);
            arbolBinario.Insertar(60);
            arbolBinario.Insertar(1);
            arbolBinario.Insertar(58);
            arbolBinario.Insertar(33);

            string arbolBin = arbolBinario.ObtenerArbol();
            foreach (string renglon in arbolBin.Split('\n'))
            {
                int cuentaGuiones = renglon.Count(c => c.ToString() == "-") + 2;
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cuentaGuiones.ToString());
                Console.WriteLine(renglon);
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
