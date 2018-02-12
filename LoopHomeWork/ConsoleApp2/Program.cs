using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Выведите на экран: 
//  · прямоугольник 
//  · прямоугольный треугольник  
//  · равносторонний треугольник 
//  · ромб

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Прямоугольник
                        Console.WriteLine("Прямоугольник ");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j <20; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        //Console.ReadKey();
                        Console.Write("\n");
                        
                        
         //Прямоугольный треугольник
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        
                        Console.Write("\n");
            
         //Равносторонний трехугольник
                        int noRow = 5;
                        
                        for (int row = 1; row <=noRow;row++)
                        {
                            for (int space = noRow-row; space >= 1; space--)
                            {
                                Console.Write(" ");
                                
                            }
                            
                            for (int col = 1; col <= row; col++)    //
                            {                                       //
                                Console.Write("* ");                //("{0} ", (col))
                            }                                       //
                            Console.Write("\n");                    //
                           
                        }
         //Треугольник (row*2)-1
                        Console.WriteLine("Другой треугольник");
                        int noOfRow = 5;
                        int noOfSpace = noOfRow;

                        for (int row = 1;row <= noOfRow; row++)
                        {
                            for (int space = noOfRow - row; space >= 1; space--)
                            {
                                Console.Write(" ");
                            }
                            for(int star = 1; star <= (row *2)-1;star++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                                noOfRow = 5;
                        
                    Console.WriteLine("Нижная часть");
                                for (int row = 1; row <= noOfRow; row++)
                                {
                                    for (int space = 1; space <= row; space++)
                                    {
                                        Console.Write(" ");
                                    }
                                    for (int star = (noOfSpace * 2) - 1; star >= 1; star--)
                                    {
                                        Console.Write("*");
                                    }
                        
                                     Console.Write("\n");
                                     noOfSpace--;
                        
                                 }           



            //Ромб
                   Console.WriteLine("РОмб");
                   noOfRow = 5;
                   //Верх ромба
                   for (int row = 1; row <= noOfRow; row++)
                   {
                       for (int colSpace = noOfRow - row; colSpace >= 1 ; colSpace--)
                       {
                           Console.Write(" ");
                       }
                       for (int colStar = 1 ;colStar <= (row * 2) - 1 ;colStar++ )
                       {
                           Console.Write("*");
                       }
                       Console.Write("\n");
                   }
                   //Низ ромба  
                   //
                   //int decriment = ((noOfRow - 1) * 2) - 1;                                 //
                   for (int rowBottom = noOfRow - 1; rowBottom >= 1; rowBottom-- )          //
                   {                                                                        //
                       for (int colSpace = 1; colSpace <= noOfRow - rowBottom;colSpace++ )            //
                       {                                                                    //
                           Console.Write(" ");                                              //
                       }                                                                    //
                       for (int colStar = 1; colStar <= rowBottom*2-1 ; colStar++)             //
                       {                                                                    //
                           Console.Write("*");                                              //
                                                                                            //
                       }                                                                    //
                       //decriment -= 2;                                                      //
                       Console.Write("\n");                                                 //
                   }                                                                        //
                   Console.ReadKey();                                                       //

        }
    }
}


//
//
//
//
//
//
//
//
//
//