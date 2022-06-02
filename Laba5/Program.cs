using System;
using System.Linq;
using System.Collections.Generic;
 
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = "Надрукувати всі його слова у порядку спадання їх довжин".Split(' ').ToList();
            lst = lst.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(string.Join(" ", lst));
            Console.ReadKey();
        }
    }
}
