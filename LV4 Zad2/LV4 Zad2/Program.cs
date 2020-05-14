using System;
using System.Collections;
using System.Collections.Generic;

namespace LV4_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("C:\\Users\\MIHAEL\\Documents\\LV4-Doop\\DoopFIle.csv");
            IAnalytics analyze = new Adapter(new Analyzer3rdParty());
            double[] colmn = analyze.CalculateAveragePerColumn(data);
            double[] row = analyze.CalculateAveragePerRow(data);
            List<IRentable> RentableList = new List<IRentable>();
            RentableList.Add(new Book("Harry Potter"));
            RentableList.Add(new Video("Baby Laugh"));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(RentableList);
        }
    }
}
