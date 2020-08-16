using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Seccion1
    {
        public static void Ejecutar()
        {
            String[] opciones =
    {
            "Invertir numero de dos Cifras",
            "Invertir numero de tres cifras",
            "Operaciones basicas",
            "Compra en restaurant",
            "Funciones basicas libreria math",
            "Formatos de salida",
            "Ejericio propuesto(1)",
            "Mayor de dos numeros",
            "Mayor de tres numeros",
            "Desglose de billetes",
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
                            Seccion1.Inv2C();
                            break;
                        case 2:
                            Seccion1.Inv2C();
                            break;
                        case 3:
                            Seccion1.OpBasicas();
                            break;
                        case 4:
                            Seccion1.CompR();
                            break;
                        case 5:
                            Seccion1.BasFMath();
                            break;
                        case 6:
                            Seccion1.FormOut();
                            break;
                        case 7:
                            Seccion1.EjP1();
                            break;
                        case 8:
                            Seccion1.Max2N();
                            break;
                        case 9:
                            Seccion1.Max3N();
                            break;
                        case 10:
                            Seccion1.Desglose();
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
        public static void Inv2C()
        {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("Ingrese numero de dos cifras");
            linea = Console.ReadLine();
            NUM = int.Parse(linea); //Parse castea a tipo de variable
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("Numero invertido es: " + AUX);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void Inv3C()
        {
            int NUM, AUX, DEC, UNI, CEN;
            string linea;
            Console.WriteLine("Ingrese numero de tres cifras");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM %= 100; //error
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("Numero invertido es: " + AUX);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void OpBasicas()
        {
            int NUM1, NUM2, RESUL;
            string linea;

            Console.WriteLine("Primer numero:");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);

            Console.WriteLine("Segundo numero:");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);

            RESUL = NUM1 + NUM2;
            Console.WriteLine("La suma es {0}:", RESUL);  //{x} es un argumento

            RESUL = NUM1 - NUM2;
            Console.WriteLine("La resta es {0}:", RESUL);

            RESUL = NUM1 * NUM2;
            Console.WriteLine("La multiplicacion es {0}:", RESUL);

            RESUL = NUM1 / NUM2;
            Console.WriteLine("La division es {0}:", RESUL);

            RESUL = NUM1 % NUM2;
            Console.WriteLine("EL resto es {0}:", RESUL);

            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void CompR()
        {
            byte CANB, CANH, CANP;
            double A_Pagar;
            string linea;
            const double PRECIOB = 0.8;
            const double PRECIOH = 2;
            const double PRECIOP = 1.2;
            Console.Write("Cantidad de hamburgesas:"); linea = Console.ReadLine();
            CANH = byte.Parse(linea);
            Console.Write("Cantidad de papas:"); linea = Console.ReadLine();
            CANP = byte.Parse(linea);
            Console.Write("Cantidad de bebidas:"); linea = Console.ReadLine();
            CANB = byte.Parse(linea);
            Console.WriteLine();
            A_Pagar = (CANH * PRECIOH) + (CANB * PRECIOB) + (CANP * PRECIOP);
            Console.WriteLine("TOTAL:" + A_Pagar);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void BasFMath()
        {
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("DIGITE UN NÚMERO :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1); //libreria math? abs = valor absoluto
            Console.WriteLine("VALOR ABSOLUTO : " + RESUL);
            Console.WriteLine("POTENCIA : " + Math.Pow(NUM1, 3)); //pow = potencia
            Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1)); //sqrt = raiz
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180)); // sin = seno ; PI = pi
            Console.WriteLine("COSENO : " + Math.Cos(NUM1 * Math.PI / 180));// cos = coseno
            Console.WriteLine("NÚMERO MÁXIMO : " + Math.Max(NUM1, 50)); //Max = maximo entre 2
            Console.WriteLine("NÚMERO MÍNIMO : " + Math.Min(NUM1, 50)); // min = minimo entre 2
            Console.WriteLine("PARTE ENTERA : " + Math.Truncate(18.78)); // calcula la parte entera de n
            Console.WriteLine("REDONDEO : " + Math.Round(18.78)); // redondea
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void FormOut()
        {
            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL)); //preguntar string.format
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd} {0:dd/MM/yyy}", DateTime.Now));
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void EjP1()
        {
            int NUM1, NUM2;
            double RESUL;
            string linea;
            Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void Max2N()
        {
            int NUM1, NUM2;
            string linea;
            Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            if ((NUM1 > NUM2))
            {
                Console.WriteLine("{0} ES MAYOR QUE {1}", NUM1, NUM2);
            }
            else
            {
                if ((NUM1 == NUM2))
                {
                    Console.WriteLine("{0} ES IGUAL A {1}", NUM1, NUM2);
                }
                else
                {
                    Console.WriteLine("{0} ES MENOR QUE {1}", NUM1, NUM2);
                }
            }
            Console.WriteLine();
            Console.WriteLine("OTRA MANERA");
            string RESUL;
            if (NUM1 > NUM2)
            {
                RESUL = "MAYOR";
            }
            else
            if (NUM1 == NUM2)
            {
                RESUL = "IGUAL";
            }
            else
            {
                RESUL = "MENOR";
            }
            Console.WriteLine("{0} ES {1} QUE {2}", NUM1, RESUL, NUM2);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void Max3N()
        {
            byte MAY, MEN, NUM1, NUM2, NUM3;
            string linea;
            Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
            NUM1 = byte.Parse(linea);
            Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
            NUM2 = byte.Parse(linea);
            Console.Write("NÚMERO 3 :"); linea = Console.ReadLine();
            NUM3 = byte.Parse(linea);
            MAY = NUM1; MEN = NUM1;
            if ((NUM2 > MAY)) MAY = NUM2;
            if ((NUM3 > MAY)) MAY = NUM3;
            if ((NUM2 > MEN)) MEN = NUM2;
            if ((NUM3 < MEN)) MEN = NUM3;
            Console.WriteLine("MAYOR ES:" + MAY);
            Console.WriteLine("MENOR ES:" + MEN);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }
        public static void Desglose()
        {
            int CAN, C100, C50, C20, C10, C5;
            C100 = 0;
            C50 = 0;
            C20 = 0;
            C10 = 0;
            C5 = 0;
            string linea;
            Console.Write("DIGITE UNA CANTIDAD :"); linea = Console.ReadLine();
            CAN = int.Parse(linea);
            if ((CAN >= 100))
            {
                C100 = (CAN / 100);
                CAN -= (C100 * 100);
            }
            if ((CAN >= 50))
            {
                C50 = (CAN / 50);
                CAN -= (C50 * 50);
            }
            if ((CAN >= 20))
            {
                C20 = (CAN / 20);
                CAN -= (C20 * 20);
            }
            if ((CAN >= 10))
            {
                C10 = (CAN / 10);
                CAN -= (C10 * 10);
            }
            if ((CAN >= 5))
            {
                C5 = (CAN / 5);
                CAN -= (C5 * 5);
            }
            Console.WriteLine("BILLETES DE A 100: " + C100);
            Console.WriteLine("BILLETES DE A 50 : " + C50);
            Console.WriteLine("BILLETES DE A 20 : " + C20);
            Console.WriteLine("BILLETES DE A 10 : " + C10);
            Console.WriteLine("BILLETES DE A 5 : " + C5);
            Console.WriteLine("BILLETES DE A 1 : " + CAN);
            Console.WriteLine("pulse una tecla:"); Console.ReadKey();
        }

    }
}
