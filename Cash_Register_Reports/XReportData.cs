using Cash_Register_Reports.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports
{
    public class XReportData
    {
        public List<string> RetrieveXReportDataInStringFormat(List<XReport> xReportList)
        {
            List<string> dataX = new List<string>();

            for (int i = 0; i < xReportList.Count; i++)
            {
                dataX.Add($"Apyvarta su PVM: {xReportList[i].SalesAndTaxes.TurnoverWithVat}");
                dataX.Add($"PVM:             {xReportList[i].SalesAndTaxes.Vat21}");
                dataX.Add($"Grynaisiais:     {xReportList[i].SalesAndTaxes.TurnoverByCash}");
                dataX.Add($"Kortele:         {xReportList[i].SalesAndTaxes.TurnoverByCard}");
                dataX.Add($"Įdėjimas:        {xReportList[i].CashOperations.InsertedCash}");
                dataX.Add($"Išimta:         {xReportList[i].CashOperations.CollectedCash}");
                dataX.Add($"Likutis:         {xReportList[i].CashOperations.CashBalance}");
                dataX.Add($"Kvitai:          {xReportList[i].CashOperations.TotalReceipts}");
                dataX.Add($"Laikotarpis:     {xReportList[i].ReportInfo.ReportMonth}-{xReportList[i].ReportInfo.ReportDay}");
                dataX.Add($"Atspausdinta:    {xReportList[i].ReportInfo.PrintedDate}");
                dataX.Add($"------------------------------------");

            }
            return dataX;
        }
    }
}
