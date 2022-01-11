using System;
using System.Collections.Generic;

namespace MatrixIslandRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            //construct an array of arrays
            int[][] A = new int[][]
            {
                new int[] { 1, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 1, 1, 1 },
                new int[] { 0, 0, 1, 0, 1, 0 },
                new int[] { 1, 1, 0, 0, 1, 0 },
                new int[] { 1, 0, 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 0, 0, 1 }
            };

            //number of rows and columns that make up the array of arrays "A".
            int rows = A.Length;
            int columns = A[0].Length;

            //display each element of array of arrays to console to show original, unmutated matrix
            for (int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");

            //call method to remove islands
            RemoveIslands(A);

            //display each element of mutated array of arrays to console
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
        }

        public static int[][] RemoveIslands(int[][] A)
        {
            //determine size of array and interior array
            int rows = A.Length;
            int columns = A[0].Length;

            //instantiate an instance of the stack object
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

            //change all perimeter 1's to 2's
            //cycle through all rows in the matrix
            for (int i = 0; i < rows; i++)
            {
                //cycle through all columns in the matrix
                for (int j = 0; j < columns; j++)
                {
                    //check if a perimeter element equals 1
                    if ((A[i][j] == 1 && i == 0) ||
                        (A[i][j] == 1 && i == rows - 1) ||
                        (A[i][j] == 1 && j == 0) ||
                        (A[i][j] == 1 && j == columns - 1))
                    {
                        //add matching element to stack
                        stack.Push(new Tuple<int, int>(i, j));

                        //add 1's that can be traced to 1's on the perimter to a stack
                        //pop these matches off the stack and turn them into 2's
                        while (stack.Count > 0)
                        {
                            var currentPosition = stack.Pop();

                            int row = currentPosition.Item1;
                            int col = currentPosition.Item2;

                            //turn all 1's to 2's
                            A[row][col] = 2;

                            //check from the top
                            if (row > 0 && A[row-1][col] == 1)
                            {
                                stack.Push(new Tuple<int, int>(row - 1, col));
                            }

                            //check from the bottom
                            if (row < rows - 1 && A[row + 1][col] == 1)
                            {
                                stack.Push(new Tuple<int, int>(row + 1, col));
                            }

                            //check to the left
                            if (col > 0 && A[row][col - 1] == 1)
                            {
                                stack.Push(new Tuple<int, int>(row, col - 1));
                            }

                            //check to the right
                            if (col < columns - 1 && A[row][col + 1] == 1)
                            {
                                stack.Push(new Tuple<int, int>(row, col + 1));
                            }
                        }
                    }
                }
            }


            ////change all interior (non-perimeter) 1's to 2's if and only if a 1 has a neighboring 2
            ////repeat this process until the matrix is unchanged
            /////does not use any "auxillary space," which is a good thing.
            ///rather, it is constant space complexity
            //bool isChanged;
            //do
            //{
            //    isChanged = false;  //nothing has been mutated in the matrix, so this boolean is set to false

            //    //cycle through all inner (non-perimeter) rows
            //    for (int i = 1; i < rows - 1; i++)
            //    {
            //        //cycle through all inner (non-perimeter) columns
            //        for (int j = 1; j < columns - 1; j++)
            //        {
            //            //check if an element that is a 1 has a neighboring element of 2, and if so,
            //            //update that element that was a 1 to a 2.
            //            if ((A[i][j] == 1 && A[i + 1, j] == 2) ||
            //                (A[i][j] == 1 && A[i - 1, j] == 2) ||
            //                (A[i][j] == 1 && A[i, j + 1] == 2) ||
            //                (A[i][j] == 1 && A[i, j - 1] == 2))
            //            {
            //                A[i][j] = 2;
            //                isChanged = true; //the matrix has been mutated
            //            }
            //        }
            //    }
            //}
            //while (isChanged == true); //discontinue the loop when no new mutations have been made


            //convert all remaining 1's to 0's and then all 2's to 1's
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (A[i][j] == 1)
                    {
                        A[i][j] = 0;
                    }
                    else if (A[i][j] == 2)
                    {
                        A[i][j] = 1;
                    }
                }
            }
            return A;
        }
    }
}
