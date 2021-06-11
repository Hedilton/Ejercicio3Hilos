using System;
using System.Collections.Generic;//contiene interfaces y clases que definen colecciones genericas,permiten estar tipadas
using System.Linq;//conjunto de extensiones integradas en c#,permite trabajar mas comodo
using System.Text;//contiene clases que representan codificaciones de caracteres
using System.Threading;

namespace Ejercicio3Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread x = new Thread(proceso1);
            Thread y = new Thread(proceso2);
            x.Start();
            y.Start();
        }
        static void proceso1()
        {
            int j=0;
            for(int i=1;i<=6;i++)
            {
                j++;
                if(j>4)
                {
                    Console.WriteLine("Usuario en espera");
                    Thread.Sleep(3000);
                    j = 0;
                }
                    Console.WriteLine("Usuario utilizando lavadero");
            }
        }
        static void proceso2()
        {
            int j=0;
            for (int i = 2; i <= 6; i=i+2)
            {
                j=j+2;
                if (j > 4)
                {
                    Console.WriteLine("Usuarios con malestar");
                    Thread.Sleep(3000);
                    j = 0;
                }
                Console.WriteLine("Usuarios mayores de edad utilizando lavadero");

            }
        }
    }
}
