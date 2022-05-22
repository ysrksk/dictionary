using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Yılmaz");
            kullanicilar.Add(20,"Özcan Yılmaz");

            //Dizinin Elemanlarına Erişim
            Console.WriteLine("Elemanlara Erişim");
            Console.WriteLine(kullanicilar[12]);
            foreach(var item in kullanicilar)
                System.Console.WriteLine(item);            

            //Count
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
                System.Console.WriteLine(item);  

            //Keys
            System.Console.WriteLine("Keys");
            foreach(var item in kullanicilar.Keys)
                System.Console.WriteLine(item);

            //Values
            System.Console.WriteLine("VAlues");
            foreach(var item in kullanicilar.Values)
                System.Console.WriteLine(item);
            
        }
    }
}
