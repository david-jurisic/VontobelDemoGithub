using NUnit.Framework;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kShared;
using static VontobelDemo.Map.UI.VontobelDemoUIMap;

namespace VontobelDemo.TestBook.StepDefinitions.UI
{
    [RAFtestCase("Locate Product by ISIN", "TC003", TestType.UI, "Maja Čanaki")]
    public class TC003_LocateProductByISIN : UITestCase
    {
        [Test]
        public void LocateProductByISIN()
        {
            NewStep(1, "Call Products Search. Make POST request to api/v1/products/search?c=en-no&it=1");

            NewStep(2, "Open \"https://markets.vontobel.com\" page.");
            VontobelMarkets.Init();
            Success = VontobelMarkets.Home.page.Navigate();
            Success = VontobelMarkets.Home.page.VerifyDisplayed();

            Success = VontobelMarkets.Home.InitialBanner.wrpModal.Displayed();

            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Enabled();

            NewStep(3, "Click on \"Accept Conditions and Decline Cookies\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Click();

            NewStep(4, "Enter \"ISIN\" value into \"Search\" textbox.");

            NewStep(5, "Click on first result in \"Search\" wrapper.");
        }
    }
}
