using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] array = { 2, 3, 5, 2, 7, 1 }; 

            int first = array[0]; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == first)
                {
                    Console.WriteLine("Первый элемент находится " + i);
                    break;
                }
            */

            /*
            int[] array = new int[] { -1, -8, 6, 2, 1, 4 }; 

            Console.Write(" Все неотрицательные элементы массива ");

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] >= 0) 
                {
                    Console.Write($"{array[i]} "); 
                }
            }
            */

            /*
            int[] array = new int[] { 121, 202, 6, 111, 125, 4 };

            Console.Write(" Все непревышающие 100  ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 100)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            */

            /*
            int[] array = new int[] { 121, 202, 6, 111, 125, 4 };

            Console.Write(" Чётные числа   ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2==0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            */


            /*
            
            int count = 0;
            int[] array = new int[] { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <0)
                {
                    count++;
                }
            }
            Console.WriteLine($" Кол во отриц элем {count}");
            */


            /*
            int summ=0;
            int count = 0;
            int[] array = new int[] { 1,3,5,7,9 };
            for (int i = 0; i < array.Length; i++)
            {
              summ += array[i];
              count++;

            }

            double average = (double)summ / count;

            Console.WriteLine($"Среднее арифметическое {average}");*/



            /*
            int[] array = new int[] { 1,2,3,4,5,6,7}; 

            int first = array[0]; 

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] += first; 
            }

            
            foreach (int elem in array) 
            {
                Console.Write($"{elem} ");
            }
            */
        }
    }
 }


