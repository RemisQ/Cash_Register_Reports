using Cash_Register_Reports.Business;
using Cash_Register_Reports.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cash_Register_Reports
{

    public class DataPrinter
    {
        public ZReportRepository zReportRepository { get; }
        public ZReportsData zReportsData { get; }
        public XReportRepository xReportRepository { get; }
        public XReportData xReportData { get; }

        public List<string> zReportsDataList { get; }


        public DataPrinter()
        {
            zReportRepository = new ZReportRepository();
            zReportsData = new ZReportsData();
            xReportRepository = new XReportRepository();
            xReportData = new XReportData();
        }

        public void PrintAllZReports()
        {
            List<string> zReportsDataList = zReportsData.RetrieveZReportsDataInStringFormat(zReportRepository.Retrieve());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Generated Z reports:");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < zReportsDataList.Count; i++)
            {
                Console.WriteLine(zReportsDataList[i]);
            }

        }
        public void PrintXReport()
        {
            List<string> xReportDataList = xReportData.RetrieveXReportDataInStringFormat(xReportRepository.Retrieve());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Generated X report:");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < xReportDataList.Count; i++)
            {
                Console.WriteLine(xReportDataList[i]);
            }
        }
    }
}
