using TechTalk.SpecFlow;
using ProjectUtilitiesframework;
using ProjectPOMframework;
using OpenQA.Selenium;
using System.Configuration;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;

namespace ProjectBDDTestframeWork
{
    [Binding]
    public sealed class BddHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public static IWebDriver driver;
        private static AventStack.ExtentReports.ExtentReports extent;
        private static ExtentTest Feature;
        private static ExtentTest Sceanrio;
       static  HelperClass help;

        [BeforeScenario]
        public void FirstBeforeScenario()
        {   
            SingletonBaseClass.setSingletonInstanceNull();
            driver =SingletonBaseClass.getDriverInstance().getDriver();                      
            SingletonBaseClass.getDriverInstance().launchBrowser();
            Sceanrio = Feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }
        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlreporter = new ExtentHtmlReporter(@"C:\Thirumala\PersonalDocs\ProjectPOMframework\ExtentReports.html");
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreporter);
        }

        [AfterTestRun]
        public static void CleanupReport()
        {
            extent.Flush();
        }
        [BeforeFeature]
        public static void BeforeFeatureAttribute()
        {

            Feature = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }
        [AfterStep]
        public static void AfterStepAttribute()
        {
            help = new HelperClass(driver);
            var StepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (StepType == Constants.given) { Sceanrio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text); }
                else if (StepType == Constants.when) { Sceanrio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text); }
                else { Sceanrio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text); }
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (StepType == Constants.given)
                {
                    Sceanrio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                    Sceanrio.AddScreenCaptureFromPath(help.TakeScreenshot());
                }

                else if (StepType == Constants.when)
                {
                    Sceanrio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                    Sceanrio.AddScreenCaptureFromPath(help.TakeScreenshot());
                }
                else
                {
                   
                    Sceanrio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    Sceanrio.AddScreenCaptureFromPath(help.TakeScreenshot());

                }
            }

        }
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver=null;
            
        }
    }
}