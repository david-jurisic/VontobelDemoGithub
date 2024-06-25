using RAF3kGUItesting;
using TechTalk.SpecFlow;
using VontobelDemo.Helpers;
using static VontobelDemo.Map.UI.VontobelDemoUIMap;

namespace VontobelDemo.TestBook.BDD.UI.Glue
{
    [Binding]
    public class UISteps
    {
        List<string>? lTermsAndConditionsOfUseText;

        [Given(@"I navigate to the ""([^""]*)"" page")]
        public void GivenINavigateToThePage(string sPage)
        {
            switch (sPage)
            {
                case "Vontobel Markets":
                    VontobelMarkets.Init();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.page.Navigate();
                    break;
                default:
                    throw new Exception("Page with provided name not found.");
            }
        }

        [When(@"the ""([^""]*)"" modal is displayed")]
        public void WhenTheModalIsDisplayed(string sModal)
        {
            switch (sModal)
            {
                case "Initial Banner":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.page.VerifyDisplayed();

                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpModal.Displayed();
                    break;
                default:
                    throw new Exception("Modal with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" dropdown which is enabled and contains a default value")]
        public void ThenIShouldSeeTheDropdownWhichIsEnabledAndContainsADefaultValue(string sDropdown)
        {
            switch (sDropdown)
            {
                case "Country":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddCountry.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddCountry.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddCountry.VerifySelectedText("Norway");
                    break;
                case "Language":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddLanguage.VerifySelectedText("English");
                    break;
                case "Investor Profile":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.VerifySelectedText("Private");
                    break;
                default:
                    throw new Exception("Dropdown with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" wrapper which is not empty")]
        public void ThenIShouldSeeTheWrapperWhichIsNotEmpty(string sWrapper)
        {
            switch (sWrapper)
            {
                case "Terms and Conditions of Use":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.Displayed();
                    lTermsAndConditionsOfUseText = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.GetText();

                    if (lTermsAndConditionsOfUseText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Privacy and Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpPrivacyAndCookies.Displayed();
                    List<string> lPrivacyAndCookiesText = VontobelMarkets.Home.InitialBanner.wrpPrivacyAndCookies.GetText();

                    if (lPrivacyAndCookiesText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Privacy Policy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpPrivacyPolicy.Displayed();
                    List<string> lPrivacyPolicyText = VontobelMarkets.Home.InitialBanner.wrpPrivacyPolicy.GetText();

                    if (lPrivacyPolicyText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Functional Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpFunctionalCookies.Displayed();
                    List<string> lFunctionalCookiesText = VontobelMarkets.Home.InitialBanner.wrpFunctionalCookies.GetText();

                    if (lFunctionalCookiesText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpAnalyticsCookies.Displayed();
                    List<string> lAnalyticsCookiesText = VontobelMarkets.Home.InitialBanner.wrpAnalyticsCookies.GetText();

                    if (lAnalyticsCookiesText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpMarketingCookies.Displayed();
                    List<string> lMarketingCookiesText = VontobelMarkets.Home.InitialBanner.wrpMarketingCookies.GetText();

                    if (lMarketingCookiesText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.wrpPerformanceAndTrackingCookies.Displayed();
                    List<string> lPerformanceAndTrackingCookiesText = VontobelMarkets.Home.InitialBanner.wrpPerformanceAndTrackingCookies.GetText();

                    if (lPerformanceAndTrackingCookiesText.Count <= 0)
                        throw new Exception(String.Format("Wrapper is empty, but not empty is expected."));
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" link which is enabled")]
        public void ThenIShouldSeeTheLinkWhichIsEnabled(string sLink)
        {
            switch (sLink)
            {
                case "Read more":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Enabled();
                    break;
                case "https://prospectus.vontobel.com":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelProspectus.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelProspectus.Enabled();
                    break;
                case "https://www.vontobel.com/privacypolicy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelPrivacyPolicy.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelPrivacyPolicy.Enabled();
                    break;
                case "Terms and Conditions of Use, Cookie Policy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkTermsAndConditionsOfUseCookiePolicy.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkTermsAndConditionsOfUseCookiePolicy.Enabled();
                    break;
                case "Cookie Policy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkCookiePolicy.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkCookiePolicy.Enabled();
                    break;
                case "Vontobel's Social Media Terms of Use":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelsSocialMediaTermsOfUse.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelsSocialMediaTermsOfUse.Enabled();
                    break;
                case "vontobelgroup@vontobel.com":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelGroup.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelGroup.Enabled();
                    break;
                case "dpo.ch@vontobel.com":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoCh.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoCh.Enabled();
                    break;
                case "dpo.de@vontobel.com":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoDe.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelDpoDe.Enabled();
                    break;
                case "dpo.vontobelgroup@vontobel.com":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkDpoVontobelGroup.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkDpoVontobelGroup.Enabled();
                    break;
                case "www.vontobel.com/mifid":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelMifid.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkVontobelMifid.Enabled();
                    break;
                default:
                    throw new Exception("Link with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" button which is enabled")]
        public void ThenIShouldSeeTheButtonWhichIsEnabled(string sButton)
        {
            switch (sButton)
            {
                case "Privacy Policy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Enabled();
                    break;
                case "Cookie Settings":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Enabled();
                    break;
                case "Accept Conditions and Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.Enabled();
                    break;
                case "Accept Conditions and Decline Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndDeclineCookies.Enabled();
                    break;
                case "Functional Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Enabled();
                    break;
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Enabled();
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Enabled();
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Enabled();
                    break;
                default:
                    throw new Exception("Button with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" button which contains text ""([^""]*)""")]
        public void ThenIShouldSeeTheButtonWhichContainsText(string sButton, string sText)
        {
            switch (sButton)
            {
                case "Accept Conditions and Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAcceptConditionsAndCookies.VerifyText(sText);
                    break;
                case "Isin":
                    UIReferences.UITestCase.Success = VontobelMarkets.Products.btnIsin.VerifyText(sText);
                    break;
                default:
                    throw new Exception("Button with provided name not found.");
            }
        }

        [When(@"I click on the ""([^""]*)"" dropdown")]
        public void WhenIClickOnTheDropdown(string sDropdown)
        {
            switch (sDropdown)
            {
                case "Country":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddCountry.Click();
                    break;
                case "Language":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddLanguage.Click();
                    break;
                case "Investor Profile":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.ddInvestorProfile.Click();
                    break;
                default:
                    throw new Exception("Dropdown with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" dropdown menu which is enabled and contains values")]
        public void ThenIShouldSeeTheDropdownMenuWhichIsEnabledAndContainsValues(string sDropdown, Table tblContent)
        {
            List<string> lContent = TableHelpers.ToList(tblContent);

            switch (sDropdown)
            {
                case "Country":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.Enabled();

                    foreach (string value in lContent)
                    {
                        UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.VerifyListItemExists(value);
                    }
                    break;
                case "Language":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.Enabled();

                    foreach (string value in lContent)
                    {
                        string valueFixed = value;

                        if (valueFixed.Contains("Norwegian Bokm"))
                            valueFixed = "Norwegian Bokmål";

                        UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.VerifyListItemExists(valueFixed);
                    }
                    break;
                case "Investor Profile":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.Enabled();

                    foreach (string value in lContent)
                    {
                        UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lInvestorProfile.VerifyListItemExists(value);
                    }
                    break;
                default:
                    throw new Exception("Dropdown menu with provided name not found.");
            }
        }

        [When(@"I click on the ""([^""]*)"" link")]
        public void WhenIClickOnTheLink(string sLink)
        {
            switch (sLink)
            {
                case "Read more":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lnkReadMore.Click();
                    break;
                default:
                    throw new Exception("Link with provided name not found.");
            }
        }
        [When(@"I Select ""(.*)"" from ""([^""]*)"" dropdown")]
        public void WhenISelectDenmarkFromDropdown(string ListItem, string sDropdown)
        {
            switch (sDropdown)
            {
                case "Country":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lCountry.SelectOptionInList(ListItem);
                    break;
                case "Language":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.lLanguage.SelectOptionInList(ListItem);
                    break;

                default:
                    throw new Exception("Dropdown menu with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" wrapper which is expanded")]
        public void ThenIShouldSeeTheWrapperWhichIsExpanded(string sWrapper)
        {
            switch (sWrapper)
            {
                case "Terms and Conditions of Use":
                    List<string> lTermsAndConditionsOfUseTextExpanded = VontobelMarkets.Home.InitialBanner.wrpTermsAndConditionsOfUse.GetText();

                    if (lTermsAndConditionsOfUseTextExpanded.Count <= lTermsAndConditionsOfUseText.Count)
                        throw new Exception(String.Format("Wrapper is not expanded."));
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [When(@"I click on the ""([^""]*)"" button")]
        public void WhenIClickOnTheButton(string sButton)
        {
            switch (sButton)
            {
                case "Privacy Policy":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPrivacyPolicy.Click();
                    break;
                case "Cookie Settings":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnCookieSettings.Click();
                    break;
                case "Functional Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnFunctionalCookies.Click();
                    break;
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnAnalyticsCookies.Click();
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnMarketingCookies.Click();
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.btnPerformanceAndTrackingCookies.Click();
                    break;
                default:
                    throw new Exception("Button with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" toggle button which is disabled and toggled")]
        public void ThenIShouldSeeTheToggleButtonWhichIsDisabledAndToggled(string sToggleButton)
        {
            switch (sToggleButton)
            {
                case "Functional Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyDisabled(true);
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyToggled(true);
                    break;
                default:
                    throw new Exception("Toggle button with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" toggle button which is enabled and not toggled")]
        public void ThenIShouldSeeTheToggleButtonWhichIsEnabledAndNotToggled(string sToggleButton)
        {
            switch (sToggleButton)
            {
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyDisabled(false);
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyToggled(false);
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyDisabled(false);
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyToggled(false);
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyDisabled(false);
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyToggled(false);
                    break;
                default:
                    throw new Exception("Toggle button with provided name not found.");
            }
        }

        [When(@"I click on the ""([^""]*)"" toggle button")]
        public void WhenIClickOnTheToggleButton(string sToggleButton)
        {
            switch (sToggleButton)
            {
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.Click();
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.Click();
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.Click();
                    break;
                default:
                    throw new Exception("Toggle button with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" toggle button which is toggled")]
        public void ThenIShouldSeeTheToggleButtonWhichIsToggled(string sToggleButton)
        {
            switch (sToggleButton)
            {
                case "Analytics Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbAnalyticsCookies.VerifyToggled(true);
                    break;
                case "Marketing Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbMarketingCookies.VerifyToggled(true);
                    break;
                case "Performance & Tracking Cookies":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbPerformanceAndTrackingCookies.VerifyToggled(true);
                    break;
                default:
                    throw new Exception("Toggle button with provided name not found.");
            }
        }

        [Then(@"I should see ""([^""]*)"" textbox which is enabled and not empty")]
        public void ThenIShouldSeeTextboxWhichIsEnabledAndEmpty(string sTextbox)
        {
            switch (sTextbox)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.txtSearch.Enabled();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.txtSearch.VerifyEmpty(false);
                    break;
                default:
                    throw new Exception("Textbox with provided name not found.");
            }
        }

        [When(@"I enter ""([^""]*)"" value into ""([^""]*)"" textbox")]
        public void WhenIEnterValueIntoTextbox(string sValue, string sTextbox)
        {
            // how to set sValue to ISIN grabbed from API?

            switch (sTextbox)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.txtSearch.SetText(sValue);
                    break;
                default:
                    throw new Exception("Textbox with provided name not found.");
            }
        }

        [Then(@"""([^""]*)"" textbox should contain ""([^""]*)"" value")]
        public void ThenTextboxShouldContainValue(string sTextbox, string sValue)
        {
            // how to set sValue to ISIN grabbed from API?

            switch (sTextbox)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.txtSearch.VerifyText(sValue);
                    break;
                default:
                    throw new Exception("Textbox with provided name not found.");
            }
        }

        [Then(@"I should see ""([^""]*)"" wrapper")]
        public void ThenIShouldSeeWrapper(string sWrapper)
        {
            switch (sWrapper)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.wrpSearch.Displayed();
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [Then(@"I should see first result in ""([^""]*)"" wrapper")]
        public void ThenIShouldSeeFirstResultInWrapper(string sWrapper)
        {
            switch (sWrapper)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.wrpFirstResult.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.wrpFirstResult.Enabled();
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [When(@"I click on first result in ""([^""]*)"" wrapper")]
        public void WhenIClickOnFirstResultInWrapper(string sWrapper)
        {
            switch (sWrapper)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.wrpFirstResult.Click();
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [Then(@"I should see ""([^""]*)"" page")]
        public void ThenIShouldSeePage(string sPage)
        {
            switch (sPage)
            {
                case "Vontobel Markets":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.page.Displayed();
                    break;
                case "Products":
                    UIReferences.UITestCase.Success = VontobelMarkets.Products.page.Displayed();
                    break;
                default:
                    throw new Exception("Page with provided name not found.");
            }
        }

        [Then(@"I should see the ""([^""]*)"" wrapper which is enabled")]
        public void ThenIShouldSeeTheWrapperWhichIsEnabled(string sWrapper)
        {
            switch (sWrapper)
            {
                case "isin":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.wrpSearch.Displayed();
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

        [Then(@"""([^""]*)"" wrapper should contain ""([^""]*)"" value")]
        public void ThenWrapperShouldContainValue(string sWrapper, string sValue)
        {
            switch (sWrapper)
            {
                case "search":
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.Displayed();
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyDisabled(true);
                    UIReferences.UITestCase.Success = VontobelMarkets.Home.InitialBanner.tbFunctionalCookies.VerifyToggled(true);
                    break;
                default:
                    throw new Exception("Wrapper with provided name not found.");
            }
        }

    }
}
