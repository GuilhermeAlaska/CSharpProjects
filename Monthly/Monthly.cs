using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly
{
    class Monthly
    {
        private decimal salByDay;
        private decimal fareByDay;

        decimal monthSal;
        decimal totalBusFare1;
        decimal totalBusFare2;

        public Monthly(int workDays)
        {
            MonthSal(workDays);
            FirstBus(workDays);
            SecondBus(workDays);
            AllTotal();
        }

        public void MonthSal(int workDays)
        {
            
            salByDay = 50.0m;
            monthSal = (Convert.ToDecimal(workDays) * salByDay);

            Console.WriteLine($"\nMonth sal: R$ {monthSal}. Total work days = {workDays}.");
        }
        public void FirstBus(int workDays)
        {
            
            fareByDay = (4.50m + 4.50m);
            totalBusFare1 = (Convert.ToDecimal(workDays) * fareByDay);
            Console.WriteLine($"First bus: R$ {totalBusFare1}.");
        }
        public void SecondBus(int workDays)
        {
            
            fareByDay = (5.55m + 5.55m);
            totalBusFare2 = (Convert.ToDecimal(workDays) * fareByDay);
            Console.WriteLine($"Second bus fare: R$ {totalBusFare2}.");
        }

        public void AllTotal()
        {
            decimal allTotal = monthSal + totalBusFare1 + totalBusFare2;
            Console.Write($"\nTotal: {allTotal}");
        }


    }
}
