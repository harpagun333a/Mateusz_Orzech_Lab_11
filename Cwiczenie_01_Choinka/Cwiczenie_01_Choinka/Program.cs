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
        public void rysuj()
        {
            //Console.Clear();
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                //Console.Clear();
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

                //System.Threading.Thread.Sleep(500);
                //Console.Clear();
                //for (int i = 0; i <= branches; i++)
                //{
                //    for (int j = i; j < branches; j++)
                //    {
                //        Console.Write(' ');
                //    }
                //    for (int j = i * 2 - 1; j > 0; j--)
                //    {
                //        Console.Write('^');
                //    }
                //    Console.WriteLine();
                //}
            }
        }
    }
}
