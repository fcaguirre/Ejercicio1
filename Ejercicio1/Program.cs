using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("Ingrese numero de dos cifras");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX=(UNI * 10) + DEC;
            Console.WriteLine("Numero invertido es: " + AUX);
            */

            /*
            int NUM, AUX, DEC, UNI, CEN;
            string linea;
            Console.WriteLine("Ingrese numero de tres cifras");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM = NUM % 100; //error
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("Numero invertido es: " + AUX);
            */

            /*
            int NUM1, NUM2, RESUL;
            string linea;

            Console.WriteLine("Primer numero:");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);

            Console.WriteLine("Segundo numero:");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);

            RESUL = NUM1 + NUM2;
            Console.WriteLine("La suma es {0}:", RESUL);

            RESUL = NUM1 - NUM2;
            Console.WriteLine("La resta es {0}:", RESUL);

            RESUL = NUM1 * NUM2;
            Console.WriteLine("La multiplicacion es {0}:", RESUL);

            RESUL = NUM1 / NUM2;
            Console.WriteLine("La division es {0}:", RESUL);

            RESUL = NUM1 % NUM2;
            Console.WriteLine("EL resto es {0}:", RESUL);
            */

            /*byte CANB, CANH, CANP;
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
            */

            /*
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("DIGITE UN NÚMERO :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1);
            Console.WriteLine("VALOR ABSOLUTO : " + RESUL);
            Console.WriteLine("POTENCIA : " + Math.Pow(NUM1, 3));
            Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("COSENO : " + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("NÚMERO MÁXIMO : " + Math.Max(NUM1, 50));
            Console.WriteLine("NÚMERO MÍNIMO : " + Math.Min(NUM1, 50));
            Console.WriteLine("PARTE ENTERA : " + Math.Truncate(18.78));
            Console.WriteLine("REDONDEO : " + Math.Round(18.78));
            */

            /*
            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}", DateTime.Now));
            */
            /*
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
            */
            /*
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
            */
            /*
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
            */
            /*
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
                CAN = CAN - (C100 * 100);
            }
            if ((CAN >= 50))
            {
                C50 = (CAN / 50);
                CAN = CAN - (C50 * 50);
            }
            if ((CAN >= 20))
            {
                C20 = (CAN / 20);
                CAN = CAN - (C20 * 20);
            }
            if ((CAN >= 10))
            {
                C10 = (CAN / 10);
                CAN = CAN - (C10 * 10);
            }
            if ((CAN >= 5))
            {
                C5 = (CAN / 5);
                CAN = CAN - (C5 * 5);
            }
            Console.WriteLine("BILLETES DE A 100: " + C100);
            Console.WriteLine("BILLETES DE A 50 : " + C50);
            Console.WriteLine("BILLETES DE A 20 : " + C20);
            Console.WriteLine("BILLETES DE A 10 : " + C10);
            Console.WriteLine("BILLETES DE A 5 : " + C5);
            Console.WriteLine("BILLETES DE A 1 : " + CAN);
            */
            /*
            double SUELDO, ARECIBIR;
            int NHIJO, BONO;
            string NOM, linea;
            Console.Write("NOMBRE EMPLEADO :"); NOM = Console.ReadLine();
            Console.Write("SUELDO EMPLEADO :"); linea = Console.ReadLine();
            SUELDO = double.Parse(linea);
            Console.Write("NÚMERO DE HIJOS :"); linea = Console.ReadLine();
            NHIJO = int.Parse(linea);
            if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }
            ARECIBIR = SUELDO + BONO;
            Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            */
            /*
            int NUM1, NUM2, NUM3;
            string linea;
            Console.Write("PRIMER NÚMERO :"); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("SEGUNDO NÚMERO :"); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.Write("TERCER NÚMERO :"); linea = Console.ReadLine();
            NUM3 = int.Parse(linea);
            Console.WriteLine();
            Console.Write("EL INTERMEDIO ES: ");
            if ((NUM1 > NUM2))
            {
                if ((NUM1 < NUM3))
                {
                    Console.WriteLine(NUM1);
                }
                else
                {
                    if ((NUM2 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM2);
                    }
                }
            }
            else
            {
                if ((NUM2 < NUM3))
                {
                    Console.WriteLine(NUM2);
                }
                else
                {
                    if ((NUM1 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM1);
                    }
                }
            }
            */
            /*
            int CANKV;
            double TOT, COSKV;
            COSKV = 0;
            string linea;
            Console.Write("Cantidad de Kilovatios :"); linea = Console.ReadLine();
            CANKV = int.Parse(linea);
            if ((CANKV <= 1000)) COSKV = 0.14;
            if (((CANKV > 1000) & (CANKV <= 1800))) COSKV = 0.12;
            if ((CANKV > 1800)) COSKV = 0.8;
            TOT = CANKV * COSKV;
            Console.WriteLine("A PAGAR: " + TOT);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            */
            /*
            int LADO1, LADO2, LADO3;
            string linea;
            Console.Write("DIGITE LADO 1 :"); linea = Console.ReadLine();
            LADO1 = int.Parse(linea);
            Console.Write("DIGITE LADO 2 :"); linea = Console.ReadLine();
            LADO2 = int.Parse(linea);
            Console.Write("DIGITE LADO 3 :"); linea = Console.ReadLine();
            LADO3 = int.Parse(linea);
            if ((LADO1 == LADO2) & (LADO2 == LADO3))
            {
                Console.WriteLine("TRIÁNGULO EQUILÁTERO. TODOS IGUALES");
            }
            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
                {
                    Console.WriteLine("TRIÁNGULO ESCALENO. NINGUNO IGUAL");
                }
                else
                {
                    Console.WriteLine("TRIÁNGULO ISÓSCELES. DOS IGUALES");
                }
            }
            */
            /*
            string NOMBRE;
            Console.Write("Ingrese su nombre : "); NOMBRE = Console.ReadLine();
            if (NOMBRE == "David")
            {
                Console.WriteLine();
                Console.WriteLine("HOLA");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO TE CONOZCO");
            }
            Console.WriteLine();
            */
            /*
            int num;
            string linea;
            Console.WriteLine();
            Console.WriteLine("DIAS DE LA SEMANA");
            Console.WriteLine();
            Console.Write("Ingrese un numero del 1 al 7 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            switch (num)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia DOMINGO");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia LUNES");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia MARTES");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia MIERCOLES");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia JUEVES");
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia VIERNES");
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia SABADO");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso esta fuera de rango");
                    break;
            }
            */
            /*
            char ECIVIL;
            string linea;
            Console.Write("DIGITE C,S,V,D :"); linea = Console.ReadLine();
            ECIVIL = char.Parse(linea);
            switch (ECIVIL)
            {
                case 'C':
                    ; Console.WriteLine("CASADO");
                    break;
                case 'S':
                    ; Console.WriteLine("SOLTERO");         
                    break;
                case 'V':
                    ; Console.WriteLine("VIUDO");
                    break;
                case 'D':
                    ; Console.WriteLine("DIVORCIADO");
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }
            */
            /*
            int NOTA;
            string linea;
            Console.Write("DIGITE CALIFICACIÓN:"); linea = Console.ReadLine();
            NOTA = byte.Parse(linea);
            switch (NOTA)
            {
                case 19:
                case 20:
                    ; Console.WriteLine("SOBRESALIENTE");
                    break;
                case 16:
                case 17:
                case 18:
                    ; Console.WriteLine("MUY BUENA");
                    break;
                case 14:
                case 15:
                    ; Console.WriteLine("BUENA");
                    break;
                case 12:
                case 13:
                    ; Console.WriteLine("REGULAR");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("INSUFICIENTE");
                    break;
                default:
                    Console.WriteLine("FUERA DE RANGO");
                    break;
            }
            */
            /*
            char TECLA;
            string linea;
            Console.Write("DIGITE UNA SOLA TECLA");
            Console.WriteLine();
            linea = Console.ReadLine();
            TECLA = char.Parse(linea);
            switch (TECLA)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ; Console.WriteLine("ES UNA CIFRA NUMERICA");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ; Console.WriteLine("ES UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("ES UNA CONSONANTE");
                    break;
            }
            */
            /*
            byte NUM, I;
            int RESUL;
            string linea;
            Console.Write("DIGITE NÚMERO:"); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (I = 1; I <= 12; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
            }
            */
            /*
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
            */
            /*
            byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;
            string linea;
            Console.Write("NÚMERO MÁXIMO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (I = 1; I <= NUM; I += 2)
            {
                SUMP = SUMP + I;
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI = SUMI + I;
            }
            Console.WriteLine("TOTAL EN PARES : " + SUMP);
            Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
            */
            /*
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
            */
            /*
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
            */
            /*
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
             */
            /*
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
            Console.WriteLine();
            */

            /*
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
            */

            /*
            byte CAN, K;
            int NUM;
            string linea;
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            //INICIALIZA EL GENERADOR DE ALEATORIOS
            Random ran = new Random();
            for (K = 1; K <= CAN; K++)
            {
                NUM = Convert.ToInt32(ran.Next(100));
                Console.WriteLine("GENERÓ EL: " + NUM);
                if (((NUM > 0) & (NUM < 256)))
                {
                    Console.WriteLine("EL CÓDIGO DEL " + NUM + " ES " + Convert.ToString((char)NUM));
                }
            }
            */

            /*
            string NOM;
            byte K;
            Console.Write("DIGITE SU NOMBRE : "); NOM = Console.ReadLine();
            Console.WriteLine("LONGITUD : " + NOM.Length);
            Console.WriteLine("ESTA DENTRO : " + NOM.Contains("ARIEL"));
            Console.WriteLine("REEMPLAZO VOCAL A: " + NOM.Replace("A", "X"));
            Console.WriteLine("EN MINUSCULAS : " + NOM.ToLower());
            Console.WriteLine("EN MAYÚSCULAS : " + NOM.ToUpper());
            Console.WriteLine("REMOVER 4 LETRAS : " + NOM.Remove(3, 4));
            Console.WriteLine("EXTRAER 4 LETRAS : " + NOM.Substring(3, 4));
            Console.WriteLine("IZQUIERDA 4 LETRAS : " + Left(NOM, 4));
            Console.WriteLine("DERECHA 4 LETRAS : " + Right(NOM, 4));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("DESDE LA IZQUIERDA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Left(NOM, K));
            }
            Console.WriteLine();
            Console.WriteLine("DESDE LA DERECHA");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Right(NOM, K));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }*/

            /*
            byte H, M, S;
            Console.SetCursorPosition(15, 2);
            Console.Write("SIMULACIÓN DE UN RELOJ DIGITAL");
            for (H = 0; H <= 24; H++)
            {
                for (M = 0; M <= 59; M++)
                {
                    for (S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.Write("{0} : {1} : {2}", H, M, S);
                    }
                }
            }
            Console.SetCursorPosition(25, 15);*/

            /*
             string NOM;
             int K, SUM;
             string LE;
             Console.Write("DIGITE UNA FRASE : "); NOM = Console.ReadLine();
             SUM = 0;
             NOM = NOM.ToUpper();
             Console.Write(NOM);
             for (K = 1; K < NOM.Length; K++)
             {
                 LE = Mid(NOM, K, 1);
                 if (LE.Contains("U") || LE.Contains("I"))
                 {
                     SUM = SUM + 1;
                 }
             }
             Console.WriteLine("EXISTEN {0} VOCALES CERRADAS", SUM);
             Console.Write("Pulse una Tecla:"); Console.ReadLine();
         }
         public static string Mid(string param, int startIndex, int length)
         {
             string result = param.Substring(startIndex, length);
             return result;
             47
         Ing.Patricio Medina
         }
         public static string Mid(string param, int startIndex)
         {
             string result = param.Substring(startIndex);
             return result;
         }*/
            /*
            public static string Mid(string param, int startIndex, int length)
            {
                string result = param.Substring(startIndex, length);
                return result;
            }
            static void Main(string[] args)
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
                    LE = Mid(NOM, K, 1);
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
                Console.WriteLine("EXISTEN {0} VOCALES U", U);*/

            /*byte NUM, K;
            long RESUL = 1;
            string linea;
            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 2; K <= NUM; K++)
            {
                RESUL = RESUL * K;
            }
            Console.WriteLine("EL FACTORIAL ES: " + RESUL);
            */

            /*byte NUM, K, F;
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
                    FAC = FAC * F;
                }
                RESUL = RESUL + (K / FAC);
            }
            Console.WriteLine("RESULTADO DE LA SERIE ES: " + RESUL);*/

            /*int CAN, F, C, T, FI, FF, CI, CF;
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
            Console.SetCursorPosition(25, 24);
            */

            /*string NOM;
            byte K;
            Console.Write("SU NOMBRE ES: "); NOM = Console.ReadLine();
            for (K = 1; K <= 70; K++)
            {
                Console.SetCursorPosition(K, 12);
                Console.Write(" " + NOM);
                //REALIZAMOS UNA PAUSA;
                System.Threading.Thread.Sleep(100);
            }*/

            /*public static string Mid(string param, int startIndex, int length)
            {
                string result = param.Substring(startIndex, length);
                return result;
            }
            static void Main(string[] args)
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
                    CAR = Mid(NOM, P - 1, 1);
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
                Console.WriteLine();*/

            /*public static string Mid(string param, int startIndex, int length)
            {
                string result = param.Substring(startIndex, length);
                return result;
            }
            static void Main(string[] args)
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
                    CAR = Mid(NOM, P - 1, 1);
                    for (K = 1; K <= 22; K++)
                        58
                Ing.Patricio Medina
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
                Console.WriteLine();*/

            /*int i;
            Console.Write("ABECEDARIO DESCENDENTE");
            Console.WriteLine();
            for (i = 90; i >= 65; i--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((char)i));
            }*/

            /*int NUM, I, RESUL;
            string linea;
            Console.Write("DIGITE NÚMERO:"); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
                I = I + 1;
            }*/

            /*int NUM, RESUL, T, I;
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
            }*/
            //pag62








            Console.WriteLine("pulse una tecla:");Console.ReadKey();
        }
    }
}
