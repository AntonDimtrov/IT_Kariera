using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{
    class RandomList : ArrayList
    {
        public int count=0;
        Random r = new Random();
        public string RandomString()
        {
            if (base.Count == 0) { return "List is Empty!"; }
            int index = r.Next(0, base.Count);
            var data = base[index].ToString();
            base.RemoveAt(index);
            return data;
            
        }

    }
}
