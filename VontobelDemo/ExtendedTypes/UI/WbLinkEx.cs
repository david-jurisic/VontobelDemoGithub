using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbLinkEx : WbLink
    {
        public WbLinkEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbLinkEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}