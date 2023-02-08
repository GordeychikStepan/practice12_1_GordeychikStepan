using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_work
{
    internal class Student
    {
        public string name;
        public int rost;
        private double ves = 50;

        public double GetEat()
        {
            return ves;
        }
        public void SetEat(double eda)
        {
            if (eda > 5 && eda < 10)
            {
                rost--;
                ves += 0.7 * (eda * 1000 - 1600) / 1000;
            }
            else if (eda >= 10)
            {
                rost -= 2;
                ves += 0.5 * (eda * 1000 - 1800) / 1000;
            }
            else
                ves += eda;
        }
    }
}