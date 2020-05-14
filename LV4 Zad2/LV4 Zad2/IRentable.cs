using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Zad2
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
