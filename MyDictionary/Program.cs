using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> info = new MyDictionary<string, string>();
            Console.WriteLine("Program basladi, constructor calisti. Eleman sayisi: ");
            Console.WriteLine("items length: " + info.LengthItems);
            Console.WriteLine("values length: " + info.LengthValues);
            info.Add("name", "ayse");
            info.Add("surname", "yilmaz");
            Console.WriteLine("items length: " +  info.LengthItems);
            Console.WriteLine("values length: " + info.LengthValues);
            info.Add("color", "blue");
            info.Add("number", "9999");
            Console.WriteLine("items length: " + info.LengthItems);
            Console.WriteLine("values length: " + info.LengthValues);
        }
    }
}
