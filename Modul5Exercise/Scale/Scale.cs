using System;
using System.Collections.Generic;
using System.Text;

namespace Scale
{
    class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T Left { get { return this.left; } private set { this.left = value; } }
        public T Right { get { return this.right; } private set { this.right = value; } }

        public T GetHeavier()
        {
            if (this.left.CompareTo(this.Right) == 0) return default(T);
            if (this.left.CompareTo(this.Right) > 0) return this.left;
            return this.right;

        }
    }
}
