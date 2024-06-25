using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Payloads;
using OpenQA.Selenium;
using RAF3kGUItesting;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;
using RAF3kShared.Logging;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbListEx : WbList
    {
        public WbListEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbListEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }

        /// <summary>
        /// Method verifies selected option text.
        /// </summary>
        /// <param name="sText">Expected text.</param>
        /// <returns></returns>
        public Success SelectOptionInList(string sText)
        {
            return UIReferences.Eval.Evaluate(() =>
            {
                List<IWebElement> AllOptions = Control.FindElements(By.ClassName("ListDropdown_optionContainer__IukoL")).ToList();
                IWebElement Option = AllOptions.FirstOrDefault(o => o.Text.Contains(sText));
                if (Option != null) {
                    Option.Click();
                }
                
            }, this);
        }
    }
}