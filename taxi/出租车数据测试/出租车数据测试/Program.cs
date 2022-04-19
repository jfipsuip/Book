using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 出租车数据测试
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "T2,0,20170706123247,4406023.008,522527.941 ";
            int Second = Convert.ToInt32(7 / 4 * (7 + 9) / 12);
            int Third = Convert.ToInt32(275 * 7 / 9);
            double Forth = 06 + 12 / 24 + 32 / 1440 + 47 / 96400;
            double MjD = -678987 + 367 * 2017 - Second - Third + Forth;
            double number1 = Math.Sqrt( (4404760.859 - 522527.941) * (4404760.859 - 522527.941) + (522966.967 - 4406023.008) * (522966.967 - 4406023.008));
            double numer2 = number1 / MjD;
            Console.WriteLine(numer2);
            Console.ReadKey();


        }
    }
}
