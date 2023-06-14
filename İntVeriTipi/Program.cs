using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* İnt Veri Tipi -2.147.483.648 ile 2.147.448.647 arasında değer depolayabilir
            4 byte yer kaplar ram bellekte.

            8 bit = 1 byte 
            1024 byte = 1 KB
            1024 KB = 1 MB 
            1024 MB = 1 GB 
            1024 GB = 1 TB 
            1024 TB = 1 PB
            */

            int birincideğisken = -243532465;
            int ikincideğisken = 325542;
            int MaxDeğer = int.MaxValue;
            int MinDeğer = int.MinValue;
            Console.WriteLine(MaxDeğer);
            Console.WriteLine(MinDeğer);
            Console.ReadLine();
        }
    }
}
