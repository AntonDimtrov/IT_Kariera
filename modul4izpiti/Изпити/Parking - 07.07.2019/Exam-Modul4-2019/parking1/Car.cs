using System;
using System.Collections.Generic;
using System.Text;

namespace parking1
{
    class Car
    {
        private string carNumber;
        private Car next;
        public Car(string carNumber)

        {
            this.CarNumber = carNumber;
            this.Next = null;
        }

        public string CarNumber { get => carNumber; set => carNumber = value; }
        internal Car Next { get => next; set => next = value; }

        public override string ToString()

        {
            return $"Car: {this.CarNumber}";

        }
    }
}
