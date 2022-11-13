using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumbers
{
    class RationalNumber
    {
        private int numerator;
        private int denumerator;

        public RationalNumber(int numerator, int denumerator)
        {
            this.Numerator = numerator;
            this.Denumerator = denumerator;
        }
        public void Rationalize()
        {
            int a = numerator;
            int b = denumerator;
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            numerator /= a;
            denumerator /= a;
            Console.WriteLine(this);
        }
        public int Numerator
        {
            get { return this.numerator; }
            private set { this.numerator = value; }
        }
        public int Denumerator
        {
            get { return this.denumerator; }
            private set
            {
                if (value == 0) throw new ArgumentException("Denumerator CANNOT Be Equal To 0");
                if (value < 0)
                {
                    this.numerator *= -1;
                    value *= -1;
                }
                this.denumerator = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denumerator}";
        }
    }
}
