using Cash_Register_Reports;
using Cash_Register_Reports.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestZReport
{
    [TestClass]
    public class ZReportsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ZReportsData zReportsData = new ZReportsData();
     
            
            ZReportRepository zReportRepository = new ZReportRepository();
            int id = zReportRepository.Retrieve(4).Id;
        }
    }
}
