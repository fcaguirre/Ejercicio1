using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Seccion5
    {
        public static void Ejecutar()
        {
            String[] opciones =
    {
            "Tabla multiplicar con while",
            "Comprobar si es numero primo",
            "Factores primos de un numero",
            "Generar N numeros primos",
            "Ejercicio propuesto(5)",
            "Verificacion de una clave 3 intentos",
            "Generar numero aleatorio entre 10 y 30",
            "Juego adivina numero",
            "Control de una factura",
            "Votaciones por sector",
            };
            while (true)
            {
                Extras.Menu(opciones);
                if (int.TryParse(Extras.ElegirOp(), out int opc))
                {
                    switch (opc)
                    {
                        case 0:
                            return;
                        case 1:
                            Seccion5.TablasMulW();
                            break;
                        case 2:
                            Seccion5.CompNPrimo();
                            break;
                        case 3:
                            Seccion5.FactoresPrimosN();
                            break;
                        case 4:
                            Seccion5.GenerarNnPrimos();
                            break;
                        case 5:
                            Seccion5.EjP5();
                            break;
                        case 6:
                            Seccion5.VerifClave3Int();
                            break;
                        case 7:
                            Seccion5.GenNAl10_30();
                            break;
                        case 8:
                            Seccion5.JuegoAdN();
                            break;
                        case 9:
                            Seccion5.ControlFac();
                            break;
                        case 10:
                            Seccion5.VotXSector();
                            break;
                        default:
                            Console.WriteLine("Ejercicio invalido");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
        }
        public static void TablasMulW()
        {
            int NUM, RESUL, T, I;
            string linea;
            Console.Write("CUANTAS TABLAS: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            T = 1;
            while ((T <= NUM))
            {
                I = 10;
                while (!((I < 1)))
                {
                    RESUL = T * I;
                    Console.WriteLine("{0} * {1} = {2}", T, I, RESUL);
                    I = I - 1;
                }
                Console.Write("Pulse una Tecla:"); Console.ReadLine();
                T = T + 1;
            }
        }
        public static void CompNPrimo()
        {
            int n, x, sw, resi;
            string linea;
            x = 2;
            sw = 0;
            Console.WriteLine("NUMERO PRIMO");
            Console.WriteLine();
            Console.Write("Ingrese el numero:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x < n && sw == 0)
            {
                resi = n % x;
                if (resi == 0)
                {
                    sw = 1;
                }
                else
                {
                    x = x + 1;
                }
            }
            if (sw == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero es PRIMO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero no es PRIMO");
            }
            Console.ReadKey();
        }
        public static void FactoresPrimosN()
        {
            int NUM, RESI, K;
            string linea;
            Console.Write("NÚMERO: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            K = 2;
            while ((NUM != 1))
            {
                RESI = NUM % K;
                if ((RESI == 0))
                {
                    Console.WriteLine(K);
                    NUM = NUM / K;
                }
                else
                {
                    K = K + 1;
                }
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void GenerarNnPrimos()
        {
            int NUM, RESI, K, SW, CAN, X;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = int.Parse(linea);
            NUM = 1; X = 0;
            while ((X < CAN))
            {
                K = 2; SW = 0;
                while (((K < NUM) & (SW == 0)))
                {
                    RESI = NUM % K;
                    if ((RESI == 0))
                    {
                        SW = 1;
                    }
                    else
                    {
                        K = K + 1;
                    }
                }
                if ((SW == 0))
                {
                    Console.Write(NUM + " ");
                    X = X + 1;
                }
                NUM = NUM + 1;
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void EjP5()
        {
            int NUM, I, Z, cont = 0;
            string linea;
            Console.Write("DIGITE NÚMERO:"); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            Z = linea.Length;
            I = Z;
            while ((I >= 1))
            {
                I--;
                cont++;
            }
            Console.WriteLine();
            Console.WriteLine("El numero ingresado tiene " + cont + "digitos");
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void VerifClave3Int()
        {
            byte K, SW;
            string CLAVE;
            SW = 0; K = 0;
            do
            {
                Console.Write("DIGITE CLAVE: "); CLAVE = Console.ReadLine();
                if ((CLAVE.ToUpper() == "ARIEL"))
                {
                    SW = 1;
                }
                else
                {
                    K++;
                }
            } while (((K < 3) & (SW == 0)));
            if (SW == 1)
            {
                Console.WriteLine("BIENVENIDO " + CLAVE);
            }
            else
            {
                Console.WriteLine("OPORTUNIDADES TERMINADAS");
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void GenNAl10_30()
        {
            int NUM;
            string OP;
            Random ran = new Random();
            do
            {
                do
                {
                    NUM = Convert.ToInt32(ran.Next(100));
                } while (!(((NUM >= 10) & (NUM <= 30))));
                Console.WriteLine("SE GENERO EL " + NUM);
                Console.Write("GENERA OTRO NÚMERO S/N:"); OP = Console.ReadLine();
                OP = OP.ToUpper();
            } while (OP == "S");
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void JuegoAdN()
        {
            const int OPOR = 4;
            int NUM, ADI;
            byte I, SW;
            string linea;
            //GENERO EL NÚMERO ENTRE 1 AL 20;
            Random ran = new Random();
            do
            {
                NUM = Convert.ToInt32(ran.Next(100));
            } while (!(((NUM >= 1) & (NUM <= 20))));
            //PROCESO;
            I = 1; SW = 0;
            do
            {
                Console.Write("PIENSA QUÉ NÚMERO SERÁ:"); linea = Console.ReadLine();
                ADI = int.Parse(linea);
                if ((ADI == NUM))
                {
                    Console.WriteLine("ADIVINASTE ERES GENIAL");
                    SW = 1;
                }
                else
                {
                    if ((ADI > NUM))
                    {
                        Console.WriteLine("TE PASASTE");
                    }
                    else
                    {
                        Console.WriteLine("ESTÁS BAJO");
                    }
                }
                I++;
            } while (((I <= OPOR) & (SW == 0)));
            if ((SW == 0))
            {
                Console.Write("EL NÚMERO FUE: " + NUM);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void ControlFac()
        {
            string PROD;
            int CAN = 0;
            int FI = 0;
            double PRE = 0;
            double TOT = 0;
            double PAGA = 0;
            char OP;
            string linea;
            FI = 6;
            PAGA = 0;
            Console.SetCursorPosition(5, 4);
            Console.Write("PRODUCTO CANTIDAD PRECIO TOTAL");
            do
            {
                Console.SetCursorPosition(5, FI);
                PROD = Console.ReadLine();
                Console.SetCursorPosition(17, FI);
                linea = Console.ReadLine();
                CAN = int.Parse(linea);
                Console.SetCursorPosition(27, FI);
                linea = Console.ReadLine();
                PRE = int.Parse(linea);
                TOT = CAN * PRE;
                Console.SetCursorPosition(33, FI);
                Console.Write(TOT);
                PAGA = PAGA + TOT;
                FI = FI + 1;
                Console.SetCursorPosition(30, 23);
                Console.Write("OTRO PRODUCTO S/N:");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());
            } while (OP.ToString().Contains("S"));
            Console.WriteLine("TOTAL A PAGAR :" + PAGA);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        public static void VotXSector()
        {
            int CANN = 0;
            int CANS = 0;
            int CANC = 0;
            char OP;
            string ZONA, linea;
            CANN = 0;
            CANC = 0;
            CANS = 0;
            do
            {
                Console.Write("QUE SECTOR NORTE,CENTRO,SUR:");
                ZONA = Console.ReadLine();
                switch (ZONA.ToUpper())
                {
                    case "NORTE":
                        CANN = CANN + 1;
                        break;
                    case "CENTRO":
                        CANC = CANC + 1;
                        break;
                    case "SUR":
                        CANS = CANS + 1;
                        break;
                }
                Console.Write(" HAY OTRA PERSONA S/N:");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());
            } while (OP.ToString().Contains("S"));
            Console.WriteLine("DE LA ZONA NORTE :" + CANN);
            Console.WriteLine("DE LA ZONA CENTRO :" + CANC);
            Console.WriteLine("DE LA ZONA SUR :" + CANS);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
