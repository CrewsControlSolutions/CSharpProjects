using System;

namespace MatrixIslandRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            //construct a 2D array
            int[,] A;

            //initialize array with values given in problem set
            A = new int[,] { { 1, 0, 0, 0, 0, 0 }, { 0, 1, 0, 1, 1, 1 }, { 0, 0, 1, 0, 1, 0 },
                { 1, 1, 0, 0, 1, 0 }, { 1, 0, 1, 1, 0, 0 }, { 1, 0, 0, 0, 0, 1 } };

            //number of rows and columns that make up the array "A".
            //needs updating since values are "hard-coded".
            int rows = 6;
            int columns = 6;

            //display each element of array to console to show original, unmutated matrix
            for (int i = 0; i < rows; i++ )
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");


            //change all perimeter 1's to 2's
            //cycle through all rows in the matrix
            for (int i = 0; i < rows; i++)
            {
                //cycle through all columns in the matrix
                for (int j = 0; j < columns; j++)
                {
                    //check if a perimeter element equals 1
                    if ((A[i, j] == 1 && i == 0) ||
                        (A[i, j] == 1 && i == rows - 1) ||
                        (A[i, j] == 1 && j == 0) ||
                        (A[i, j] == 1 && j == columns -1)) 
                    {
                        //turn all 1's on the perimeter to 2's
                        A[i, j] = 2;  
                    }
                }
            }


            //change all interior (non-perimeter) 1's to 2's if and only if a 1 has a neighboring 2
            //repeat this process until the matrix is unchanged
            bool isChanged;
            do
            {
                isChanged = false;  //nothing has been mutated in the matrix, so this boolean is set to false

                //cycle through all inner (non-perimeter) rows
                for (int i = 1; i < rows - 1; i++)
                {
                    //cycle through all inner (non-perimeter) columns
                    for (int j = 1; j < columns - 1; j++)
                    {
                        //check if an element that is a 1 has a neighboring element of 2, and if so,
                        //update that element that was a 1 to a 2.
                        if ((A[i, j] == 1 && A[i + 1, j] == 2) ||
                            (A[i, j] == 1 && A[i - 1, j] == 2) ||
                            (A[i, j] == 1 && A[i, j + 1] == 2) ||
                            (A[i, j] == 1 && A[i, j - 1] == 2))
                        {
                            A[i, j] = 2;
                            isChanged = true; //the matrix has been mutated
                        }
                    }
                }
            }
            while (isChanged == true); //discontinue the loop when no new mutations have been made


            //convert all remaining 1's to 0's
            for (int i = 0; i< rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (A[i, j] == 1)
                    {
                        A[i, j] = 0;
                    }
                }
            }


            //convert all 2's back to 1's
            for (int i=0; i < rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    if (A[i, j] == 2)
                    {
                        A[i, j] = 1;
                    }
                }
            }


            //display each element of mutated array to console
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");




            //create a function to make this program more modular

            //public int[][] RemoveIslands(int[][] A)
            //{
            //    //put island removal code here

            //    return A;
            //}

            //RemoveIslands(A);

        }
    }
}
