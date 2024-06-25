using NUnit.Framework;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kShared;
using static VontobelDemo.Map.UI.VontobelDemoUIMap;

namespace VontobelDemo.TestBook.StepDefinitions.UI
{
    [RAFtestCase("Initial Banner", "TC001", TestType.UI, "Maja Čanaki")]
    public class TC001_InitialBanner : UITestCase
    {
        [Test]
        public void InitialBanner()
        {
            NewStep(1, "Open \"https://markets.vontobel.com\" page.");
            VontobelMarkets.Init();
            Success = VontobelMarkets.Home.page.Navigate();
            Success = VontobelMarkets.Home.page.VerifyDisplayed();

            Success = VontobelMarkets.Home.InitialBanner.wrpModal.Displayed();

            Success = VontobelMarkets.Home.InitialBanner.ddCountry.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.ddCountry.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.ddCountry.VerifySelectedText("Norway");

            Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.ddLanguage.VerifySelectedText("English");

            Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.VerifySelectedText("Private");

            Success = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.Displayed();
            List<string> lTermsAndConditionsOfUseText = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.GetText();

            if (lTermsAndConditionsOfUseText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.wrpPrivacyAndCookies.Displayed();
            List<string> lPrivacyAndCookiesText = VontobelMarkets.Home.InitialBanner.wrpPrivacyAndCookies.GetText();

            if (lPrivacyAndCookiesText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.VerifyText("Accept Conditions and Cookies");

            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Enabled();

            NewStep(2, "Click on \"Country\" dropdown.");
            Success = VontobelMarkets.Home.InitialBanner.ddCountry.Click();

            Success = VontobelMarkets.Home.InitialBanner.lCountry.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lCountry.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Czech Republic");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Denmark");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Finland");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("France");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Germany");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Hong Kong");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Hungary");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Italy");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Netherlands");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Norway");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Sweden");
            Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists("Switzerland");

            NewStep(3, "Click on \"Language\" dropdown.");
            Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Click();

            Success = VontobelMarkets.Home.InitialBanner.lLanguage.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lLanguage.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.lLanguage.VerifyListItemExists("English");
            Success = VontobelMarkets.Home.InitialBanner.lLanguage.VerifyListItemExists("Norwegian Bokmål");

            NewStep(4, "Click on \"Investor Profile\" dropdown.");
            Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Click();

            Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.Enabled();
            Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.VerifyListItemExists("Private");
            Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.VerifyListItemExists("Professional");

            NewStep(5, "Click on \"Read more\" link.");
            Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Click();

            List<string> lTermsAndConditionsOfUseTextExpanded = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.GetText();

            if (lTermsAndConditionsOfUseTextExpanded.Count <= lTermsAndConditionsOfUseText.Count)
                throw new Exception(String.Format("Wrapper is not expanded."));

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelProspectus.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelProspectus.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelPrivacyPolicy.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelPrivacyPolicy.Enabled();

            NewStep(6, "Click on \"Privacy Policy\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Click();

            Success = VontobelMarkets.Home.InitialBanner.wrpPrivacyPolicy.Displayed();
            List<string> lPrivacyPolicyText = VontobelMarkets.Home.InitialBanner.wrpPrivacyPolicy.GetText();

            if (lPrivacyPolicyText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            Success = VontobelMarkets.Home.InitialBanner.lnkTermsAndConditionsOfUseCookiePolicy.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkTermsAndConditionsOfUseCookiePolicy.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkCookiePolicy.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkCookiePolicy.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelsSocialMediaTermsOfUse.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelsSocialMediaTermsOfUse.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelGroup.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelGroup.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoCh.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoCh.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoDe.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoDe.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkDpoVontobelGroup.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkDpoVontobelGroup.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelMifid.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.lnkVontobelMifid.Enabled();

            NewStep(7, "Click on \"Cookie Settings\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Click();

            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.VerifyText("Accept Conditions and Cookie preferences");

            Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyDisabled(true);
            Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyToggled(true);

            Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyDisabled(false);
            Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyToggled(false);

            Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyDisabled(false);
            Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyToggled(false);

            Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Enabled();

            Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyDisabled(false);
            Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyToggled(false);

            Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Displayed();
            Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Enabled();

            NewStep(8, "Click on \"Functional Cookies\"  button.");
            Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Click();

            Success = VontobelMarkets.Home.InitialBanner.wrpFunctionalCookies.Displayed();
            List<string> lFunctionalCookiesText = VontobelMarkets.Home.InitialBanner.wrpFunctionalCookies.GetText();

            if (lFunctionalCookiesText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            NewStep(9, "Click on \"Analytics Cookies\" toggle button.");
            Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.Click();
            Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyToggled(true);

            NewStep(10, "Click on \"Analytics Cookies\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Click();

            Success = VontobelMarkets.Home.InitialBanner.wrpAnalyticsCookies.Displayed();
            List<string> lAnalyticsCookiesText = VontobelMarkets.Home.InitialBanner.wrpAnalyticsCookies.GetText();

            if (lAnalyticsCookiesText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            NewStep(11, "Click on \"Marketing Cookies\" toggle button.");
            Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.Click();
            Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyToggled(true);

            NewStep(12, "Click on \"Marketing Cookies\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Click();

            Success = VontobelMarkets.Home.InitialBanner.wrpMarketingCookies.Displayed();
            List<string> lMarketingCookiesText = VontobelMarkets.Home.InitialBanner.wrpMarketingCookies.GetText();

            if (lMarketingCookiesText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));

            NewStep(13, "Click on \"Performance & Tracking Cookies\" toggle button.");
            Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.Click();
            Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyToggled(true);

            Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.VerifyText("Accept Conditions and Cookies");

            NewStep(14, "Click on \"Performance & Tracking Cookies\" button.");
            Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Click();

            Success = VontobelMarkets.Home.InitialBanner.wrpPerformanceAndTrackingCookies.Displayed();
            List<string> lPerformanceAndTrackingCookiesText = VontobelMarkets.Home.InitialBanner.wrpPerformanceAndTrackingCookies.GetText();

            if (lPerformanceAndTrackingCookiesText.Count <= 0)
                throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
        }
    }
}
