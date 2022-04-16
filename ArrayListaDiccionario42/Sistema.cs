using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario42
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            string frase = Validador.PedirString("\n Ingrese una frase");

            char[] caracter = frase.ToCharArray();

            Array.Reverse(caracter);
            Console.Clear();
            Console.WriteLine("\n Usted ingreso la frase : *" + frase + "*.");
            Console.WriteLine("\n La frase escrita al revés es: \n");
            foreach (char c in caracter)
            {
                Console.Write(c);
            }

            Console.WriteLine("\n ");
            Validador.Despedida();

        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
