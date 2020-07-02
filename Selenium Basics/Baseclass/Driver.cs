using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Basics.Baseclass
{
   public class Driver
    {
        public IWebDriver driver;
        public  ExtentReports extent = null;
        public ExtentTest report = null;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\\Users\\Admin\\source\\repos\\Selenium Basics\\Selenium Basics\\ExtentReports\\HtmlReport.html");
            extent.AttachReporter(htmlReporter);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            extent.Flush();
        }
    }
}
