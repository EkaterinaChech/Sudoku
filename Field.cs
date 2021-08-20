using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Field
    {
        private int size;
        private int[,] field;

        public Field()
        {
            size = Properties.size;
            field = new int[size, size];
            FillBasisField();
        }

        public void FillBasisField()
        {
            int[] firstNums = {1, 4, 7, 2, 5, 8, 3, 6, 9};
            for (int i = 0; i < size; i++)
            {
                FillRow(i, firstNums[i]);
            }
        }

        public void FillRow(int row, int firstNumber)
        {
            int step = firstNumber;

            for (int i = 0; i < size; i++, step++)
            {
                if (step > 9)
                    step = 1;
                field[row, i] = step;
            }
        }

        public int[] GetRow(int row)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = field[row, i];
            }

            return result;
        }

        public void Transpose()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    int temp = field[i, j];
                    field[i, j] = field[j, i];
                    field[j, i] = temp;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - -");
            for (int i = 0; i < size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < size; j++)
                {
                    if ((j + 1) % 3 == 0)
                    {
                        Console.Write($" {field[i, j]} |");
                    }
                    else
                    {
                        Console.Write($" {field[i, j]} ");
                    }
                }

                Console.WriteLine();
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine("- - - - - - - - - - - - - - - -");
                }
            }
        }

        public int GetBlockNumberVertical(int num)
        {
            int blockVertical;
            if (num < Properties.blockSize)
                blockVertical = 1;
            else if (num < 2 * Properties.blockSize)
                blockVertical = 2;
            else
                blockVertical = 3;
            return blockVertical;
        }

        public int GetBlockNumberHorizontal(int num)
        {
            int blockHorizontal;
            if (num < Properties.blockSize)
                blockHorizontal = 1;
            else if (num < 2 * Properties.blockSize)
                blockHorizontal = 2;
            else
                blockHorizontal = 3;
            return blockHorizontal;
        }

        public bool SwapRows(int row1, int row2)
        {
            int block1 = GetBlockNumberVertical(row1), block2 = GetBlockNumberVertical(row2);
            if (block1 != block2)
                return false;
            for (int i = 0; i < size; i++)
            {
                int temp = field[row1, i];
                field[row1, i] = field[row2, i];
                field[row2, i] = temp;
            }

            return true;
        }

        public bool SwapCols(int col1, int col2)
        {
            int block1 = GetBlockNumberHorizontal(col1), block2 = GetBlockNumberHorizontal(col2);
            if (block1 != block2)
                return false;
            for (int i = 0; i < size; i++)
            {
                int temp = field[i, col1];
                field[i, col1] = field[i, col2];
                field[i, col2] = temp;
            }

            return true;
        }

        private void SwapRowsInternal(int row1, int row2)
        {
            for (int i = 0; i < size; i++)
            {
                int temp = field[row1, i];
                field[row1, i] = field[row2, i];
                field[row2, i] = temp;
            }
        }

        private void SwapColsInternal(int col1, int col2)
        {
            for (int i = 0; i < size; i++)
            {
                int temp = field[i, col1];
                field[i, col1] = field[i, col2];
                field[i, col2] = temp;
            }
        }

        public bool SwapBlocksVertical(int block1, int block2)
        {
            if (block1 == block2)
                return false;
            int leftBlock = Math.Min(block1, block2);
            int rightBlock = Math.Max(block1, block2);
            if (leftBlock == 1)
            {
                if (rightBlock == 2)
                {
                    for (int i = 0; i < Properties.blockSize; i++)
                    {
                        SwapColsInternal(i, i + 3);
                    }
                }
                else if (rightBlock == 3)
                {
                    for (int i = 0; i < Properties.blockSize; i++)
                    {
                        SwapColsInternal(i, i + 6);
                    }
                }
            }
            else if (leftBlock == 2 && rightBlock == 3)
            {
                for (int i = 3; i < 3 + Properties.blockSize; i++)
                {
                    SwapColsInternal(i, i + 3);
                }
            }

            return true;
        }

        public bool SwapBlocksHorizontal(int block1, int block2)
        {
            if (block1 == block2)
                return false;
            int upBlock = Math.Min(block1, block2);
            int downBlock = Math.Max(block1, block2);
            if (upBlock == 1)
            {
                if (downBlock == 2)
                {
                    for (int i = 0; i < Properties.blockSize; i++)
                    {
                        SwapRowsInternal(i, i + 3);
                    }
                }
                else if (downBlock == 3)
                {
                    for (int i = 0; i < Properties.blockSize; i++)
                    {
                        SwapRowsInternal(i, i + 6);
                    }
                }
            }
            else if (upBlock == 2 && downBlock == 3)
            {
                for (int i = 3; i < 3 + Properties.blockSize; i++)
                {
                    SwapRowsInternal(i, i + 3);
                }
            }

            return true;
        }

        public void ApplyRandomChanges(int changesCount)
        {
            Random rand = new Random();
            for (int i = 0; i < changesCount; i++)
            {
                switch (rand.Next(1, 6))
                {
                    case 1:
                        //Console.WriteLine("Applying transposing.");
                        Transpose();
                        break;
                    case 2:
                        //Console.WriteLine("Applying swapping random rows.");
                        bool flagRows = false;
                        while (!flagRows)
                        {
                            int s1, s2;
                            s1 = rand.Next(0, 9);
                            while ((s2 = rand.Next(0, 9)) == s1)
                                s2 = rand.Next(0, 9);
                            flagRows = SwapRows(s1, s2);
                        }
                        break;
                    case 3:
                        //Console.WriteLine("Applying swapping random cols.");
                        bool flagCols = false;
                        while (!flagCols)
                        {
                            int s1, s2;
                            s1 = rand.Next(0, 9);
                            while ((s2 = rand.Next(0, 9)) == s1)
                                s2 = rand.Next(0, 9);
                            flagCols = SwapCols(s1, s2);
                        }
                        break;
                    case 4:
                        //Console.WriteLine("Applying swapping random blocks vertically.");
                        bool flagVerticalBlocks = false;
                        while (!flagVerticalBlocks)
                        {
                            int s1, s2;
                            s1 = rand.Next(0, 3);
                            while ((s2 = rand.Next(0, 3)) == s1)
                                s2 = rand.Next(0, 3);
                            flagVerticalBlocks = SwapBlocksVertical(s1, s2);
                        }
                        break;
                    case 5:
                        //Console.WriteLine("Applying swapping random blocks horizontally.");
                        bool flagHorizontalBlocks = false;
                        while (!flagHorizontalBlocks)
                        {
                            int s1, s2;
                            s1 = rand.Next(0, 3);
                            while ((s2 = rand.Next(0, 3)) == s1)
                                s2 = rand.Next(0, 3);
                            flagHorizontalBlocks = SwapBlocksHorizontal(s1, s2);
                        }
                        break;
                }
            }
        }

        public int[] GetBlock(int block)
        {
            
        }
    }
}