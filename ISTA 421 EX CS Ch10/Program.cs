using System;

namespace ISTA_421_EX_CS_Ch10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRLE1 = { 4, 5, 4, 10, 2, 5 };
            int[] arrayRLE2 = { 5, 1, 4, 2, 3, 3, 2, 4, 1, 5 };

            foreach (int num in decodeRLE(arrayRLE1))
                Console.Write(num + " ");

            Console.WriteLine();

            foreach (int num in decodeRLE(arrayRLE2))
                Console.Write(num + " ");

            Console.WriteLine(); Console.WriteLine();
        }

        static int[] decodeRLE(int[] array)
        {
            int decodedSize = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                decodedSize += array[i];
            }


            int[] decoded = new int[decodedSize];
            int iterator = 0;

            for (int x = 0; x < array.Length; x += 2)
            {
                for (int y = 0; y < array[x]; y++)
                {
                    decoded[iterator++] = array[x + 1];
                }
            }
            return decoded;
        }
    }
}
