using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShortVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short birinciDeğisken = -50;
            short ikinciDeğisken = 25467;
            short ucuncuDeğisken = 32000;
            Console.WriteLine(birinciDeğisken);
            Console.WriteLine(ikinciDeğisken);
            Console.WriteLine(ucuncuDeğisken);
            short MaxDeğer = short.MaxValue;
            short MinDeğer = short.MinValue;
            Console.WriteLine(MaxDeğer);
            Console.WriteLine(MinDeğer);
            Console.ReadLine();
        }


    }
}
