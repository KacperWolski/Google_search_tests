using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Google_search
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Title_match()
        {
            var Driver = new ChromeDriver();
            var url = "http://google.com";
            Driver.Navigate().GoToUrl(url);
            var type_field = Driver.FindElement(By.Name("q"));
            type_field.SendKeys("one");
            var submit_btn = Driver.FindElement(By.Name("btnK"));
            submit_btn.Click();
            var expected_title = ("one - Google Search");
            var site_title = Driver.Title;
            Assert.AreEqual(site_title, expected_title);
            Driver.Close();

        }
    }
}
