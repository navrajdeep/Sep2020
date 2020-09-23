using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace September2020.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            

            //launch browser and enter url
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");

            //maximize web browser
            driver.Manage().Window.Maximize();
            //identify username and enter username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // identify password text and enter password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // identify and click login
            IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginBtn.Click();

            // validate if the user had logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }
        }
    }
}
