using EconnexionTestAuto.Config;
using EconnexionTestAuto.DTO.DTOUser;
using EconnexionTestAuto.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconnexionTestAuto.Actions.ApplicationActions
{
    public class EconnexionAppActions
    {
        private readonly IWebDriver _driver;
        private readonly LoginActions _loginPage;
        UserData user = JsonTestDataReader.Read<UserData>("user.json");

        public EconnexionAppActions(
            IWebDriver driver,
            LoginActions loginPage)
        {
            _driver = driver;
           _loginPage = loginPage;
        }

        public void StartApplication()
        {
           // _driver.Navigate().GoToUrl(TestConfig.BaseUrl);
          // _driver.Navigate().GoToUrl("https://qualite-phoenix.econnection.fr/Authentification/Login/STM/DataBase");
           _driver.Navigate().GoToUrl(user.Url);
           _driver.Manage().Window.Maximize();
           _loginPage.EnterUsername(user.Username);
           _loginPage.EnterPassword(user.Password);
           _loginPage.ClickLogin();
           _loginPage.HomePageShouldBeDisplayed();

        }
    }
}
