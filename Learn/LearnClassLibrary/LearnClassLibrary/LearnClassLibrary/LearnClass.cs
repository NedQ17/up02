using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;
        }

        public decimal Discount(decimal c, decimal d)
        {
            return c - ((d / 100) * c);
        }
    }
}