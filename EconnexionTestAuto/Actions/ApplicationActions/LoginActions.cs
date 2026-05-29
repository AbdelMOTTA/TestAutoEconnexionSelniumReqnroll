using EconnexionTestAuto.Pages.LoginPage;
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

        public void EnterUsername(string username)
        {
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
    }
}
