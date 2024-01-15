namespace Strings
{

    class Program
    {

        public static void Main(string[] args)
        {
            //Añadir espacio al principio y al final (Método de concatenación)
            string frase1 = ("Hola soy Carlos");
            string final1 = string.Concat(" " + frase1 + " ");
            Console.WriteLine(final1);


            //Quitar espacios

            string frase = (" Hola soy Carlos ");
            string final = string.Concat(frase);
            Console.WriteLine(final);

            //Quitar el espacio de la derecha

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quita el espacio de la izquierda ");
            string esp1 = (" Hola soy Carlos ");
            string espaciosIzquierda = esp1.TrimStart();
            Console.WriteLine(espaciosIzquierda.TrimStart());

            //Quitar el espacio a la izquierda

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quita el espacio de la derecha ");
            string esp2 = (" Hola soy Carlos ");
            string espaciosDerecha = esp2.TrimEnd();
            Console.WriteLine(espaciosDerecha.TrimEnd());

            //Quitar los espacios de ambos lados

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quita el espacio de ambos lados");
            string esp3 = (" Hola soy Carlos ");
            string sinEspacios = esp3.Trim();
            Console.WriteLine(sinEspacios.Trim());

            //Dividir el texto usando ","
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dividir usando , ");
            string nom = ("Haro Infante,Carlos");

            string[] subs = nom.Split(",");

            foreach(string sub in subs)
            {
                Console.WriteLine(sub);
            }

            //Contar nº de aes que hay
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Contar aes en la frase");
            string nom1 = ("Haro Infante,Carlos");
            char c = 'a';

            int numA = nom1.Count(f => (f == c));
            Console.WriteLine("Hay" + numA + "en el texto");

        }


    }



}
