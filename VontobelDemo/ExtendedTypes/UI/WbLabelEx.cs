using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbLabelEx : WbLabel
    {
        public WbLabelEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbLabelEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}