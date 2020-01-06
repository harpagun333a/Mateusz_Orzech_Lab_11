using System;

namespace Cwiczenie_01_Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHOINKA! :D");

            ChristmasTree choinka = new ChristmasTree();
            choinka.rysuj();
        }
    }

    class ChristmasTree
    {
        int branches = 15;
        Random rnd = new Random();
        int rand;
        int line = 0;
        int counter = 0;
 
        public void rysuj()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i <= branches; i++)
                {
                    for (int j = i; j < branches; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = i * 2 - 1; j > 0; j--)
                    {
                        rand = rnd.Next(0, 100);
                        if (rand<10)
                            Console.Write('o');
                        else if (rand < 20)
                            Console.Write('~');
                        else if (rand < 30)
                            Console.Write('+');
                        else if (rand < 40)
                            Console.Write('^');
                        else if (rand < 50)
                            Console.Write('"');
                        else
                            Console.Write('*');
                    }
                    for (int j = i; j < branches; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < branches - 3; i++)
                {
                    Console.Write(' ');
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write('|');
                }
                Console.WriteLine();

                counter++;
                if (counter == 3)
                {
                    counter = 0;
                    line++;
                    if (line == text.Length)
                    {
                        line = 0;
                    }
                }

                Console.SetCursorPosition(29, 11);
                Console.Write("                                          ");
                Console.SetCursorPosition(29, 11);
                for (int i = 0; i < text[line].Length+2; i++)
                {
                    Console.Write('_');
                }
                Console.SetCursorPosition(28, 12);
                Console.Write("                                          ");
                Console.SetCursorPosition(28, 12);
                Console.Write("< " + text[line] + " >");
                Console.SetCursorPosition(29, 13);
                Console.Write("                                          ");
                Console.SetCursorPosition(29, 13);
                for (int i = 0; i < text[line].Length+2; i++)
                {
                    Console.Write('-');
                }
                Console.SetCursorPosition(33, 14);
                Console.Write("\\   ^__ ^");
                Console.SetCursorPosition(33, 15);
                Console.Write(" \\  (oo)\\_______");
                Console.SetCursorPosition(33, 16);
                Console.Write("    (__)\\       )\\/\\");
                Console.SetCursorPosition(33, 17);
                Console.Write("        || ----w |");
                Console.SetCursorPosition(33, 18);
                Console.Write("        ||     ||");

            }
        }

        string[] text =
        {
            "...",
            "Dzisiaj w Betlejem, Dzisiaj w Betlejem",
            "Wesoła Nowina!",
            "Że Panna czysta, że Panna czysta",
            "Porodziła Syna.",
            "Chrystus się rodzi,",
            "Nas oswobodzi,",
            "Anieli grają,",
            "Króle witają,",
            "Pasterze śpiewają,",
            "Bydlęta klękają,",
            "Cuda, cuda ogłaszają!",
            "..."
        };
    }

}
