using Allure.Net.Commons;
using Reqnroll;

namespace EconnexionTestAuto.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // https://ahbretagne.econnection.fr/Default
       // private readonly AllureLifecycle _allure;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
        public Hooks1()
        {
           // _allure = AllureLifecycle.Instance;
        }
    }
}