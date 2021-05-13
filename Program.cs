using System;

namespace AppConsolaTelefonoMovil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo los vectores correspondientes al abecedario y a la secuencia de teclas correspondientes a cada letra
            char[] abc = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
            int[] teclado = new int[] {2, 22, 222, 3, 33, 333, 4, 44, 444, 5, 55, 555, 6, 66, 666, 7, 77, 777, 7777, 8, 88, 888, 9, 99, 999, 9999, 0 };

            //Bienvenida al programa
            Console.WriteLine("TE DAMOS LA BIENVENIDA AL PROGRAMA");
            Console.WriteLine("Siga las instrucciones para traducir un mensaje");
            Console.WriteLine("");

            bool flag = true;
            while (flag)
            {
                Console.Write("Para escribir un mensaje presione la tecla 1: ");
                string iniciar = Console.ReadLine();
                Console.WriteLine("");
                string mje = null;

                    // Inicia el programa
                    if (iniciar == "1")
                    {
                        // Ingresa el mensaje
                        Console.WriteLine("Ingrese el mensaje: ");
                        mje = Console.ReadLine();
                        Console.WriteLine("");

                        // Funcion que indica la secuencia de teclas para escribir el mensaje indicado
                        Console.WriteLine("La secuencia de teclas que debes presionar para escribir el mensaje es: ");
                        char numSecAnterior = '1';
                        for (int i = 0; i < mje.Length; i++)
                        {
                            char letra = mje[i];
                            bool k = true;
                            int j = 0;

                            while (k)
                            {
                                if (letra == abc[j])
                                {
                                    k = false;
                                    int secActual = teclado[j];
                                    char numSecActual = ((secActual.ToString())[0]);

                                    if ( numSecActual == numSecAnterior ) 
                                    {
                                        Console.Write(" " + teclado[j]);
                                    } 
                                    else 
                                    {
                                        Console.Write(teclado[j]);
                                    }
                                    numSecAnterior = numSecActual;
                                }
                                j++;
                            }
                        }

                    }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Para CERRAR el programa presione la tecla 0,");
                Console.WriteLine("para CONTINUAR en el programa presione cualquier otra tecla: ");
                // Permite descubrir la secuencia de varios mensajes antes de salir del programa,
                // O salir del programa si así se quiere.
                string salir = Console.ReadLine();
                Console.WriteLine("");
                if (salir == "0")
                {
                    flag = false;
                }
            }
        }
    }
}
