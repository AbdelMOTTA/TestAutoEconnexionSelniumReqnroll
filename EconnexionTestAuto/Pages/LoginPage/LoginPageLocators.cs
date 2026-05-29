using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconnexionTestAuto.Pages.LoginPage
{
    public static class LoginPageLocators
    {
        public static readonly By UsernameInput =
            By.Id("username");

        public static readonly By PasswordInput =
            By.Id("password");

        public static readonly By LoginButton =
            By.Id("login");
    }
}
