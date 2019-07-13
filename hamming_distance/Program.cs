using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Check text = new Check();
            Console.WriteLine(text.Distance("!AA10","AAB10"));
            Console.ReadKey();
        }
    }
}
