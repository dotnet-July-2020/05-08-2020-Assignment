using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCollection_Assignment
{
    
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection str = new StringCollection();
            str.Add("geethu");
            str.Add("krish");
            str.Add("vinnu");
            str.Add("raja");
            str.Add("honey");
            Console.WriteLine("StringCollection elements...");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            String[] arr = new String[] { "one", "two", "three", "four", "five" };
            str.AddRange(arr);
            Console.WriteLine("Adding range of elements to string collection.....");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("inserting elements at a specified location.....");
            str.Insert(1, "rakul");
            foreach (string res in str)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("checking wheteher the element is present or nor...");
            var k=str.Contains("ram");
            Console.WriteLine(k);
            Console.WriteLine("finding the index of a particular element...");
            var j=str.IndexOf("raja");
            Console.WriteLine(j);
            Console.WriteLine("finding equality...");
            var l=str.Equals("geethu");
            Console.WriteLine(l);
            Console.Read();
        }
    }
}
