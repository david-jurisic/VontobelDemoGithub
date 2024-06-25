using OpenQA.Selenium;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting.WebTesting.Types;

namespace VontobelDemo.ExtendedTypes.UI
{
    public class WbWrapperEx : WbWrapper
    {
        public WbWrapperEx(By SearchBy, WebControlBase Parent, string Alias) : base(SearchBy, Parent, Alias)
        {
        }

        public WbWrapperEx(By SearchBy, string Alias) : base(SearchBy, Alias)
        {
        }
    }
}