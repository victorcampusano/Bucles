using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostra la tabla de Multiplicar\n" +
                "Digite el numero X para mostrar su tabla de multiplicar\n");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el limite de la tabla\n");
            int n = int.Parse(Console.ReadLine());

            Varios v = new Varios();

            v.tablaMultiplicar(a, n);


            // Console.WriteLine("Menu de Opciones para Programa");
            //mostrarMenu();
            //menuConWhile(); 



            Console.ReadKey();
        }

        public static void menuConDoWhile() {
            int op = 0;
            do
            {
                mostrarMenu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Haz llamado la opcion 1 del menu");
                        break;
                    case 2:
                        Console.WriteLine("Haz llamado la opcion 2 del menu");
                        break;
                    case 3:
                        Console.WriteLine(suma(5, 5.3f));
                        break;
                    default:
                        break;
                }

            } while (op != 0);
        }

        public static void menuConWhile()
        {
            int op = 0;
            op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                switch (op)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Haz llamado la opcion 1 del menu");
                        break;
                    case 2:
                        Console.WriteLine("Haz llamado la opcion 2 del menu");
                        break;
                    case 3:
                        Console.WriteLine(suma(5, 5.3f));
                        break;
                    default:
                        break;
                }
                mostrarMenu();
                op = int.Parse(Console.ReadLine());

            }
        }

        public static void mostrarMenu()
        {
            Console.WriteLine("------------------------------------------------\n" +
                "1. Calculo de Salario\n" +
                "2. Calculo de Descuento\n" +
                "3. Suma\n" +
                "0. Salir\n" +
                "Digite una opcion y presione Enter\n");
        }

        public static float suma(float v1, float v2)
        {
            return v1 + v2;
        }
    }
}
