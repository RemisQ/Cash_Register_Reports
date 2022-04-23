using Cash_Register_Reports.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Cash_Register_Reports.DataAccess
{
    public class ZReportRepository
    {
        
        private List<ZReport> zReports { get; }

        public ZReportRepository()
        {
            zReports = new List<ZReport>();

            int id = 1;
            int days;

            for (int i = 1; i <=12; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                { days = 31; }
                else if (i == 2)
                { days = 28; }
                else
                { days = 30; }

                for (int j = 1; j <= days; j++)
                {
                    ReportInfo reportInfo = new ReportInfo(i, j, DateTime.Now);
                    SalesAndTaxes salesAndTaxes = new SalesAndTaxes(1000*i+j, Math.Round((1000*i+j)*0.21m,2), Math.Round((1000*i+j)*0.25m,2), Math.Round((1000*i+j)*0.75m,2));
                    CashOperations cashOperations = new CashOperations(200, -Math.Round((1000*i+j)*0.25m,2), 200, j+10);
                    ZReport dayZReport = new ZReport(id, reportInfo, salesAndTaxes, cashOperations);
                    zReports.Add(dayZReport);

                    id++;
                }
            }
            var pushData = new JsonSerializerOptions { WriteIndented = true };
            var jsonFilename = "zreports2021.json";
            string jsonString = JsonSerializer.Serialize(zReports, pushData);
            var jsonPath = @$"C:\Users\User\source\repos\16-20_Lessons\Cash_Register_Reports\Cash_Register_Reports.DataAccess\{jsonFilename}";
            File.WriteAllText(jsonPath, jsonString);

            var zReportsFile = "zReports.txt";
            var path = @$"C:\Users\User\source\repos\16-20_Lessons\Cash_Register_Reports\Cash_Register_Reports.DataAccess\{zReportsFile}";
            File.WriteAllText(path, jsonString);
        }
        public List<ZReport> Retrieve()
        {
            return zReports;
        }
        public ZReport Retrieve(int number)
        {
            return zReports[number];
        }
        public decimal CountTurnoverOfYear()
        {
            decimal turnoverOfYear = 0;
            for (int i = 0; i < zReports.Count; i++)
            {
                turnoverOfYear += zReports[i].SalesAndTaxes.TurnoverWithVat;
            }
            return turnoverOfYear;
        }
        public decimal CountVatOfYear()
        {
            decimal vatOfYear = 0;
            for (int i = 0; i < zReports.Count; i++)
            {
                vatOfYear += zReports[i].SalesAndTaxes.Vat21;
            }
            return vatOfYear;
        }
        public decimal CountByCardOfYear()
        {
            decimal byCardOfYear = 0;
            for (int i = 0; i < zReports.Count; i++)
            {
                byCardOfYear += zReports[i].SalesAndTaxes.TurnoverByCard;
            }
            return byCardOfYear;
        }
        public decimal CountByCashOfYear()
        {
            decimal byCashOfYear = 0;
            for (int i = 0; i < zReports.Count; i++)
            {
                byCashOfYear += zReports[i].SalesAndTaxes.TurnoverByCash;
            }
            return byCashOfYear;
        }
        public int CountReceiptsOfYear()
        {
            int receiptsOfYear = 0;
            for (int i = 0; i < zReports.Count; i++)
            {
                receiptsOfYear += zReports[i].CashOperations.TotalReceipts;
            }
            return receiptsOfYear;
        }
    }
}
