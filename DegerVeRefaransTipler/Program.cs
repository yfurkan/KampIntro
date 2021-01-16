using System;

namespace DegerVeRefaransTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]? 999
            Console.WriteLine(sayilar1[0]);

            //ınt, decimal, float, double, bool = değer tip
            //array, class, interface = referans tip
            //stack =değer tip olanlar burda tanımlanır.//sayi1 = 10 (sayi2 ye atanınca 30 olur) 
                                                       //sayi2 =30(sayi2 ye 65 değeri verince sayi2 65 olur)
                 //stack                      //heap
           //101//sayilar1    =>    //101//[10, 20, 30]
           //102//sayilar2    =>   //102//[100, 200, 300]  
           
            //sayilar1 = sayilar2 yapınca sayilar1 in referans numarasını 102 ye eşitler. 
            //sayilar2 ye 999 değerini atayınca referans değerini 999 olarak atar.
            //sayilar1 i sayılar2 ye eşitlediğimiz içinde sayilar1 in referans değerini de 999 olarak atar.
            //

        }

    }
}
