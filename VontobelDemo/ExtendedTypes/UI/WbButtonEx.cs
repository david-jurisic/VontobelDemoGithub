using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbButtonEx : WbButton
    {
        public WbButtonEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbButtonEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}