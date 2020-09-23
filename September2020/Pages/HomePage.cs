using System;
using OpenQA.Selenium;

namespace September2020.Pages
{
    public class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // Test1 - Check if user is able to create time successfully

            // Click on Administrator menu option
            IWebElement admin = driver.FindElement(By.ClassName("dropdown-toggle"));
            admin.Click();

            //Click on Time and material option
            IWebElement timeAndMaterial = driver.FindElement(By.LinkText("Time & Materials"));
            timeAndMaterial.Click();

            
        }
    }
}
