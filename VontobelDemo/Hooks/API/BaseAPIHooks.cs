using RAF3kAPItesting.Base_Types;
using RAF3kAPItesting;
using RAF3kShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace VontobelDemo.Hooks.API
{
    [Binding]
    public class BaseAPIHooks
    {

        [BeforeScenario("API", Order = 0)]
        public void BeforeEachScenario(ScenarioContext scenarioContext)
        {
            string TestCaseName = !String.IsNullOrEmpty(scenarioContext.ScenarioInfo.Title) ? scenarioContext.ScenarioInfo.Title : "Not defined";
            string TestCaseCode = FindTagValue(scenarioContext.ScenarioInfo.Tags, "TestCaseCode");
            string TestCaseAuthor = FindTagValue(scenarioContext.ScenarioInfo.Tags, "Author");

            APIReferences.APITestCase = new APITestCase(TestCaseName, TestCaseCode, TestCaseAuthor);
        }

        [AfterScenario("API")]
        public void AfterEachScenario()
        {
            LogConstructor.GenerateLog(APIReferences.APITestCase);
        }

        [BeforeStep("API")]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            APIReferences.APITestCase.AddBDDStep(scenarioContext.StepContext.StepInfo.Text);
        }

        [AfterStep("API")]
        public void AfterStep()
        {
            APIReferences.APITestCase.FinishBDDStep();
        }

        private string FindTagValue(IEnumerable<string> AllTags, string TagName)
        {
            string Value = "Not Defined";
            string FullTag = AllTags.ToList().FirstOrDefault(x => x.ToLower().Contains(TagName.ToLower()));
            if (!String.IsNullOrEmpty(FullTag))
                Value = FullTag.ToLower().Replace(TagName.ToLower() + ":", "");

            return Value;
        }

        public static Dictionary<string, string> savedValues;
        [BeforeScenario("Hybrid", Order = 1)]
        public void BeforeEachScenarioReddit()
        {
            savedValues = new Dictionary<string, string>();
        }
    }
}