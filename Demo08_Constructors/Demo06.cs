using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo06
{
    class Demo
    {
        public static void Run()
        {
            MyDate date1 = new MyDate();
            MyDate date2 = new MyDate(20);
            MyDate date3 = new MyDate(20, 4);
            MyDate date4 = new MyDate(20, 4, 2020);

            date1.DisplayInfo();
            date2.DisplayInfo();
            date3.DisplayInfo();
            date4.DisplayInfo();
        }
    }


    class MyDate
    {
        private int _day;
        private int _month;
        private int _year;

        public MyDate() : this(1, 1, 1970)
        {
            //_day = 1;
            //_month = 1;
            //_year = 1970;
        }

        public MyDate(int day) : this(day, 1)
        {
            //_day = day;
            //_month = 1;
            //_year = 1970;
        }

        public MyDate(int day, int month) : this(day, month, 1970)
        {
            //_day = day;
            //_month = month;
            //_year = 1970;
        }

        public MyDate(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("{0} - {1} - {2}", _day, _month, _year);
        }
    }

}
