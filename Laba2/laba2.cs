using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya1
{
    class Program
    {
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
            string s2 = "I don't wanna die i don't wanna die";
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
            Console.WriteLine("String.Insert: " + s3.Insert(5, " BCTABKA"));
            a = s3.IndexOf("more");
            Console.WriteLine("String.Remove: " + s3.Remove(a, 3));

        }


    }
}
