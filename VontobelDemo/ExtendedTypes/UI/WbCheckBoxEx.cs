using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbCheckBoxEx : WbCheckBox
    {
        public WbCheckBoxEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbCheckBoxEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}