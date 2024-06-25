using System.Text;
using TechTalk.SpecFlow;

namespace VontobelDemo.Helpers
{
    public class TableHelpers
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

        public static List<string> ToList(Table table)
        {
            List<string> list = new List<string>();

            foreach (TableRow row in table.Rows)
            {
                list.Add(row[0]);
            }

            return list;
        }
    }
}
