using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Selenium_Basics.Baseclass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Selenium_Basics
{
    [TestFixture]
    public class Tests : Driver
    {
        [Test]
        public void Test1()
        { 
            IWebElement srh = driver.FindElement(By.XPath("//input[@name='email']"));
            srh.SendKeys("Hello");
            srh.SendKeys(Keys.Enter);
            Console.WriteLine("Title of the page is " + driver.Title);
        }
        [Test]
        public void Enterdob()
        {
            try
            {
                ExtentTest test = extent.CreateTest("Test1").Info("Start Started");
                report.Log(Status.Info, "Browser launched");
                IWebElement day = driver.FindElement(By.XPath("//select[@id='day']"));
                day.SendKeys("10");
                IWebElement month = driver.FindElement(By.XPath("//select[@id='month']"));
                SelectElement monthdrpdwn = new SelectElement(month);
                monthdrpdwn.SelectByText("Aug");
                IWebElement year = driver.FindElement(By.XPath("//select[@id='year']"));
                SelectElement yeardrpdwn = new SelectElement(year);
                yeardrpdwn.SelectByText("1992");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("C:\\Users\\Admin\\source\\repos\\Selenium Basics\\Selenium Basics\\Screenshots\\test.png", ScreenshotImageFormat.Png);
                throw;
            }
            
         
        }
    }
}