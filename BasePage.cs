// See https://aka.ms/new-console-template for more information
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SitecoreCarList
{
    public class BasePage
    {

        public static IWebDriver driver;

        public void Inialize()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\chromerdriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.carlist.my/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void TearDown()
        {
            driver.Close();
        }

    }
}
