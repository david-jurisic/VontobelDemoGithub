using OpenQA.Selenium.Chrome;
using RAF3kGUItesting.WebTesting.BaseTypes;
using RAF3kGUItesting;
using TechTalk.SpecFlow;
using RAF3kShared;
using VontobelDemo.Settings;

namespace VontobelDemo.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario("UI", Order = 0)]
        public void BeforeEachScenario(ScenarioContext scenarioContext)
        {
            string TestCaseName = !String.IsNullOrEmpty(scenarioContext.ScenarioInfo.Title) ? scenarioContext.ScenarioInfo.Title : "Not defined";
            string TestCaseCode = FindTagValue(scenarioContext.ScenarioInfo.Tags, "TestCaseCode");
            string TestCaseAuthor = FindTagValue(scenarioContext.ScenarioInfo.Tags, "Author"); ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-notifications");
            options.AddUserProfilePreference("profile.default_content_settings.cookies", 1);
            options.AddUserProfilePreference("profile.cookie_controls_mode", 1);

            UIReferences.UITestCase = new UITestCase(TestCaseName, TestCaseCode, TestCaseAuthor, options);

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
