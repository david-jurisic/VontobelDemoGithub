using NUnit.Framework;
using RAF3kGUItesting;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kShared;
using static VontobelDemo.Map.UI.VontobelDemoUIMap;

namespace VontobelDemo.Testbook
{
    [RAFtestCase("Google Test", "TC001", TestType.UI, "David Jurišić")]
    public class TC001_GoogleTest : UITestCase
    {
        [Test]
        public void GoogleTest()
        {
            NewStep(1, "ActionLane0");
            Search.GoogleInit();
            Success = Search.google.Navigate();
            Success = Search.btnCookies.Displayed(true);
            Success = Search.btnCookies.Enabled(true, 1);
        }
    }
}