using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FOR_TASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] array = new int[10];
            //Random random1 = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{

            //        array[i] = random1.Next(-100, 100);

            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //        Console.Write(array[i] + " ");
            //}

            Console.WriteLine();
            int[,] A = new int[3, 3];
            Random random2 = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = random2.Next(-100, 100);
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            //1.A massivinin elementlerinin cemi
            // int sum = 0;
            //for(int i=0; i<array.Length;i++)
            // {
            //     sum = sum + array[i];
            // }
            // Console.WriteLine(sum);

            //2.A massivinin birinci menfi edeedin evvelki ededlerin hesabi ortasi
            //int sum = 0,say=0;
            //for(int i=0;i<array.Length;i++)
            //{
            //    if (array[i] < 0)
            //        break;
            //    say++;
            //    sum += array[i];

            //}
            //Console.WriteLine(sum / say);

            // 3.A massiviin birinci menfi elemntinden evvelki elementlerin sayi
            //int  say = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //        break;
            //    say++;


            //}
            //Console.WriteLine(say);

            //4.A massivinin musbet elementlerinin cemi
            //int sum = 0;
            //for(int i=0;i<array.Length;i++)
            //{
            //    if (array[i]>0)
            //    { sum = sum + array[i]; }
            //}
            //Console.WriteLine(sum);

            //5.A massivinin musbet elementlerinin sayi ve cemi
            //int sum = 0, say = 0;
            //for (int i = 0; i < array.Length; i++) 
            //{
            //    if (array[i] > 0)
            //    {
            //        sum = sum + array[i];
            //        say++;
            //    }
            //}
            //Console.WriteLine($"Cemi {sum} sayi {say}");


            //11.A massivinin cut indeksli edelerinin cemi
            //int sum = 0;
            //for(int i = 0;i < array.Length; i++)
            //{
            //    if(i%2==0)
            //    {
            //        sum=sum+array[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //15.A ve B nin uygun elementlerinin ceminden C massivi
            //int[] B = new int[10] {1,2,3,4,5,6,7,8,9,10};
            //int[] C = new int[B.Length];
            //for(int i = 0;i < B.Length;i++)
            //{
            //    C[i]= B[i] + array[i];

            //}
            //foreach(int i in C)
            //    Console.Write(i + " ");

            //16.A massivinin menfi elmentlrinden d massivi
            //int say = 0;
            //for(int i = 0;i < array.GetLength(0); i++)
            //{
            //    if (array[i] < 0) { say++; }
            //}
            //int[] D = new int[say];
            //int a = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    if(array[i] < 0) { D[a] = array[i];a++; }

            //}
            //foreach (int i in D) {Console.Write(i+" "); }

            //21.A da5 den boyuk 15 den kicik elemnt cemi
            //int sum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    if (array[i]>5 && array[i]<15)
            //    { sum = sum + array[i]; }

            //}
            //Console.WriteLine(sum);

            //23.A massivinin elemntlerini 4e vur D massivi duzelt alinan massivde >5 olanlari topla
            //int[] D = new int[array.Length];
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    D[i] = array[i] * 4;

            //}
            //foreach (int i in D) {Console.Write(i+" "); }
            //for (int i = 0; i < D.Length; i++)
            //{
            //    if (D[i] > 5) { sum += D[i]; }

            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);



            //30.A matisinin en boyuk elementi ve onun indeksi
            //int maxElement = A[0, 0];
            //int indexi = 0, indexj = 0;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] > maxElement)
            //        {
            //            maxElement = A[i, j];
            //            indexi = i;
            //            indexj = j;
            //        }
            //    }

            //}
            //Console.WriteLine($"Element: {maxElement} \nElementin indexi: [{indexi},{indexj}] ");

            //29.A matrisinin setir elemetnlerinin azalan sira ile duzulmesi
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        for (int k = j + 1; k < A.GetLength(1); k++)
            //        {
            //            if (A[i, j] < A[i, k])
            //            {
            //                int temp = A[i, j];
            //                A[i, j] = A[i, k];
            //                A[i, k] = temp;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Setir elementlerinin azalan sira ile duzulmesi");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //28.A massivinin musbet eleentlerinden B massivi duzelmeli alinin matrisin en kicik elemnti tapilmali
            //int[,] B=new int[3,3];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] > 0)
            //        {
            //            B[i, j] = A[i, j];
            //        }
            //        else
            //        {
            //            B[i, j] = 0;

            //        }
            //    }
            //}
            //int minElement = B[0,0];
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, j] < minElement && B[i, j] != 0)
            //        {
            //            minElement = B[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Musbet elementlerden ibaret B massivi");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"B massiviin en kicik elementi: {minElement} ");



            //27.A matrisinin bas diaqonali elementlerinin cemi
            //int sum = 0;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            sum += A[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"A matrisinin bas diaqonali elementlerinin cemi: {sum} ");



            //26.A matrisinin bas diagonaldan yuxarida yerlesen musbet elementlerinin cemi
            //int sum = 0;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (i < j && A[i, j] > 0)
            //        {
            //            sum += A[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"A matrisinin bas diagonaldan yuxarida yerlesen musbet elementlerinin cemi: {sum} ");


            //25.A matrisinin bas diagonaldan altda yerlesen menfi elementlerinin hesabi ortasi
            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (i > j && A[i, j] < 0)
            //        {
            //            sum += A[i, j];
            //            count++;
            //        }
            //    }
            //}
            //double hesabi_orta=sum / count;
            //Console.WriteLine($"A matrisinin bas diagonaldan altda yerlesen menfi elementlerinin hesabi ortasi: {hesabi_orta} ");


            //24.A matrisinin bas diagonaldan altda yerlesen musbet elementlerinin cemi
            //int sum = 0;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (i > j && A[i, j] > 0)
            //        {
            //            sum += A[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"A matrisinin bas diagonaldan altda yerlesen musbet elementlerinin cemi: {sum} ");

            //23.A.matrisinin maksimum elementi
            //int maxElement = A[0, 0];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] > maxElement)
            //        {
            //            maxElement = A[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"A matrisinin maksimum elementi: {maxElement} ");

            //22.A matrisinin her bir setrindeki minimum elementden B matrisi duzeltmeli,alinmis massivde enboyuk element tapilmali
            //int[,] B = new int[3, 3];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int minElement = A[i, 0];
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] < minElement)
            //        {
            //            minElement = A[i, j];
            //        }
            //    }
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        B[i, j] = minElement;
            //    }
            //}
            //int maxElement = B[0, 0];
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        if (B[i, j] > maxElement)
            //        {
            //            maxElement = B[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("A matrisinin her bir setrindeki minimum elementden duzeldilmis B matrisi");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"B matrisinin en boyuk elementi: {maxElement} ");

            //21.A ve B matrisinin hasili ve alinmis matrisin minimum elementi
            //int[,] B =new int[,] { { 1, 2, 1 }, { 4, 5, 6 },{ 7, 8, 9 } } ;
            //int[,] C = new int[3, 3];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {

            //        C[i, j] += A[i, j] * B[i, j];
            //    }  
            //}
            //Console.WriteLine("A ve B matrisinin hasili");
            //for (int i = 0; i < C.GetLength(0); i++)
            //{
            //    for (int j = 0; j < C.GetLength(1); j++)
            //    {
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int minElement = C[0, 0];
            //for (int i = 0; i < C.GetLength(0); i++)
            //{
            //    for (int j = 0; j < C.GetLength(1); j++)
            //    {
            //        if (C[i, j] < minElement)
            //        {
            //            minElement = C[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"A ve B matrisinin hasili olan C matrisinin minimum elementi: {minElement} ");


            //1.A massivinin her setrindeki max elementi bas diagondaki element ile evez et

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int maxelement = A[i, 0];
            //    int maxindex = 0;
            //    for (int j = 1; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] > maxelement)
            //        {
            //            maxelement = A[i, j];
            //            maxindex = j;
            //        }
            //    }
            //    A[i, maxindex] = A[i, i];
            //}
            //Console.WriteLine();
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //2.A massivinin her sutunundaki max elementi bas diagondaki element ile evez et
            //for (int j = 0; j < A.GetLength(1); j++)
            //{
            //    int maxelement = A[0, j];
            //    int maxindex = 0;
            //    for (int i = 0; i < A.GetLength(0); i++)
            //    {

            //        if (maxelement < A[i, j])
            //        {
            //            maxelement = A[i, j];
            //            maxindex = i;
            //        }

            //    }
            //    A[maxindex, j] = A[j, j];
            //}
            //Console.WriteLine();
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //3.Her setirdeki menfi elmentlerin ceminden B massivi duzeltmeli
            //int[,] B = new int[3, 3];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] < 0)
            //        {
            //            sum += A[i, j];
            //        }
            //    }
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        B[i, j] = sum;
            //    }
            //}
            //Console.WriteLine("Her setirdeki menfi elmentlerin ceminden B massivi");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //4.setrdeki max elementden B massivi duzeltmeli
            //int[,] B = new int[3, 3];
            //for(int i=0;i<A.GetLength(0);i++)
            //{ int maxelement = A[i, 0];
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] > maxelement)
            //        {
            //            maxelement = A[i, j];
            //        }
            //    }
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        B[i, j] = maxelement;
            //    }
            //}
            //Console.WriteLine("Her setirdeki max elementden B massivi:");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            




















        }

    }
}



  


