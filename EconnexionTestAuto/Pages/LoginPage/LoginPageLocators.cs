using OpenQA.Selenium;


namespace EconnexionTestAuto.Pages.LoginPage
{
    public static class LoginPageLocators
    {
        public static readonly By UsernameInput =
            By.Id("Login");

        public static readonly By PasswordInput =
            By.Id("Password");

        public static readonly By LoginButton =
            By.Id("btnlogin");
    }
}
