using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Gülnur Yüksel");
            myDictionary.Add(2, "Veli Yağmur");
            myDictionary.Add(3, "Gönül Dursun");
            myDictionary.Add(4, "Ahmet Yıldız");
            Console.WriteLine(myDictionary.Count);
        }
    }
}
