using System;

namespace ConwaysGameOfLife_Finished
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conway's Game of Life By Alexander J. Woods");
            Console.WriteLine();
            Console.WriteLine();
            for(;;)
            {
                Options options = new Options(out Grid playGrid);
                
                while(playGrid.Year < options.YearsToRun && playGrid.AliveCells > 0)
                {
                    Console.Clear();
                    playGrid.AdvanceGrid();
                    playGrid.PrintGrid();
                    System.Threading.Thread.Sleep(500);
                }

                Console.WriteLine("Play Again? (y/n): ");
                char response = Console.ReadLine()[0];

                if (response == 'n' || response == 'N')
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
            Console.Read();
        }
    }
}