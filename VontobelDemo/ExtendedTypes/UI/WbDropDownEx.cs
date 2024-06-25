using OpenQA.Selenium;
using RAF3kGUItesting;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;
using RAF3kShared.Logging;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbDropDownEx : WbDropDown
    {
        public WbDropDownEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbDropDownEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }

        /// <summary>
        /// Method verifies selected option text.
        /// </summary>
        /// <param name="sText">Expected text.</param>
        /// <returns></returns>
        public Success VerifySelectedText(string sText)
        {
            return UIReferences.Eval.Evaluate(() =>
            {
                if (!Control.Text.Contains(sText))
                {
                    throw new Exception(String.Format("Selected option text does not contain expected text. Expected text: {0}, current text: {1}.", sText, Control.Text));
                }
            }, this);
        }
    }
}