using System;

namespace EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("\n Digite el número de la opción deseada:\n");
            Console.WriteLine("1. Validar signo de un número digitado");
            Console.WriteLine("2. Ejecutar Bucle While");
            Console.WriteLine("3. Ejecutar Bucle Do While");
            Console.WriteLine("4. Ejecutar Bucle For");
            Console.WriteLine("5. Ejecutar Switch Estaciones");
            Console.WriteLine("6. Salir");
            string opcion = Console.ReadLine();
            Seleccionar(opcion);
        }

        private static void Seleccionar(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    ValidarNumero();
                    break;

                case "2":
                    BucleWhile();
                    break;

                case "3":
                    BucleDoWhile();
                    break;

                case "4":
                    BucleFor();
                    break;

                case "5":
                    SwitchEstaciones();
                    break;

                case "6":
                    Salir();
                    break;

                default:
                    break;
            }

            MenuPrincipal();
        }


        private static void ValidarNumero()
        {
            Console.WriteLine("\n Digite el número que desea validar");
            int numeroIf = Convert.ToInt32(Console.ReadLine());

            if (numeroIf > 0)
            {
                Console.WriteLine("\n El número {0} es Positivo", numeroIf);
            }
            else if (numeroIf < 0)
            {
                Console.WriteLine("\n El número {0} es Negativo", numeroIf);
            }
            else
            {
                Console.WriteLine("\n El número es 0");
            }
        }

        private static void BucleWhile()
        {
            int numeroWhile = 0;
            Console.WriteLine("\n El Resultado del Bucle While es:");

            while (numeroWhile < 3)
            {
                numeroWhile++;
                Console.WriteLine(numeroWhile);
            }
        }

        private static void BucleDoWhile()
        {
            int numeroWhile = 0;
            Console.WriteLine("\n El Resultado del Bucle Do While es:");

            do
            {
                numeroWhile++;
                Console.WriteLine(numeroWhile);
            } while (numeroWhile == 0);
        }

        private static void BucleFor()
        {
            Console.WriteLine("\n El Resultado del Bucle For es:");

            for (int numeroFor = 0; numeroFor <= 3; numeroFor++)
            {
                Console.WriteLine(numeroFor);
            }
        }

        private static void SwitchEstaciones()
        {
            Console.WriteLine("\n Digite una estación:");
            string estacion = Console.ReadLine().ToUpper();

            switch (estacion)
            {
                case "OTOÑO":
                    Console.WriteLine("\n Estamos en Otoño");
                    break;

                case "INVIERNO":
                    Console.WriteLine("\n Estamos en Invierno");
                    break;

                case "PRIMAVERA":
                    Console.WriteLine("\n Estamos en Primavera");
                    break;

                case "VERANO":
                    Console.WriteLine("\n Estamos en Verano");
                    break;

                default:
                    Console.WriteLine("\n No es una estación valida", estacion);
                    break;
            }
        }

        private static void Salir()
        {
            Environment.Exit(0);
        }
    }
}
