﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici";
            string kurs2 = "Programlamaya Giriş";
            string kurs3 = "java";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici", "Programlamaya Giriş", "java", "python", "c++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
