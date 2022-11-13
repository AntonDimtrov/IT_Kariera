using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl
{
    interface IIdentifiable : IInhabitant
    {
        public string ID { get; set; }
    }
}
