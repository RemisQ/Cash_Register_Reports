using Cash_Register_Reports.DataAccess;
using System;

namespace Cash_Register_Reports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataPrinter dataPrinter = new DataPrinter();
            dataPrinter.PrintAllZReports();
        }
    }
}
