using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl
{
    interface IBirthable : IInhabitant
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
