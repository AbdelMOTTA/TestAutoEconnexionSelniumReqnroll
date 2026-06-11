using EconnexionTestAuto.Pages.DashboardPage;
using EconnexionTestAuto.Pages.LoginPage;
using EconnexionTestAuto.Utils;
using FluentAssertions;
using OpenQA.Selenium;

namespace EconnexionTestAuto.Actions.ApplicationActions
{
    public class LoginActions
    {
        private readonly IWebDriver _driver;

        public LoginActions(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement UsernameInput =>
            _driver.FindElement(LoginPageLocators.UsernameInput);

        private IWebElement PasswordInput =>
            _driver.FindElement(LoginPageLocators.PasswordInput);

        private IWebElement LoginButton =>
            _driver.FindElement(LoginPageLocators.LoginButton);
        private IWebElement DashboardLogo =>
        _driver.FindElement(DashboardPageLocators.LogoDashbord);

        public void EnterUsername(string username)
        {
            AutomationHelper.WaitForElement(_driver, LoginPageLocators.UsernameInput, 10);
            UsernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }
        public void HomePageShouldBeDisplayed()
        {
            AutomationHelper.WaitForElement(_driver, DashboardPageLocators.LogoDashbord, 10);
            DashboardLogo.Displayed.Should().BeTrue(
                "l'utilisateur doit être redirigé vers le dashboard");
        }
    }
}
