using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCooking
{
    class CookMethod
    {
        private string food;
        private CookStrategy _cookStrategy;

        public void SetCookStrat(CookStrategy cookStrat)
        {
            this._cookStrategy = cookStrat;
        }

        public void SetFoodType(string name)
        {
            food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(food);
            Console.WriteLine();
        }
    }
}
