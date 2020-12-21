using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;




namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\driver");
            driver.Url = "https://www.epam.com";
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[3]/div/button", "//*[@id=\"new_form_search\"]", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/button", "https://www.epam.com/search?q=Blockchain")]
        public void Test1(string Xpath1, string Xpath2, string Xpath3, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
            driver.FindElement(By.XPath(Xpath2)).SendKeys("Blockchain");
            driver.FindElement(By.XPath(Xpath3)).Click();
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        } 
    
        [TestCase("//*[@id=\"main\"]/div[1]/div[1]/section/div/div/div/div/div/div/div[3]/div/button", "https://www.epam.com/about/who-we-are/social-responsibility/covid-19-response")]
        public void Test2(string Xpath1, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.epam.com/about/who-we-are/social-responsibility/covid-19-response";
            driver.FindElement(By.XPath(Xpath1)).Click();
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }
     
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[5]/span[1]/a", "/ html / body / div[1] / div[2] / div / div / div / div / div[2] / button / span", "//*[@id=\"main\"]/div[1]/div[2]/section/div/div[1]/div/ul/li[5]/a", "https://www.epam.com/about/who-we-are/events")]
        public void Test3(string Xpath1, string Xpath2, string Xpath3, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
            driver.FindElement(By.XPath(Xpath2)).Click();

            var el3 = driver.FindElement(By.XPath(Xpath3));
            new Actions(driver).MoveToElement(el3).Perform();
            System.Threading.Thread.Sleep(1000);
            el3.Click();

            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }
      
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/button", "https://www.epam-group.ru/")]
        public void Test4(string Xpath1,  string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[9]/a")).Click();
            System.Threading.Thread.Sleep(2000);




            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }
     
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[1]/a/span", "https://www.epam.com/about/who-we-are/contact")]
        public void Test5(string Xpath1, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
           
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }
  
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/button", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[6]", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/div/nav/ul/li[6]/ul/li[4]/a", "https://www.epam.com/careers/blog")]
        public void Test6(string Xpath1, string Xpath2, string Xpath3, string OpenedUrl)
        {
            driver.FindElement(By.XPath(Xpath1)).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath(Xpath2)).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath(Xpath3)).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }

        [TestCase("//*[@id=\"main\"]/div[1]/div[2]/section/div/div/div/div[1]/div/div[3]/div/div/div/div/div/div/div/div/div/div[3]/div/a", "https://www.epam.com/services/consult-and-design")]
        public void Test7(string Xpath1, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[3]/span[1]/a", "//*[@id=\"id-0c33e057-af00-3cf7-8ff7-4cf0e97f9cf4\"]/div[2]/div/div/div[1]/div[1]/div/div[4]/div/button/div[1]", "//*[@id=\"id-0c33e057-af00-3cf7-8ff7-4cf0e97f9cf4\"]/div[2]/div/div/div[2]/div[1]/ul/li[2]/a", "/html/body/div[1]/div[2]/div/div/div/div/div[2]/button/span", "https://www.epam.com/our-work")]
        public void Test8(string Xpath1, string Xpath2, string Xpath3, string Xpath4, string OpenedUrl)
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath(Xpath1)).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath(Xpath4)).Click();
            System.Threading.Thread.Sleep(1000);
            var element = driver.FindElement(By.XPath(Xpath2));
            Actions action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
            System.Threading.Thread.Sleep(2000);
            element.Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath(Xpath3)).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(OpenedUrl, driver.Url, "the required page wasn't opened");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}