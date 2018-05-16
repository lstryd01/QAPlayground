using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using static OpenQA.Selenium.Chrome.ChromeDriver;

namespace ClassLibrary3.Playground
{
    [Binding]
    class BaseSteps
    {

        public IWebDriver WebDriver = new ChromeDriver();

        [Given(@"I have loaded the Asos website")]
        public void GivenIHaveLoadedTheAsosWebsite()
        {
            WebDriver.Navigate().GoToUrl("www.asos.com/women");
        }
    }
}
