using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();
            myDict.Add("ilhan", "cüvelek");
            myDict.Add("eren", "cüvelek");
            myDict.Add("evren", "cüvelek");
            Console.WriteLine(myDict.lenght);
            foreach (string item in myDict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
