using System;
using System.Threading;
using OpenQA.Selenium;

namespace September2020.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on Create New
            IWebElement create = driver.FindElement(By.LinkText("Create New"));
            create.Click();


            //Click on Type Code drop down
            IWebElement typeCode = driver.FindElement(By.ClassName("k-select"));
            typeCode.Click();

            //Click on Type Code Time option
            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();

            //Click on Code and enter code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("Sep2020");

            //Click on Description and enter description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Honesty is the best policy");

            //Click on Price per unit and enter price
            IWebElement price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("10.01");

            //Click save Button
            IWebElement saveBtn = driver.FindElement(By.Id("SaveButton"));
            saveBtn.Click();

            //Wait
            Thread.Sleep(2000);


            //Click on last page option to check created time successfully
            IWebElement last = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            last.Click();

            // Wait
            Thread.Sleep(3000);

            // Validate if the data is saved successfully
            

            IWebElement expectedcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
       
            if(expectedcode.Text == "Sep2020" )
            {
                Console.WriteLine("Time record created successfully, Test1 Passed");

            }
            else
            {
                Console.WriteLine("Unable to find the record created, Test Failed");
            }

            // Wait
            Thread.Sleep(1000);

            


        }
        public void EditTM(IWebDriver driver)
        {
            //To-do - code to edit TM test
            //Click on edit
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            edit.Click();


            //Click on Price per unit and enter price
            IWebElement pp = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pp.Clear();
            pp.Click();
            pp.SendKeys("330");

            // click download button
            IWebElement download = driver.FindElement(By.Id("downloadButton"));

            //Click save Button
            IWebElement saveBtn = driver.FindElement(By.Id("SaveButton"));
            saveBtn.Click();
        }
        public void DeleteTM(IWebDriver driver)
        {
            //To-do - code to delete TM test
        }
    }
}
