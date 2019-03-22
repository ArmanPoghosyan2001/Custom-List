using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _List
{
    class Program
    {
        static void Main(string[] args)
        {
            _List<int> list = new _List<int>();
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);
            list.Add(80);
            list.Add(90);
            list.Add(560);
            list.Add(40);

            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }

                      
            Console.ReadKey();
        }
    }
}
