//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Laboratory1
//{
//    internal class Exercise1
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("first "+n+" fibonacci terms");
//            Console.WriteLine();

//            int[] f = new int[n+1];
//            f[0] = 0;
//            f[1] = 1;
//            f[2] = 1;
//            for (int i = 0; i <= 2; i++)
//            {
//                Console.WriteLine(f[i]);
//            }

//            for (int i=3; i < n; i++) {
//                f[i] = f[i - 1] + f[i - 2];
//                Console.WriteLine(f[i]);
//            }

//        }
//    }
//}
