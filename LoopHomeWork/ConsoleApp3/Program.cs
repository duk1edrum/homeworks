using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       static void Main(string[] args)
        {
//            int noOfRow = 7;
//            for(int row = 1; row <= noOfRow;row++)
//            {
//                for (int col = 1; col <= row; col++)
//                {
//                    Console.Write(" {0} ",col*row);
//                }
//                Console.Write("\n");
//            }
//            Console.WriteLine("\n");
//            // Треугольник нулем и еденицей 
//            int numOfRow = 21;
//
//            for (int row = 1;row <= numOfRow; row++)
//            {
//                for (int col = 1; col <= row; col++)
//                {
//                    int remainder = col % 2;
//                    Console.Write(" {0} ",remainder);
//                }
//                Console.Write("\n");
//            }
//                      int row, col1, col2, noOfCol;                           //-----   /*****
//                      int noOfRow1 = 5;                                       //----*   /-****
//                      noOfCol = noOfRow;                                      //---**   /--***
//                      for (row = 1; row <= noOfRow1; row++)                   //--***   /---**
//                      {                                                       //-****   /----*
//                          for (col2=1;col2 < row ;col2++ )                    //*****   /-----
//                          {                                                   //
//                             Console.Write("-");                              //
//                                                                              //
//                          }                                                   //
//                                                                              //
//                          for (col1 = 1; col1 <= noOfCol; col1++)             //
//                          {                                                   //
//                              Console.Write("*");                             //
//                          }
//                           noOfCol--;                                         //
//                          Console.Write("\n");
//
//
                //Pascal
                //----1
                //---1 1
                //--1 2 1
                //-1 3 3 1
                //1 4 6 4 1

                int numOfRows = 10;
                for (int row = 0; row < numOfRows; row++)
                {
                    for (int space = numOfRows - row; space >= 1; space--)
                    {
                        Console.Write(" ");
                    }
                int printChar = 1;
                int num = row;
                int den = 1;
                    for (int star = 0; star <= row; star++)
                    {
                        Console.Write("{0} ",printChar);
                    printChar = printChar * num;
                    printChar = printChar / den;
                    num--;
                    den++;
                    }
                    Console.Write("\n");

                }

            Console.ReadKey();
        }
    }
}
         