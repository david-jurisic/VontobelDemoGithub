using OpenQA.Selenium;
using RAF3kGUItesting;
using System.Net.Http.Headers;
using VontobelDemo.ExtendedTypes.UI;
using VontobelDemo.Types;

namespace VontobelDemo.Map.UI
{
    public static class VontobelDemoUIMap
    {
        public static class Search
        {
            public static void GoogleInit()
            {
                UIReferences.CurrentPageContext = "https://www.google.com";
            }

            public static WbPageEx google = new WbPageEx("", "google");
            public static WbWrapperEx btnCookies = new WbWrapperEx(By.Id("L2AGLb"), "btnCookies");
            public static WbEditEx txtSearch = new WbEditEx(By.Name("q"), "txtSearch");
        }

        public static class VontobelMarkets
        {
            public static void Init()
            {
                UIReferences.CurrentPageContext = "https://markets.vontobel.com/";
            }

            public static class Home
            {
                public static WbPageEx page = new WbPageEx("en-no", "Page");

                public static WbEditEx txtSearch = new WbEditEx(By.Id("//*[@id=\'__next\']/div/header/div[2]/div/form/label/input"), "txtSearch");
                public static WbWrapperEx wrpSearch = new WbWrapperEx(By.XPath("//*[@id=\'__next\']/div/header/div[2]/div/div/div"), "wrpSearch");
                public static WbWrapperEx wrpFirstResult = new WbWrapperEx(By.XPath("//*[@id=\'__next\']/div/header/div[2]/div/div/ul/li[1]/a"), "wrpFirstResult");

                public static class InitialBanner
                {
                    public static WbWrapperEx wrpModal = new WbWrapperEx(By.Id("headlessui-portal-root"), "wrpModal");

                    public static WbDropDownEx ddCountry = new WbDropDownEx(By.Id("headlessui-listbox-button-7"), "ddCountry");
                    public static WbListEx lCountry = new WbListEx(By.Id("headlessui-listbox-options-8"), "lCountry");

                    public static WbDropDownEx ddLanguage = new WbDropDownEx(By.Id("headlessui-listbox-button-22"), "ddLanguage");
                    public static WbListEx lLanguage = new WbListEx(By.Id("headlessui-listbox-options-23"), "lLanguage");

                    public static WbDropDownEx ddInvestorProfile = new WbDropDownEx(By.Id("headlessui-listbox-button-27"), "ddInvestorProfile");
                    public static WbListEx lInvestorProfile = new WbListEx(By.Id("headlessui-listbox-options-28"), "lInvestorProfile");

                    public static WbWrapperEx wrpTermsAndConditionsOfUse = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[1]/div/div[1]"), "wrpTermsAndConditionsOfUse");
                    public static WbLinkEx lnkVontobelProspectus = new WbLinkEx(By.LinkText("https://prospectus.vontobel.com"), "lnkVontobelProspectus");
                    public static WbLinkEx lnkVontobelPrivacyPolicy = new WbLinkEx(By.LinkText("https://www.vontobel.com/privacypolicy"), "lnkVontobelPrivacyPolicy");
                    public static WbLinkEx lnkReadMore = new WbLinkEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[1]/div/div[2]/span"), "lnkReadMore");

                    public static WbWrapperEx wrpPrivacyAndCookies = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[1]"), "wrpPrivacyAndCookies");

                    public static WbButtonEx btnPrivacyPolicy = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[2]/button"), "btnPrivacyPolicy");
                    public static WbWrapperEx wrpPrivacyPolicy = new WbWrapperEx(By.ClassName("Collapse_panel__hHIaB"), "wrpPrivacyPolicy");
                    public static WbLinkEx lnkTermsAndConditionsOfUseCookiePolicy = new WbLinkEx(By.LinkText("Terms and Conditions of Use, Cookie Policy"), "lnkTermsAndConditionsOfUseCookiePolicy");
                    public static WbLinkEx lnkCookiePolicy = new WbLinkEx(By.LinkText("Cookie Policy"), "lnkCookiePolicy");
                    public static WbLinkEx lnkVontobelsSocialMediaTermsOfUse = new WbLinkEx(By.LinkText("Vontobel’s Social Media Terms of Use"), "lnkVontobelsSocialMediaTermsOfUse");
                    public static WbLinkEx lnkVontobelGroup = new WbLinkEx(By.LinkText("vontobelgroup@vontobel.com"), "lnkVontobelGroup");
                    public static WbLinkEx lnkVontobelDpoCh = new WbLinkEx(By.LinkText("dpo.ch@vontobel.com"), "lnkVontobelDpoCh");
                    public static WbLinkEx lnkVontobelDpoDe = new WbLinkEx(By.LinkText("dpo.de@vontobel.com"), "lnkVontobelDpoDe");
                    public static WbLinkEx lnkDpoVontobelGroup = new WbLinkEx(By.LinkText("dpo.vontobelgroup@vontobel.com"), "lnkDpoVontobelGroup");
                    public static WbLinkEx lnkVontobelMifid = new WbLinkEx(By.LinkText("www.vontobel.com/mifid"), "lnkVontobelMifid");

                    public static WbButtonEx btnCookieSettings = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/button"), "btnCookieSettings");

                    public static WbToggleButton tbFunctionalCookies = new WbToggleButton(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[1]/button/span[1]/button"), "tbFunctionalCookies");
                    public static WbButtonEx btnFunctionalCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[1]/button"), "btnFunctionalCookies");
                    public static WbWrapperEx wrpFunctionalCookies = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[1]/div/section"), "wrpFunctionalCookies");

                    public static WbToggleButton tbAnalyticsCookies = new WbToggleButton(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[2]/button/span[1]/button"), "tbAnalyticsCookies");
                    public static WbButtonEx btnAnalyticsCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[2]/button"), "btnAnalyticsCookies");
                    public static WbWrapperEx wrpAnalyticsCookies = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[2]/div/section"), "wrpAnalyticsCookies");

                    public static WbToggleButton tbMarketingCookies = new WbToggleButton(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[3]/button/span[1]/button"), "tbMarketingCookies");
                    public static WbButtonEx btnMarketingCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[3]/button"), "btnMarketingCookies");
                    public static WbWrapperEx wrpMarketingCookies = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[3]/div/section"), "wrpMarketingCookies");

                    public static WbToggleButton tbPerformanceAndTrackingCookies = new WbToggleButton(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[4]/button/span[1]/button"), "tbPerformanceAndTrackingCookies");
                    public static WbButtonEx btnPerformanceAndTrackingCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[4]/button"), "btnPerformanceAndTrackingCookies");
                    public static WbWrapperEx wrpPerformanceAndTrackingCookies = new WbWrapperEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[2]/div/div[2]/div[3]/div/div/section/div[4]/div/section"), "wrpPerformanceAndTrackingCookies");

                    public static WbButtonEx btnAcceptConditionsAndCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[3]/button[1]"), "btnAcceptConditionsAndCookies");
                    public static WbButtonEx btnAcceptConditionsAndDeclineCookies = new WbButtonEx(By.XPath("//*[@id=\"headlessui-dialog-1\"]/div/div[2]/div/div[3]/button[2]"), "btnAcceptConditionsAndDeclineCookies");
                }
            }
            public static class Products
            {
                // get ISIN value and put it in link?
                public static WbPageEx page = new WbPageEx("en-no/products/leverage/bull-bear-certificates", "Page");

                public static WbButtonEx btnIsin = new WbButtonEx(By.XPath("//*[@id=\'__next\']/div/main/div[1]/article/div/div[1]/div[4]/div[2]/span[2]/button"), "btnIsin");
            }
        }
        
    }
}