using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongVeriTİpi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long veri tipi -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 arasında değer depolayabilmektedir
            // 8 byte yer kaplar ram bellekte 
            long birincideğisken = 2558462681658; 
            long MaxDeğer = long.MaxValue;
            long MinDeğer = long.MinValue;
            Console.WriteLine(MaxDeğer);
            Console.WriteLine(MinDeğer);
            Console.ReadLine();
        }
    }
}
