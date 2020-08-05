﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrDictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDictionary strd = new StringDictionary();
            strd.Add("1", "one");
            strd.Add("2", "two");
            strd.Add("3", "three");
            strd.Add("4", "four");
            strd.Add("5", "five");
            Console.WriteLine("elements in the dictionary.....");
            foreach(DictionaryEntry i in strd)
            {
                Console.WriteLine("{0}={1}",i.Key,i.Value);
            }
            Console.WriteLine("contains key in the dictionary or not.......");
            var j= strd.ContainsKey("6");
            Console.WriteLine(j);
            Console.WriteLine("contains value in the dictionary or not.......");
            var k= strd.ContainsValue("six");
            Console.WriteLine(k);
            Console.WriteLine("retriving all keys from the dictionary...");
            foreach(DictionaryEntry d in strd)
            {
                Console.WriteLine(d.Key);
            }
            Console.WriteLine("retriving all values from the dictionary...");
            foreach (DictionaryEntry d in strd)
            {
                Console.WriteLine(d.Value);
            }
            Console.WriteLine("number of elements present in the dictionary.....");
            Console.WriteLine(strd.Count);
            Console.Read();
        }
    }
}
