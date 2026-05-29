using Allure.Net.Commons;
using EconnexionTestAuto.Actions.ApplicationActions;
using Reqnroll;

namespace EconnexionTestAuto.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // https://ahbretagne.econnection.fr/Default
        // private readonly AllureLifecycle _allure;
        private readonly EconnexionAppActions _applicationActions;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            _applicationActions.StartApplication();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
        public Hooks1(EconnexionAppActions applicationActions)
        {
            // _allure = AllureLifecycle.Instance;
            _applicationActions = applicationActions;
        }
    }
}