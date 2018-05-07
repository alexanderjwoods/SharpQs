using System;

namespace ConwaysGameOfLife_Finished
{
    public class Grid
    {
        private char[,] _grid;
        private int _gridLength;
        private char _alive;
        private char _dead;

        public int AliveCells;
        public int Year;

        private Grid() { }

        public Grid(int size, char alive)
        {
            _gridLength = size;
            Year = 0;
            _alive = alive;
            _dead = ' ';

            _grid = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    _grid[i, j] = _dead;
                }
            }
        }

        public void AdvanceGrid()
        {
            for (int i = 0; i < _gridLength; i++)
            {
                for (int j = 0; j < _gridLength; j++)
                {
                    int aliveNeighbors = CheckAliveNeighbors(i, j);

                    if (_grid[i, j] == _alive)
                    {
                        if (aliveNeighbors < 2)
                            FlipCell(i, j);


                        if (aliveNeighbors > 3)
                            FlipCell(i, j);
                    }
                    else
                    {
                        if (aliveNeighbors == 3)
                            FlipCell(i, j);
                    }
                }
            }

            int CheckAliveNeighbors(int row, int col)
            {
                int aliveNeighbors = 0;

                if (row != 0) //Check top
                {
                    if (_grid[row - 1, col] == _alive)
                    {
                        aliveNeighbors++;
                    }

                    if (col != 0) //Check top left
                    {
                        if (_grid[row - 1, col - 1] == _alive)
                        {
                            aliveNeighbors++;
                        }
                    }

                    if (col != _gridLength - 1) //Check top right
                    {
                        if (_grid[row - 1, col + 1] == _alive)
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (col != 0) //Check left
                {
                    if (_grid[row, col - 1] == _alive)
                    {
                        aliveNeighbors++;
                    }
                }

                if (col != _gridLength - 1) //Check right
                {
                    if (_grid[row, col + 1] == _alive)
                    {
                        aliveNeighbors++;
                    }
                }

                if (row != _gridLength - 1) //Check bottom
                {
                    if (_grid[row + 1, col] == _alive)
                    {
                        aliveNeighbors++;
                    }

                    if (col != 0) //Check bottom left
                    {
                        if (_grid[row + 1, col - 1] == _alive)
                        {
                            aliveNeighbors++;
                        }
                    }

                    if (col != _gridLength - 1) //Check bottom right
                    {
                        if (_grid[row + 1, col + 1] == _alive)
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                return aliveNeighbors;
            }

            Year++;
        }

        public void FlipCell(int row, int column)
        {
            if (_grid[row, column] == _dead)
            {
                _grid[row, column] = _alive;
                AliveCells++;
            }
            else
            {
                _grid[row, column] = _dead;
                AliveCells--;
            }
        }

        public void PrintGrid()
        {
            Console.WriteLine();
            Console.WriteLine($"Grid at year {Year}");
            Console.WriteLine();
            for (int i = 0; i < _gridLength; i++)
            {
                for (int j = 0; j < _gridLength; j++)
                {
                    Console.Write(_grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        public bool CellIsAlive(int row, int col)
        {
            return _grid[row, col] == _alive;
        }
    }
}