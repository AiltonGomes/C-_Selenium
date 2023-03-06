using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace TestBuscaCep.testes
{
    [TestClass]
    public class Utils
    {
        WebDriver driver;
        WebDriverWait esperar;

        [TestInitialize]
        public void Inicializa(){
            driver = new ChromeDriver();
            esperar = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.correios.com.br/");
        }

        [TestCleanup]
        public void Cleanup(){
            driver.Close();
            driver.Quit();
        }
    }
}
