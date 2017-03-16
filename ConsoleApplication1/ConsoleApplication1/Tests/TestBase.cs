using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MobileWebAutomation.Tests
{
    class TestBase
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://m.easyjet.com/m2p-ej/s/");
        }
    }
}