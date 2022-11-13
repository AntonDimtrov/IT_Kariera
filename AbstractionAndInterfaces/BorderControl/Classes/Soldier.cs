using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    static class Soldier
    {

        public static bool CheckIDIsFake(string id, string fakeIDEnding)
        {
            if (id.Substring(id.Length-fakeIDEnding.Length) == fakeIDEnding) return true;
            return false;
        }
    }
}
