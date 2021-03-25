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
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;
            string laTecla;

            do
            {
                Console.WriteLine("Presiona cualquier tecla.\nPara salir presiona CTRL + F");
                tecla = Console.ReadKey();
                laTecla = tecla.Key.ToString();
                Console.Write(" --- Presionaste las teclas: ");
                if ((tecla.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT + ");
                if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT + ");
                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL + ");
                Console.WriteLine(tecla.Key.ToString());

            } while (tecla.Modifiers != ConsoleModifiers.Control || laTecla != "F");


        }
    }
}

