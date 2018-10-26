﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface IBuilder
    {
        void StartUpOperations();

        void BuildBody();

        void InsertWheels();

        void AddHeadLights();

        void EndOperations();

        Product GetVehicle();
    }
}
