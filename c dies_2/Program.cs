using System.Net;
using static System.Net.Mime.MediaTypeNames;


namespace c_dies_2

{
    internal class Program
    {
        enum ENUM
        {
            Monday, Tuesday, Wednesday
        }
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };    // одномерный массив
            int[,] arr2 = new int[16, 16];      // двумерный массив
            int[,,,] ar3 = new int[1, 4, 4, 5];      // сколькоугодномерный массив  

            // JAGGED  ЗУБЧАТЫЙ МАССИВ

            int[][] arr3 = new int[2][];
            arr3[0] = new int[] { 1, 2, 3, 4 };
            arr3[1] = new int[] { 3, 4 };
            //Console.WriteLine(arr3[1][0]);

            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            string str = "aaabbb";
            str += "aaa";
            Console.WriteLine(str);

            ENUM day = ENUM.Wednesday;
            Console.WriteLine(day);

            //  ЗАДАЧА

            int chet = 0, nech = 0, uniq = 0, count = 0,count1 = 0, chet1 = 0, nech1 = 0, uniq1 = 0;
            int[] arr4 = new int[21] { 43, 54, 23, 4, 1, 76, 5, 4, 3, 2, 32, 76, 5, 1, 9, 0, 7, 654, 43, 21, 23 };
            int[] arr44 = arr4;

            foreach (int i in arr44)
            {
                if (i == 0) continue;
                else if (i % 2 == 0) ++chet1;
                else if (i % 2 != 0) ++nech1;
            }
            for (int i = 0; i < 10; ++i)
            {
                count1 = 0;
                for (int j = 0; j < 10; ++j)
                {
                    if (i == j) continue;
                    if (arr4[i] == arr44[j])
                    {
                        ++count1;
                        break;
                    }
                }
                if (count1 == 0) { uniq1++; }
            }
                Console.WriteLine(chet1 + "   " + nech1 + "   " + uniq1);

            Random rnd = new Random();
            int Randomize = rnd.Next(1, 10);

            int[] arr5 = new int[10];
            for(int i = 0; i < 10; ++i)
            {
                arr5[i] = rnd.Next(1, 10);
                Console.WriteLine("Элемент массива " + i + " равен " + arr5[i]);
            }
            foreach(int i in arr5)
            {
                if (i % 2 == 0)
                {
                    ++chet;
                }
                if (i % 2 != 0)
                {
                    ++nech;
                }
            }
            int[] arr55 = arr5;
            for (int i = 0; i < 10; ++i)
            {
                count = 0;
                for(int j = 0; j < 10; ++j)
                {
                    if (i == j) continue;
                    if (arr5[i] == arr55[j])
                    {
                        ++count;
                        break;
                    }
                }
                if (count == 0) { uniq++; }
            }
            Console.WriteLine(chet + "   " + nech + "   " + uniq);


            //  ПОДСЧЕТ СТРОК

            string? stroka;    // строка не принимает NULL
            int cislo = 0;
            stroka = Console.ReadLine();
            //string[] stroka1 = stroka.Split(new char[] { ' ' });
            string[] stroka1 = stroka.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string i in stroka1)
            //{
            //    cislo++;
            //}
            //Console.WriteLine(cislo);

            Console.WriteLine(stroka1.Length);

            int num = Convert.ToInt32(Console.ReadLine());
            //int num = 7;
            int[] arr7 = new int[num];
            for (int i = 0; i < num; ++i)
            {
                arr7[i] = rnd.Next(1, 100);
                Console.Write(arr7[i] + "  ");
            }
            int max = arr7[0], min = arr7[0];

            foreach (int i in arr7)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
            //for(int i = 1; i < num; ++i)
            //{
            //    if (arr7[i]<min) min = arr7[i];
            //    if (arr7[i] > max) max = arr7[i];
            //}
            Console.WriteLine(min + "  " + max);
        }
    }
}
