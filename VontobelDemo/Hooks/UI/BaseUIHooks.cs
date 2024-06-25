using OpenQA.Selenium.Chrome;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting;
using RAF3kShared;
using TechTalk.SpecFlow;
using VontobelDemo.Settings;
using OpenQA.Selenium;

namespace VontobelDemo.Hooks.UI
{
    [Binding]
    public class BaseUIHooks
    {
        public static readonly string sAtlasAutoITFolder = SharedVariables.Configuration.GetEntryValue("AtlasAutoITFolder");

        [BeforeScenario("UI", Order = 0)]
        public void BeforeEachScenario(ScenarioContext scenarioContext)
        {
            string TestCaseName = !String.IsNullOrEmpty(scenarioContext.ScenarioInfo.Title) ? scenarioContext.ScenarioInfo.Title : "Not defined";
            string TestCaseCode = FindTagValue(scenarioContext.ScenarioInfo.Tags, "TestCaseCode");
            string TestCaseAuthor = FindTagValue(scenarioContext.ScenarioInfo.Tags, "Author");

            UIReferences.UITestCase = new UITestCase(TestCaseName, TestCaseCode, TestCaseAuthor);

            GlobalParameters.TestCaseBase = UIReferences.UITestCase;
        }
        [AfterScenario("UI")]
        public void AfterEachScenario()
        {
            LogConstructor.GenerateLog(UIReferences.UITestCase);
        }
        [BeforeStep("UI")]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            UIReferences.UITestCase.AddBDDStep(scenarioContext.StepContext.StepInfo.Text);
        }
        [AfterStep("UI")]
        public void AfterStep()
        {
            UIReferences.UITestCase.FinishBDDStep();
        }
        [AfterTestRun]
        public static void AfterTestExecution()
        {
            if (UIReferences.UITestCase != null)
                UIReferences.UITestCase.UITeardown();
        }
        private string FindTagValue(IEnumerable<string> AllTags, string TagName)
        {
            string Value = "Not Defined";
            string FullTag = AllTags.ToList().FirstOrDefault(x => x.ToLower().Contains(TagName.ToLower()));
            if (!String.IsNullOrEmpty(FullTag))
                Value = FullTag.Replace(TagName + ":", ""); return Value;
        }
    }
}
