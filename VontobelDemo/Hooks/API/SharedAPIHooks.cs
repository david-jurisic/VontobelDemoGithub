using RAF3kAPItesting.Base_Types;
using RAF3kShared;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using VontobelDemo.ExtendedTypes.API;

namespace VontobelDemo.Hooks.API
{
    [Binding]
    public class SharedAPIHooks
    {
        public static RAFRestResponseEx response;
        public static RAFRestResponse baseResponse;
        public static Dictionary<string, string> savedValues;

        [BeforeScenario("API", Order = 1)]
        public void BeforeEachScenarioSpotify()
        {
            savedValues = new Dictionary<string, string>();
        }

        public static class Authorization
        {
            //public static string AccessToken;
            //public static string JWT = SharedVariables.Configuration.GetEntryValue("JWT");
            public static Dictionary<string, string> authHeader = new Dictionary<string, string>(){ { "Accept", "application/json" }, { "Content-Type", "application/json" } };
        }


    }
}
