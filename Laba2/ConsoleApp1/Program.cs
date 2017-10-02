using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya1
{
    class Program

    {
        static float readFloat()
        {
            Console.Write("Введите число: ");
            return float.Parse(Console.ReadLine());
        }
         static Tuple<int,int,int,char> createTuple(int[] arr,string str)
        {
            int min=Int32.MaxValue, max=Int32.MinValue, sum=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
                sum += arr[i];
            }
            return Tuple.Create(min,max,sum, str.ElementAtOrDefault(0));
        }
        static void Main(string[] args)
        {
            int a = 15;
            double b = 200000_12_3;
            float g = -202;
            byte m = 220;
            sbyte l = -101;
            short k = 30000;
            ushort o = 62000;
            uint u = 1323232;
            long p = -19928483482;
            ulong y = 109232131929;
            char v = 'x';
            bool n = true;
            decimal c = 1302923;
            string s = "SYSTEMA";
            object e = "HELLOWORLD";
            Console.WriteLine("ZDOROVA:{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}", a, b, g, m, l, k, o, u, p, y, v, n, c, s, e);

            b = g;//float -> double
            p = a;// int -> long
            c = y;//ulong -> decimal
            u = m;//byte ->uint
            e = s;//string -> object

            m = (byte)a;
            m = Convert.ToByte(p);
            o = (ushort)a;
            y = (ulong)c;
            b = Convert.ToDouble(c);

            object intboxed = b;
            double intunboxed = (double)intboxed;

            var neyavnoe = 130;
            var neponyatnoe = v;
            int? PerviiNullik = null;
            Nullable<int> VtoroiNullik = null;
            bool? Bulimiya = null;
            bool Bulimishka;
            Bulimishka = Convert.ToBoolean(Bulimiya);
            if (!Bulimishka)
            {
                PerviiNullik = 130;
                VtoroiNullik = 140;
            }
            //STRINGS
            string s1 = "POCHEMU MI ESHE NE SDOHLI";
            string s2 = "I don't wanna die Im gonna cry";
            string s3 = "Chisto dlya proformi";

            if (s1 == s2)
            { Console.WriteLine("SILI RAVNI"); }
            else
            { Console.WriteLine("NERAVNAYA BITVA"); }

            if (s1.CompareTo(s2) > 0)
            { Console.WriteLine("BTOPAR CTPOKA MEHbIIIE"); }
            else
            { Console.WriteLine("BTOPAR CTROKA BOJIbIIIE"); }

            s3 = String.Concat(s3, " ", s2);
            Console.WriteLine("String.Concat: " + s3);
            s3 = String.Copy(s2);
            Console.WriteLine("String.Copy: " + s3);

            Console.WriteLine("String.Substring: " + s3.Substring(2));
            Console.WriteLine("String.Split: ");
            string[] strArr = s3.Split(new char[] { ' ' });
            foreach (string substr in strArr)
            {
                Console.WriteLine(substr);
            }
            Console.WriteLine("String.Insert: " + s3.Insert(7, " insert"));
            a = s3.IndexOf("don't");
            Console.WriteLine("String.Remove: " + s3.Remove(a, 5));

            s3 = "";
            s2 = null;
            if (s2 == null) Console.WriteLine(" s2 is null");
            if (s2 != s3) Console.WriteLine("s2 ne sovpadaet s s3");
            if (String.IsNullOrEmpty(s3) && String.IsNullOrEmpty(s2)) Console.WriteLine(" s2 and s3 are null or empty strings");
            Console.WriteLine("s3+s2= '" + s3 + s2 + "'");

            StringBuilder sb = new StringBuilder("Главная строка");
            Console.WriteLine("StringBuilder started with: " + sb);
            sb.Remove(0, 6);
            sb.Append(" постставка");
            sb.Insert(0, "приставка ");
            Console.WriteLine("StringBuilder ended up with: " + sb);

            int[,] ar1 = new int[3, 3];
            ar1 = new int[,] { { 1, 2, 3 }, { 11, 12, 13 }, { 21, 22, 23 } };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,2} {1,2} {2,2}", ar1[i, 0], ar1[i, 1], ar1[i, 2]);
            }

            string[] arrStr = new string[3];
            arrStr[0] = "Stroka 0";
            arrStr[1] = "Stroka 1";
            arrStr[2] = "Stroka 2";
            Console.WriteLine("Массив строк длиной {0}", arrStr.Length);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrStr[i]);
            }
            Console.Write("Номер изменяемой строки:");
            a = (int.Parse(Console.ReadLine()) % 3);
            Console.Write("Новая строка:");



            arrStr[a] = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrStr[i]);
            }

            float[][] arrFl = new float[3][];
            arrFl[0] = new float[2];
            arrFl[1] = new float[3];
            arrFl[2] = new float[4];
            arrFl[0][0] = readFloat();
            arrFl[0][1] = readFloat();
            for (int i = 0; i < 3; i++)
            {
                arrFl[1][i] = readFloat();
            }
            for (int i = 0; i < 4; i++)
            {
                arrFl[2][i] = readFloat();
            }

            Console.WriteLine("{0,5} {1,5}", arrFl[0][0], arrFl[0][1]);
            Console.WriteLine("{0,5} {1,5} {2,5}", arrFl[1][0], arrFl[1][1], arrFl[1][2]);
            Console.WriteLine("{0,5} {1,5} {2,5} {3,5}", arrFl[2][0], arrFl[2][1], arrFl[2][2], arrFl[2][3]);

            var someArr = new int[] { 143, 222, 0, 666, -20 };
            Console.WriteLine(someArr + " состоящий из " + someArr.Length + " элементов");

            var str = "Очередная строка";
            Console.WriteLine(str.GetType() + " '" + str + "'");

            var tu = Tuple.Create<int, string, char, string, ulong>(13, "stroka1", 'L', "stroka2", 666);
            Console.WriteLine("Tuple: int={0} string={1} char={2} string2={3} ulong={4}", tu.Item1, tu.Item2, tu.Item3, tu.Item4, tu.Item5);
            Console.WriteLine("Tuple chastichno: int={0} char={1} string2={2}", tu.Item1, tu.Item3, tu.Item4);

            int intel = tu.Item1;
            string stringel0 = tu.Item2;
            char charel = tu.Item3;
            string stringel1 = tu.Item4;
            ulong ulongel = tu.Item5;
            var tu2 = createTuple(someArr, "Ёлки");
            Console.WriteLine("Tuple2 : min={0} max={1} sum={2} char='{3}'", tu2.Item1, tu2.Item2, tu2.Item3, tu2.Item4);

            if (tu.Equals(tu2))
            {
                Console.WriteLine("Tuples are equal");
            }
            else
            {
                Console.WriteLine("Tuples are not equal");
            }

            Console.ReadLine();
      



    }


    }
}
