//using System;

//     class Exercise5
//    {
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Array length: ");
//        int n;
//        n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine();

//        int[] array = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        double s1 = arithmeticSum(array);
//        Console.WriteLine("Arithmetic sum: " + s1);

//        double s2 = geometricSum(array);
//        Console.WriteLine("Geometric sum: " + s2);
//        Console.ReadKey();


//    }

//    static float geometricSum(int[] array)
//    {
//        float product = 1;
//        for (int i = 0; i < array.Length; i++)
//        {
//            product *= array[i];
//        }
//        float gS =(float) Math.Pow(product,(float)1 / array.Length);
//        return gS;
//    }
    
//    static float arithmeticSum(int[] array)
//    {
//        float sum = 0;
//        for(int i = 0; i < array.Length; i++)
//        {
//            sum += array[i];
//        }
//        sum = sum / array.Length;

//        return sum;
//    }
//}
