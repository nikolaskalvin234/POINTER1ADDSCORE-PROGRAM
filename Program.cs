using System;
using System.Collections;

namespace Addscore
{
    unsafe class Program
    {
        public static void Addscore(int* score)
        {
            *score = *score + 5;
            Console.WriteLine($"Score diubah ke: {*score}");
        }

        static void Main()
        {
            int score = 0;

            Console.WriteLine($"Score sebelum diubah: {score}");
            Addscore(&score);
            Addscore(&score);
            Addscore(&score);
            Addscore(&score);
            Console.WriteLine($"Score setelah diubah: {score}");
        }
    }
}
