using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Config
    {
        public Config()
        {
            this.Titulo();
            //this.Colores();
            //this.Pantalla;
        }
        public void Titulo()
        {
            Console.Title = "Ejercicios de programacion en consola de C#";
        }
        /*public void Colores()
        {
            Modificar colores pantalla
        }*/
        /*public void Pantalla()
        {
            Modifica tamaño pantalla
        }*/
    }
}
