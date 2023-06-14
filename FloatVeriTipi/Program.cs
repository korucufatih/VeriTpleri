using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float ondalikli_sayi1 = 35.56; hatalı kullanım 
            // float ondalikli_sayi1 = 35.56f; doğru kullanım 
            float ondalikli_sayi1 = 35.56f;
            float ondalikli_sayi2 = 12.7f;
            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);
            float maxdeğer = float.MaxValue;
            Console.WriteLine(maxdeğer);
            Console.ReadLine();
        }
    }
}
