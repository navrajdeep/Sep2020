using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Pages;

namespace September2020
{
    class Program
    {
        static void Main(string[] args)
        {

            // Intitialize and define webdirver
            IWebDriver driver = new ChromeDriver(".");

            // Object init and define for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            //Object init and define for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

            // Test 2 - Check if the user is able to edit time successfully
            tmObj.EditTM(driver);

            // Test 3 - Check if the user is able to edit time successfully
            tmObj.DeleteTM(driver);

        }

    }
}
