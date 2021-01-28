using System;

namespace CS_133_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array2 = new int[10];
              array2[0] = 11;
              array2[1] = 12;
              array2[2] = 13;
              array2[3] = 14;
              array2[4] = 15;
              array2[5] = 16;
              array2[6] = 17;
              array2[7] = 18;
              array2[8] = 19;
              array2[9] = 20;


            int[,] array1 = new int[10, 10];

            array1[0, 0] = 1;
            array1[0, 1] = 2;
            array1[0, 2] = 3;
            array1[0, 3] = 4;
            array1[0, 4] = 5;
            array1[0, 5] = 6;
            array1[0, 6] = 7;
            array1[0, 7] = 8;
            array1[0, 8] = 9;
            array1[0, 9] = 10;

            array2.CopyTo(array1, 1);










            Console.WriteLine(array1) ;
        }
    }
}
