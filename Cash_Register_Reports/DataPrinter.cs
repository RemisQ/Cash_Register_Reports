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
        public void PrintByIdZReport()
        {
            List<string> zReportsDataList = zReportsData.RetrieveZReportByIdDataInStringFormat(zReportRepository.Retrieve());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Generated Z report by ID:");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < zReportsDataList.Count; i++)
            {
                Console.WriteLine(zReportsDataList[i]);
            }

        }
        public void PrintResultsOfYear()
        {
            ZReportRepository zReportRepository = new ZReportRepository();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Results of 2021:");
            Console.WriteLine("------------------------------------");
            var turnover2021 = zReportRepository.CountTurnoverOfYear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Metinė apyvarta: {turnover2021} eurų");
            var vat2021 = zReportRepository.CountVatOfYear();
            Console.WriteLine($"Metinis PVM: {vat2021} eurų");
            var card2021 = zReportRepository.CountByCardOfYear();
            Console.WriteLine($"Atsiskaitymai kortele: {card2021} eurų");
            var cash2021 = zReportRepository.CountByCashOfYear();
            Console.WriteLine($"Atsiskaitymai grynais: {cash2021} eurų");
            var receipts2021 = zReportRepository.CountReceiptsOfYear();
            Console.WriteLine($"Viso kvitų: {receipts2021}");
            Console.WriteLine("------------------------------------");
        }
    }
}
