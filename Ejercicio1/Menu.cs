using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Menu
    {
        public Menu()
        {
        }
        public void Ejecutar()
        {
            while (true)
            {
                Console.Clear();
                this.ImpMenu();
                if (int.TryParse(Extras.ElegirOp(), out int opc))
                {
                    switch (opc)
                    {
                        case 0:
                            this.Salir();
                            break;
                        case 1:
                            Seccion1.Ejecutar();
                            break;
                        case 2:
                            Seccion2.Ejecutar();
                            break;
                        case 3:
                            Seccion3.Ejecutar();
                            break;
                        case 4:
                            Seccion4.Ejecutar();
                            break;
                        case 5:
                            Seccion5.Ejecutar();
                            break;
                        default:
                            Console.WriteLine("Seccion invalida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
        }
        public void ImpMenu()
        {
            int i = 1;
            int a = i;
            Console.WriteLine("Elija una seccion:");
            for(; i <= 5; i++)
            {
                Console.WriteLine("{0}. Ejercicios {1}-{2}", i, a, i * 10);
                a += 10;
            }
            Console.WriteLine("\n\n0. Salir");
        }
        private void Salir()
        {
            Console.Clear();
            Console.WriteLine("Saliendo...");
            Thread.Sleep(2500);
            Environment.Exit(0);
        }
    }
}
