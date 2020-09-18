using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Seccion4
    {
        public static void Ejecutar()
        {
            String[] opciones =
    {
            "Contar vocales cerradas",
            "Estadistica por vocal",
            "Factorial de un numero",
            "Serie de un numero",
            "Sucesion de N cuadros",
            "Mover frase",
            "Mover Caracter por Caracter Horizontal",
            "Mover Caracter por Caracter Vertical",
            "Ejercicio propuesto(4)",
            "Tabla multiplicar con while",
            };
            while (true)
            {
                Extras.MenuSeccion(opciones);
                if (int.TryParse(Extras.ElegirOp(), out int opc))
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 0:
                            return;
                        case 1:
                            CVocalesCerradas();
                            break;
                        case 2:
                            EstXVoc();
                            break;
                        case 3:
                            Factorial();
                            break;
                        case 4:
                            SerieNum();
                            break;
                        case 5:
                            SucesionNCuadros();
                            break;
                        case 6:
                            MovFrase();
                            break;
                        case 7:
                            MovCCH();
                            break;
                        case 8:
                            MovCCV();
                            break;
                        case 9:
                            EjP4();
                            break;
                        case 10:
                            TablaMulW();
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
        public static void CVocalesCerradas()
        {
            string NOM;
            int K, SUM;
            string LE;
            Console.Write("DIGITE UNA FRASE : "); NOM = Console.ReadLine();
            SUM = 0;
            NOM = NOM.ToUpper();
            Console.Write(NOM);
            for (K = 1; K < NOM.Length; K++)
            {
                LE = Extras.Mid(NOM, K, 1);
                if (LE.Contains("U") || LE.Contains("I"))
                {
                    SUM = SUM + 1;
                }
            }
            Console.WriteLine("EXISTEN {0} VOCALES CERRADAS", SUM);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        
        public static void EstXVoc()
        {
            string NOM;
            int K = 0;
            int A = 0;
            int E = 0;
            int I = 0;
            int O = 0;
            int U = 0;
            string LE;
            Console.Write("DIGITE UNA FRASE : ");
            NOM = Console.ReadLine();
            A = 0;
            E = 0;
            I = 0;
            O = 0;
            U = 0;
            for (K = 1; K < NOM.Length; K++)
            {
                NOM = NOM.ToUpper();
                LE = Extras.Mid(NOM, K, 1);
                switch (LE)
                {
                    case "A":
                        A = A + 1;
                        break;
                    case "E":
                        E = E + 1;
                        break;
                    case "I":
                        I = I + 1;
                        break;
                    case "O":
                        O = O + 1;
                        break;
                    case "U":
                        U = U + 1;
                        break;
                }
            }
            Console.WriteLine("EXISTEN {0} VOCALES A", A);
            Console.WriteLine("EXISTEN {0} VOCALES E", E);
            Console.WriteLine("EXISTEN {0} VOCALES I", I);
            Console.WriteLine("EXISTEN {0} VOCALES O", O);
            Console.WriteLine("EXISTEN {0} VOCALES U", U);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        
        public static void Factorial()
        {
            byte NUM, K;
            long RESUL = 1;
            string linea;
            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 2; K <= NUM; K++)
            {
                RESUL = RESUL * K;
            }
            Console.WriteLine("EL FACTORIAL ES: " + RESUL);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void SerieNum()
        {
            byte NUM, K, F;
            long FAC;
            double RESUL = 0;
            string linea;
            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 1; K <= NUM; K++)
            {
                FAC = 1;
                for (F = 1; F <= K; F++)
                {
                    FAC *= F;
                }
                RESUL += (K / FAC);
            }
            Console.WriteLine("RESULTADO DE LA SERIE ES: " + RESUL);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void SucesionNCuadros()
        {
            int CAN, F, C, T, FI, FF, CI, CF;
            string linea;
            Console.Write("DIGITE UN NÚMERO MÁX=10: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            FI = 2; FF = 22;
            CI = 2; CF = 77;
            for (T = 1; T <= CAN; T++)
            {
                for (F = CI; F <= CF; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("X");
                    Console.SetCursorPosition(F, FI); Console.Write("X");
                }
                for (C = FI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X");
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                FI = FI + 1; FF = FF - 1;
                CI = CI + 1; CF = CF - 1;
            }
            Console.WriteLine();
            Console.SetCursorPosition(25, 24); Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
        public static void MovFrase()
        {
            string NOM;
            byte K;
            Console.Write("SU NOMBRE ES: "); NOM = Console.ReadLine();
            for (K = 1; K <= 70; K++)
            {
                Console.SetCursorPosition(K, 12);
                Console.Write(" " + NOM);
                //REALIZAMOS UNA PAUSA;
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void MovCCH()
        {
            string NOM;
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;
            int CF = 0;
            Console.Write("SU NOMBRE ES: ");
            NOM = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(NOM);
            CI = NOM.Length;
            CF = 70;
            NOM = NOM.ToUpper();
            for (P = NOM.Length; P >= 1; P--)
            {
                CAR = Extras.Mid(NOM, P - 1, 1);
                for (K = CI; K <= CF; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + CAR);
                    // REALIZAMOS UNA PAUSA
                    System.Threading.Thread.Sleep(50);
                }
                CF = CF - 1;
                CI = CI - 1;
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
        public static void MovCCV()
        {
            string NOM;
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;
            Console.Write("SU NOMBRE ES: ");
            NOM = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(25, 1);
            Console.Write(NOM);
            CI = 25;
            NOM = NOM.ToUpper();
            for (P = 1; P <= NOM.Length; P++)
            {
                CAR = Extras.Mid(NOM, P - 1, 1);
                for (K = 1; K <= 22; K++)
                {
                    Console.SetCursorPosition(CI, K);
                    Console.Write(CAR);
                    // REALIZAMOS UNA PAUSA
                    System.Threading.Thread.Sleep(50);
                    Console.SetCursorPosition(CI, K);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(CI, K);
                Console.Write(CAR);
                CI = CI + 1;
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
        public static void EjP4()
        {
            int i;
            Console.Write("ABECEDARIO DESCENDENTE");
            Console.WriteLine();
            for (i = 90; i >= 65; i--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((char)i));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static void TablaMulW()
        {
            int NUM, I, RESUL;
            string linea;
            Console.Write("DIGITE NÚMERO:"); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
                I = I + 1;
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
