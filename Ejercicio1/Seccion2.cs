using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Seccion2
    {
        public static void Ejecutar()
        {
            String[] opciones =
           {
            "Bono del empleado por hijo",
            "Numero intermedio",
            "Tarifa telefonica",
            "Triangulos",
            "Ejercicio propuesto(2)",
            "Dia de la semana",
            "Estado civil",
            "Calificacion",
            "Ejercicio propuesto(3)",
            "Tabla de multiplicar",
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
                            Seccion2.Bono();
                            break;
                        case 2:
                            Seccion2.MidN();
                            break;
                        case 3:
                            Seccion2.TarifaT();
                            break;
                        case 4:
                            Seccion2.Triangulos();
                            break;
                        case 5:
                            Seccion2.EjP2();
                            break;
                        case 6:
                            Seccion2.DotW();
                            break;
                        case 7:
                            Seccion2.EstadoCivil();
                            break;
                        case 8:
                            Seccion2.Calificacion();
                            break;
                        case 9:
                            Seccion2.EjP3();
                            break;
                        case 10:
                            Seccion2.TMul();
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
        static void Bono()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void MidN()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void TarifaT()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void Triangulos()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void EjP2()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void DotW()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void EstadoCivil()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void Calificacion()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void EjP3()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        static void TMul()
        {
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
            Console.WriteLine("pulse una tecla:"); Console.ReadKey(); Console.Clear();
        }
        
    }
}
