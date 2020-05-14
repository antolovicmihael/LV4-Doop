using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Zad2
{
    interface IAnalytics
    {

        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
