using Cash_Register_Reports.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports
{
    public class ZReportsData
    {

        public List<string> RetrieveZReportsDataInStringFormat(List<ZReport> zReportsList)
        {
            List<string> data = new List<string>();

            for (int i = 0; i < zReportsList.Count; i++)
            {
                data.Add($"ID:              {zReportsList[i].Id}");
                data.Add($"Apyvarta su PVM: {zReportsList[i].SalesAndTaxes.TurnoverWithVat}");
                data.Add($"PVM:             {zReportsList[i].SalesAndTaxes.Vat21}");
                data.Add($"Grynaisiais:     {zReportsList[i].SalesAndTaxes.TurnoverByCash}");
                data.Add($"Kortele:         {zReportsList[i].SalesAndTaxes.TurnoverByCard}");
                data.Add($"Įdėjimas:        {zReportsList[i].CashOperations.InsertedCash}");
                data.Add($"Išimta:         {zReportsList[i].CashOperations.CollectedCash}");
                data.Add($"Likutis:         {zReportsList[i].CashOperations.CashBalance}");
                data.Add($"Kvitai:          {zReportsList[i].CashOperations.TotalReceipts}");
                data.Add($"Laikotarpis:     {zReportsList[i].ReportInfo.ReportMonth}-{zReportsList[i].ReportInfo.ReportDay}");
                data.Add($"Atspausdinta:    {zReportsList[i].ReportInfo.PrintedDate}");
                data.Add($"------------------------------------");
                

            }
            return data;
        }
    }
}