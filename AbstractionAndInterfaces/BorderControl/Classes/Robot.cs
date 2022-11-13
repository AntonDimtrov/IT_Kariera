using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Interfaces;

namespace BorderControl
{
    class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }

        public string Model { get => model; set => model = value; }
        public string ID { get => id; set => id = value; }
    }
}
