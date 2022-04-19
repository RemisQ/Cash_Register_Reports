using Cash_Register_Reports.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports
{

    public class DataPrinter
    {
        public ZReportRepository zReportRepository { get; }
        public ZReportsData zReportsData { get; }


        public DataPrinter()
        {
            zReportRepository = new ZReportRepository();
            zReportsData = new ZReportsData();
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
    }
}
