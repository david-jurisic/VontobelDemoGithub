using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbEditEx : WbEdit
    {
        public WbEditEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbEditEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}