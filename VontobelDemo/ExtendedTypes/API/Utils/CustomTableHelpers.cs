using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace VontobelDemo.ExtendedTypes.API.Utils
{
    public static class CustomTableHelpers
    {
        public static Dictionary<string, string> ToDictionary(Table table)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (TableRow row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
    }
}