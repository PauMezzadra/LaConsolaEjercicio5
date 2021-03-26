using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio5
{
    class Program
    {
        public static void Main()
        {
            ConsoleKeyInfo tecla;
            Console.TreatControlCAsInput = true;
            do
            {
                Console.WriteLine("Ingrese CTRL + F para salir");
                tecla = Console.ReadKey();

                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0
                        && (tecla.Modifiers & ConsoleModifiers.Shift) == 0
                            && tecla.Key == ConsoleKey.F
                                && (tecla.Modifiers & ConsoleModifiers.Alt) == 0)
                {
                    break;
                }

            } while (true);
        }
    }
}

