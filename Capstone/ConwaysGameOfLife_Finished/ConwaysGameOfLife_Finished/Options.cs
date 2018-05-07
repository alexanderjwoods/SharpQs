using System;

namespace ConwaysGameOfLife_Finished
{
    public class Options
    {
        public int YearsToRun;

        private Options() { }

        public Options(out Grid grid)
        {
            int gridSize;
            char aliveChar;

            Console.WriteLine("Options");
            Console.WriteLine("_______");
            GetYearsToRun();
            ChoosegridSize();
            ChooseAliveChar();

            grid = new Grid(gridSize, aliveChar);

            Console.WriteLine("Randomize Grid? (y/n): ");
            char response = Console.ReadLine()[0];
            if(response == 'y' || response == 'Y')
            {
                for(double i = 0; i < ((gridSize * gridSize) * .66);)
                {
                    Random rnd = new Random();
                    int row = rnd.Next(0, gridSize - 1);
                    int col = rnd.Next(0, gridSize - 1);

                    if (!grid.CellIsAlive(row, col))
                    {
                        grid.FlipCell(row, col);
                        i++;
                    }
                }

                grid.PrintGrid();
            }
            else
            {
                for (;;)
                {
                    int row;
                    int column;
                    for (;;)
                    {
                        Console.WriteLine($"Choose Row (1-{gridSize}): ");
                        Int32.TryParse(Console.ReadLine(), out row);
                        if (row >= 0 || row <= gridSize)
                        {
                            row--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid Selection {row}.  Select again.");
                            Console.WriteLine();
                        }
                    }
                    for (;;)
                    {
                        Console.WriteLine($"Choose Column (1-{gridSize}): ");
                        Int32.TryParse(Console.ReadLine(), out column);
                        if (column >= 0 || column <= gridSize)
                        {
                            column--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid Selection {column}.  Select again.");
                            Console.WriteLine();
                        }
                    }

                    grid.FlipCell(row, column);
                    grid.PrintGrid();

                    Console.WriteLine("Flip another cell? (y/n)");
                    char flipAnother = Console.ReadLine()[0];
                    if (flipAnother == 'n' || flipAnother == 'N')
                        break;
                }
            }


            void GetYearsToRun()
            {
                YearsToRun = -1;
                do
                {
                    Console.Write("Years to run simulation: ");
                    Int32.TryParse(Console.ReadLine(), out YearsToRun);
                } while (YearsToRun == -1);
            }
            
            void ChoosegridSize()
            {
                gridSize = -1;
                do
                {
                    Console.Write("Choose Grid Size: ");
                    Int32.TryParse(Console.ReadLine(), out gridSize);
                } while (gridSize == -1);
            }

            void ChooseAliveChar()
            {
                Console.Write("Choose Alive Character: ");
                aliveChar = Console.ReadLine()[0];
            }
        }
    }
}