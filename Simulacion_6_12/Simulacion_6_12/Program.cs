using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulacion_6_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.Write("\nIngrese el número de ensayos: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese la probabilidad de éxito en cada ensayo: ");
            double p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese el dato original: ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            double media3 = n2 * p2;
            double desviacionEstandar3 = Math.Sqrt(n2 * p2 * (1 - p2));
            double z = (x3 - media3) / desviacionEstandar3;
            double probabilidad = Normal.CDF(0, 1, z);
            double resultado = 1 - probabilidad;

            Console.WriteLine("\n\nLa probabilidad de que {0} o más niños afectados tengan madres que fumaban es: {1}", x3, resultado.ToString("0.0000\n"));
        }
    }
}
