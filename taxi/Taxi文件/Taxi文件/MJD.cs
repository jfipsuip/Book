using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi文件
{
    class MJD
    {
        /// <summary>
        /// 我把所有变量声明在类里面
        /// </summary>
        public string ID;
        public int zhuangtai;
        public string riQi;
        public double X;
        public double Y;
        public int timezero = 8;
        public double riQi_mjd;
        /// <summary>
        /// 把公历转换成简化儒格日格式
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="hour">时</param>
        /// <param name="min">分</param>
        /// <param name="miao">秒</param>
        /// <param name="timeZone">世界时于北京时的转换中间相差八小时</param>
        /// <returns></returns>
        public static double MJD_jisuan(int year, int month, int day, int hour, int min, int miao, int timeZone)
        {
            double mjd = -678987 + 367.0 * year;
            mjd -= Convert.ToInt32(7.0 / 4.0 * (year + Convert.ToInt32((month + 9.0) / 12.0)));
            mjd += Convert.ToInt32((275.0 * month) / 9.0);
            mjd += day + (hour - timeZone) / 24.0 + min / 1440.0 + miao / 86400.0;
            return mjd;
        }
        /// <summary>
        /// 这个方法就是把每一行进行分割并存在数组中
        /// </summary>
        /// <param name="line">将每一行的数据输入进来</param>
        public void SHUju_jisuan(string line)
        {
            try
            {
                var lines = line.Split(',');
                ID = lines[0];
                zhuangtai = Convert.ToInt32(lines[1]);
                riQi = (lines[2]);
                X = Convert.ToDouble(lines[3]);
                Y = Convert.ToDouble(lines[4]);
            }
            catch
            {

            }
            riQi_fenge();
           
        }
        /// <summary>
        /// 对于所取得的日期的数组进行再次分割，具体到秒
        /// 其中年，月，日，小时，分，秒
        /// </summary>
        public void riQi_fenge()
        {
            try
            {
                int year = Convert.ToInt32(riQi.Substring(0, 4));
                int month = Convert.ToInt32(riQi.Substring(4, 2));
                int day = Convert.ToInt32(riQi.Substring(6, 2));
                int hour = Convert.ToInt32(riQi.Substring(8, 2));
                int min = Convert.ToInt32(riQi.Substring(10, 2));
                int miao = Convert.ToInt32(riQi.Substring(12, 2));
                riQi_mjd = MJD_jisuan(year, month, day, hour, min, miao, timezero);
            }
            catch
            {

            }

           

        }

    }
}
