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
            ZReportRepository zReportRepository = new ZReportRepository();
            var id = zReportRepository.Retrieve(4).Id;

            var expected = 5;

            Assert.AreEqual(expected, id);
        }
    }
}
