using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbTableEx : WbTable
    {
        public WbTableEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbTableEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}