using RAF3kAPItesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VontobelDemo.ExtendedTypes.API;

namespace VontobelDemo.Map.API
{
    internal class VontobelDemoAPIMap
    {
        public static void Initialize()
        {
            APIReferences.CurrentPageContext = "https://markets.vontobel.com/api/";
        }
        public static class Product
        {
            //public static QueryStringEx GetProductsList(string c, string it) => new QueryStringEx($"v1/products/search?c={c}&it={it}");
            public static QueryStringEx GetProductsList => new QueryStringEx("v1/products/search?c=en-no&it=1");
        }
    }
}
