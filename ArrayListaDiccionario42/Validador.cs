using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario42
{
    public class Validador
    {
        public static string PedirString(string mensaje)
        {
            string valor;
            bool valido = false;
            string mensajeError = "\n El valor no puede ser vacio y tiene que estar dentro del rango solicitado. ";

            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();

                if (valor == "")
                {
                    Console.Clear();
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);
            return valor;

        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

    }
}
