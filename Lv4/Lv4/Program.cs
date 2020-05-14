using System;
using System.Collections;
using System.Collections.Generic;

namespace Lv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("C:\\Users\\MIHAEL\\Documents\\LV4-Doop\\DoopFIle.csv");
            IAnalytics analyze = new Adapter(new Analyzer3rdParty());
            double[] colmn = analyze.CalculateAveragePerColumn(data);
            double[] row = analyze.CalculateAveragePerRow(data);
        }
    }
}
