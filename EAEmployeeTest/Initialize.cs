using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    [Binding]
    public class Initialize : TestInit
    {

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [AfterStep]
        public void AfterEachStep()
        {

            var stepName = ScenarioContext.Current.StepContext.StepInfo.Text;
            var featureName = FeatureContext.Current.FeatureInfo.Title;
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null) {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                
            }
        }


      public Initialize() : base(BrowserType.Chorme) {
           InitializeSettings();
           NavigateSite();
        }

        [BeforeTestRun]
        public static void InitializedReport() {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\sla\Desktop\testAutomationFramework\automation\EATestProject\EAEmployeeTest\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);           
        }

        /*[BeforeTestRun]
        public static void TestInitialize()
        {
            Initialize init = new Initialize();
        }*/

      
        [BeforeFeature]
        public static void BeforeFeature() {
            
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);                        
        }       

        [BeforeScenario]
        public void BeforeScenario() {
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public static void TearDownReport()
        {
            extent.Flush();
        }
    }
}
