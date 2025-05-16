using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_TASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIR OLCULU MASSIV");
            //Maximum elementi
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            { numbers[i] = random.Next(1, 100); }
            PrintArray(numbers);
           Console.Write("Max element: ");
           max(numbers);

            //Minimum elementi
            Console.Write("Min element: ");
            min(numbers);
            //reverse
            Console.Write("Reverse: ");
            reverse(numbers);
            //Sort-Coxdan-Aza
            Console.Write("\nSort(Coxdan-Aza): ");
            SortCoxdanAza(numbers);
            //Sort-Azdan-Coxa
            Console.Write("Sort(Azdan-Coxa): ");
            SortAzdanCoxa(numbers);
            //cem
            Console.Write("Cem: ");
            cem(numbers);

            //IKI OLCULU ARRAY
            Console.WriteLine("\n\nIKI OLCULU MASSIV");
            int[,] array = new int[3,3];
            for (int a = 0; a < array.GetLength(0); a++)
            { for (int b = 0; b < array.GetLength(1); b++)
                { array[a, b] = random.Next(10, 100); }
            }
            PrintArray(array);
            //Maximum elementi
            Console.Write("Maximum element: ");
            max(array);
            //Minimum elementi
            Console.Write("Minimum element: ");
            min(array);
            //diagonaldaki ededlerin cemi
            Console.Write("Diagonal elementlerin cemi: ");
            diagonal(array);
            //diagonaldan yuxari elementlerin cemi
            Console.Write("Diagonaldan yuxari elementlerin cemi: ");
            DiagonaldanYuxariCem(array);
            //diagonaldan yuxari max element
            Console.Write("Diagonaldan yuxari max element: ");
            DiagonaldanYuxariMax(array);
        }



        static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void max(int[] numbers)
        {
            int maxelement = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxelement)
                { maxelement = numbers[i]; }
            }

            Console.WriteLine(maxelement);
        }

        static void max(int[,] numbers)
        {
            int maxelement = numbers[0,0];
            for (int i = 1; i < numbers.GetLength(0); i++)
            {
                for (int j = 1; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] > maxelement)
                    { maxelement = numbers[i, j]; }
                }
             
            }

           Console.WriteLine(maxelement);
        }

        static void min(int[] numbers)
        {
            int minelement = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minelement)
                { minelement = numbers[i]; }
            }

            Console.WriteLine(minelement);
        }

        static void min(int[,] numbers)
        {
            int minelement = numbers[0, 0];
            for (int i = 1; i < numbers.GetLength(0); i++)
            {
                for (int j = 1; j < numbers.GetLength(0); j++)
                {
                    if (numbers[i, j] < minelement)
                    { minelement = numbers[i, j]; }
                }

            }

            Console.WriteLine(minelement);
        }

        static void SortCoxdanAza(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int a = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = a;
                    }
                }
            }
            PrintArray(numbers);
        }

        static void SortAzdanCoxa(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int a = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = a;
                    }
                }
            }
            PrintArray(numbers);
        }

        static void reverse(int[] numbers)
        { for (int i=numbers.Length-1;i>=0;i--)
            { Console.Write(numbers[i] + " "); }    
        }

        static void cem(int[] numbers)
        {
            int cem = 0;
            foreach(int i in numbers)
            { cem += i; }
            Console.WriteLine(cem);
        }

        static void diagonal(int[,] numbers)
        {
            int cem = 0;
           for(int i=0;i<numbers.GetLength(0);i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                { if(i==j)

                   cem=cem + numbers[i, j];
                }
            }
            Console.WriteLine(cem);
        }

        static void DiagonaldanYuxariCem(int[,] numbers)
        {
            int cem = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (i < j)
                        cem = cem + numbers[i, j];
                }
            }
            Console.WriteLine(cem);
        }
         static void DiagonaldanYuxariMax(int[,] numbers)
            {
            int maxelement = numbers[0, 0];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (numbers[i, j] > maxelement)
                        { maxelement = numbers[i, j]; }
                    }
                   
                }
            }
            Console.WriteLine(maxelement);
        }

     }
}



  


