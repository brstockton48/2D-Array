using System;
using System.IO;
/// <summary>
/// Billy Stockton
/// 2DArray Exercise
/// Due 6/10/2021
/// This Program prints, transposes and traces matrices
/// </summary>

namespace Stockton2DArray
{
    class Program
    {
        /// <summary>
        ///variables, constants and arrays
        /// </summary>
        public static int currentRowCt = 0;
        public static int maxRowCt = 4;
        public static int startColCt = 0;
        public static int maxColCt = 4;
        public static int[,] origMatrix;
        public static int[,] transMatrix;
        public static string FILE_NAME = "4x4matrix.txt";
        
        /// <summary>
        /// Main Method 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(currentRowCt,maxRowCt,startColCt,maxColCt);
            origMatrix = matrix.BuildMatrix(FILE_NAME, matrix.GetArray());//Builds Original Array
            transMatrix = matrix.BuildTranspose(origMatrix);//Transposes Array
            PrintMatrix(origMatrix);//Prints Original Array
            PrintTranspose(transMatrix);//Prints Transposed Array
            CompareSymmetry(origMatrix,transMatrix);//Compares arrays for Symmetry
            PrintTrace(matrix.GetTrace(transMatrix) ,transMatrix);//Prints Trace for Array
        }

        /// <summary>
        /// This Method Prints the original matrix
        /// </summary>
        /// <param name="origMatrix"></param>
        public static void PrintMatrix(int[,] origMatrix)
        {
            Console.WriteLine("\n4x4 Matrix\n");
            int row, col;
            for (row = currentRowCt; row < maxRowCt; ++row)
            {
                for (col = startColCt; col < maxColCt; ++col)                
                    Console.Write(" {0}", origMatrix[row, col]);
                    Console.WriteLine();               
            }
        }
        /// <summary>
        /// This Method Prints the Transposed Matrix
        /// </summary>
        /// <param name="transMatrix"></param>
        public static void PrintTranspose(int[,] transMatrix)
        {
            Console.WriteLine("\nTransposed 4x4 Matrix\n");
            int row, col;
            for (row = currentRowCt; row < maxRowCt; ++row)
            {
                for (col = startColCt; col < maxColCt; ++col)               
                    Console.Write(" {0}", transMatrix[row, col]);
                    Console.WriteLine();                
            }
        }
        /// <summary>
        /// This Method compares to see if the Matrices are Symmetrical
        /// </summary>
        /// <param name="origMatrix"></param>
        /// <param name="transMatrix"></param>
        public static void CompareSymmetry(int[,] origMatrix, int[,] transMatrix)
        {
            if(origMatrix==transMatrix)
            {
                Console.WriteLine("\nMatrices are Symmetrical");
            }
            else
            {
                Console.WriteLine("\nMatrices are Not Symmetrical");
            }
        }
        /// <summary>
        /// This method Prints the trace and result of the Matrix
        /// </summary>
        /// <param name="traceResult"></param>
        /// <param name="transMatrix"></param>
        public static void PrintTrace(int traceResult, int[,] transMatrix)
        {
            Console.WriteLine("\nTrace Result\n");

            for (int r = currentRowCt; r < maxRowCt; r++)
            {
                Console.Write("{0}", transMatrix[r, r]+"+");                
            }
            Console.Write("="+traceResult+"\n");
        }
    }   
}
