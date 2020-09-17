using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Seccion3
    {
        public static void Ejecutar()
        {
            String[] opciones =
           {
            "Presupuesto anual en areas hospital",
            "Suma de N numeros pares e impares",
            "Tablas de multiplicar",
            "Suma de N numeros",
            "Mayor y menor de N numeros",
            "Serie de Fibonacci",
            "Calificaciones de un grupo de estudiantes",
            "Numeros aleatorios y caracteres ASCII",
            "Funciones de cadenas",
            "Simulacion de un reloj digital",
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
                            Seccion3.PresupuestoAAH();
                            break;
                        case 2:
                            Seccion3.SumaNPI();
                            break;
                        case 3:
                            Seccion3.TMul2();
                            break;
                        case 4:
                            Seccion3.SumNNum();
                            break;
                        case 5:
                            Seccion3.MmNNum();
                            break;
                        case 6:
                            Seccion3.Fibonacci();
                            break;
                        case 7:
                            Seccion3.CalEstudiantes();
                            break;
                        case 8:
                            Seccion3.RandomNyCASCII();
                            break;
                        case 9:
                            Seccion3.StringF();
                            break;
                        case 10:
                            Seccion3.SimDClock();
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
        static void PresupuestoAAH()
        {
            double CANP, TOT, PORC;
            string AREA, linea;
            byte CAN, I;
            Console.Write("CUANTOS CALCULOS: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            Console.Write("DIGITE TOTAL DEL PRESUPUESTO: "); linea = Console.ReadLine();
            CANP = double.Parse(linea);
            for (I = 1; I <= CAN; I++)
            {
                Console.Write("DIGITE ÁREA: "); AREA = Console.ReadLine();
                switch (AREA.ToUpper())
                {
                    case "GINECOLOGIA":
                        ; PORC = 40;
                        break;
                    case "TRAUMATOLOGIA":
                        ; PORC = 30;
                        break;
                    case "PEDIATRIA":
                        ; PORC = 30;
                        break;
                    default:
                        PORC = 0;
                        break;
                }
                TOT = (CANP * PORC) / 100;
                Console.WriteLine(AREA + " RECIBE " + String.Format("{0:C}", TOT));
            }
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void SumaNPI()
        {
            byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;
            string linea;
            Console.Write("NÚMERO MÁXIMO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (I = 1; I <= NUM; I += 2)
            {
                SUMP += + I;
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI += + I;
            }
            Console.WriteLine("TOTAL EN PARES : " + SUMP);
            Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void TMul2()
        {
            int NUM, RESUL, T, I;
            string linea;
            Console.Write("CUANTAS TABLAS: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            for (T = 1; T <= NUM; T++)
            {
                for (I = 10; I >= 1; I--)
                {
                    RESUL = T * I;
                    Console.WriteLine("{0} * {1} = {2}", T, I, RESUL);
                }
            }
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void SumNNum()
        {
            byte CAN, K;
            int NUM;
            int SUM = 0;
            string linea;
            Console.Write("LÍMITE:"); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                SUM += NUM;
            }
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void MmNNum()
        {
            byte CAN, K;
            int MAY, MEN, NUM;
            string linea;
            Console.Write("LÍMITE:"); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
            MAY = int.Parse(linea);
            MEN = MAY;
            for (K = 2; K <= CAN; K++)
            {
                Console.Write("DIGITE UN NÚMERO:"); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                if (NUM > MAY) MAY = NUM;
                if (NUM < MEN) MEN = NUM;
            }
            Console.WriteLine("EL MAYOR ES : " + MAY);
            Console.WriteLine("EL MENOR ES : " + MEN);
            Console.WriteLine("DIFERENCIA ES : " + (MAY - MEN));
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void Fibonacci()
        {
            byte CAN, K;
            int A, B, C;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            A = 1; B = 1;
            Console.Write(A + " " + B + " ");
            for (K = 3; K <= CAN; K++)
            {
                C = A + B;
                Console.Write(C + " ");
                //INTERCAMBIO DE VALORES
                A = B;
                B = C;
            }
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void CalEstudiantes()
        {
            byte CAN, K;
            double NOTA1, NOTA2, PROM, SUM;
            string NOM, linea;
            Console.Write("CUANTOS ESTUDIANTES: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            SUM = 0;
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("NOMBRE: "); NOM = Console.ReadLine();
                Console.Write("NOTA 1: "); linea = Console.ReadLine();
                NOTA1 = double.Parse(linea);
                Console.Write("NOTA 2: "); linea = Console.ReadLine();
                NOTA2 = double.Parse(linea);
                PROM = (NOTA1 + NOTA2) / 2;
                Console.WriteLine("PROMEDIO: " + PROM);
                SUM += PROM;
            }
            Console.WriteLine();
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void RandomNyCASCII()
        {
            byte CAN, K;
            int NUM;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            //INICIALIZA EL GENERADOR DE ALEATORIOS
            Random ran = new Random(); //clase tipo random
            for (K = 1; K <= CAN; K++)
            {
                NUM = Convert.ToInt32(ran.Next(100));
                Console.WriteLine("GENERÓ EL: " + NUM);
                if (((NUM > 0) & (NUM < 256)))
                {
                    Console.WriteLine("EL CÓDIGO DEL " + NUM + " ES " + Convert.ToString((char)NUM)); //convierte a string, similar a parse
                }
            }
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void StringF()
        {
            string NOM;
            byte K;
            Console.Write("DIGITE SU NOMBRE : "); NOM = Console.ReadLine();
            Console.WriteLine("LONGITUD : " + NOM.Length); //longitud
            Console.WriteLine("ESTA DENTRO : " + NOM.Contains("ARIEL")); //bool contiene subcadena
            Console.WriteLine("REEMPLAZO VOCAL A: " + NOM.Replace("A", "X")); //reemplaza caracter
            Console.WriteLine("EN MINUSCULAS : " + NOM.ToLower()); //transforma a minusculas
            Console.WriteLine("EN MAYÚSCULAS : " + NOM.ToUpper()); //transforma a mayuscula
            Console.WriteLine("REMOVER 4 LETRAS : " + NOM.Remove(3, 4)); // remueve los caracteres entre los indices
            Console.WriteLine("EXTRAER 4 LETRAS : " + NOM.Substring(3, 4)); //devuelve la cadena entre los indices
            Console.WriteLine("IZQUIERDA 4 LETRAS : " + Extras.Left(NOM, 4)); //llama la funcion left
            Console.WriteLine("DERECHA 4 LETRAS : " + Extras.Right(NOM, 4)); //llama la funcion right
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("DESDE LA IZQUIERDA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Extras.Left(NOM, K));
            }
            Console.WriteLine();
            Console.WriteLine("DESDE LA DERECHA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Extras.Right(NOM, K));
            }
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        
        static void SimDClock()
        {
            byte H, M, S;
            Console.SetCursorPosition(15, 2);
            Console.Write("SIMULACIÓN DE UN RELOJ DIGITAL");
            for (H = 0; H <= 24; H++)
            {
                for (M = 0; M <= 59; M++)
                {
                    for (S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(20, 10);  //mueve el cursor a la columna y fila en consola
                        Console.Write("{0} : {1} : {2}", H, M, S);
                    }
                }
            }
            Console.SetCursorPosition(25, 15);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
    }
}
