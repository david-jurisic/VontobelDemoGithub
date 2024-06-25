using OpenQA.Selenium;
using RAF3kGUItesting;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kShared.Logging;

namespace VontobelDemo.Types
{
    public class WbToggleButton : WebControlBase
    {
        public WbToggleButton() { }

        public WbToggleButton(IWebElement webElement, string Alias) : base(webElement, Alias)
        {
        }

        public WbToggleButton(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }

        public WbToggleButton(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbToggleButton(By SearchBy, IWebElement Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        /// <summary>
        /// Method verifies if button is toggled.
        /// </summary>
        /// <param name="bToggled">Set true for toggled, set false for not toggled.</param>
        /// <returns></returns>
        public Success VerifyToggled(bool bToggled)
        {
            return UIReferences.Eval.Evaluate(() =>
            {
                string sClass = Control.GetAttribute("class");

                if (bToggled && !sClass.Contains("Toggle_isChecked__qXhPT"))
                {
                    throw new Exception(String.Format("Button is not toggled but toggled is expected."));
                }
                else if (!bToggled && sClass.Contains("Toggle_isChecked__qXhPT"))
                {
                    throw new Exception(String.Format("Button is toggled but not toggled is expected."));
                }
            }, this);
        }

        /// <summary>
        /// Method verifies if button is disabled.
        /// </summary>
        /// <param name="bDisabled">Set true for disabled, set false for enabled.</param>
        /// <returns></returns>
        public Success VerifyDisabled(bool bDisabled)
        {
            return UIReferences.Eval.Evaluate(() =>
            {
                string sClass = Control.GetAttribute("class");

                if (bDisabled && !sClass.Contains("Toggle_isDisabled__ghKyR"))
                {
                    throw new Exception(String.Format("Button is enabled but disabled is expected."));
                }
                else if (!bDisabled && sClass.Contains("Toggle_isDisabled__ghKyR"))
                {
                    throw new Exception(String.Format("Button is disabled but enabled is expected."));
                }
            }, this);
        }
    }
}
