using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
/// <summary>
/// Billy Stockton
/// 2DArray Exercise
/// Due 6/10/2021
/// This Program prints, transposes and traces matrices
/// </summary>

namespace Stockton2DArray
{
    
    public class Matrix
    {
        /// <summary>
        /// Class Constants/Arrays/Attributes
        /// </summary>
        public int currentRow = 0;
        public int maxRow = 4;
        public int startCol = 0;
        public int maxCol = 4;
        public int traceResult = 0;
        public int[,] twoDArray = new int[4,4];
        public int[,] transArray = new int[4, 4];

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="CurrentRow"></param>
        /// <param name="MaxRow"></param>
        /// <param name="StartCol"></param>
        /// <param name="MaxCol"></param>
        public Matrix(int CurrentRow, int MaxRow, int StartCol, int MaxCol)
        {
            this.currentRow = CurrentRow;
            this.maxRow = MaxRow;
            this.startCol = StartCol;
            this.maxCol = MaxCol;
        }
        /// <summary>
        /// This Method builds the original Matrix
        /// </summary>
        /// <param name="file"></param>
        /// <param name="origArray"></param>
        /// <returns></returns>
        public int[,] BuildMatrix(string file, int[,] origArray)
        {
            currentRow = 0;
            StreamReader reader = new StreamReader(file);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string lines = reader.ReadLine();

                char[] delim = { ',' };
                string[] fields = lines.Split(delim);
                for (int col= startCol; col< maxCol; col++)
                {
                    origArray[currentRow, col] = int.Parse(fields[col]);
                }
                ++currentRow;             
            }
            return origArray;
        }
        /// <summary>
        /// This method transposes the matrix
        /// </summary>
        /// <param name="origArray"></param>
        /// <returns></returns>
        public int[,] BuildTranspose(int[,] origArray)
        {
            currentRow = 0;
            
            for (int row = currentRow; row < maxRow; row++)
            {
                for (int col = startCol; col < maxCol; col++)
                {
                    transArray[col, row] = origArray[row, col];
                }
            }
            return transArray;           
        }

        /// <summary>
        /// This method calculates the trace value
        /// </summary>
        /// <param name="transArray"></param>
        /// <returns></returns>
        public int GetTrace(int[,] transArray)
        {
            for (int r = currentRow; r < maxRow; r++)
            {
                traceResult = traceResult + transArray[r,r];
            }
            return traceResult;
        }
                    
       /// <summary>
       /// This method returns the original empty array
       /// </summary>
       /// <returns></returns>
     
        public int[,] GetArray()
        {
            return twoDArray;
        }
    }
}


    

