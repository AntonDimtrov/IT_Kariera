using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
    interface IBuyer
    {
        void BuyFood();
        int Food { get; }
        int FoodIncrease { get; }
    }
}
