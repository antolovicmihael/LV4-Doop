using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Zad2
{
    class Book : IRentable
    {
        private readonly double BaseBookPrice = 20.00;
        public String Name { get; private set; }
        public Book(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseBookPrice; }
    }
}
