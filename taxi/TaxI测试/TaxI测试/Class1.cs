using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxI测试
{
    internal class Class1
    {
        public static void Taxidata(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string lines;
            while ((lines = sr.ReadLine()) != null)
            {
                Console.WriteLine(lines.ToString());
            }
        }

    }


}
