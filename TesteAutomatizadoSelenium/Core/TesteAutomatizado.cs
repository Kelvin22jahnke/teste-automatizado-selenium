using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteAutomatizadoSelenium.Core
{
    public class TesteAutomatizado:DSL
    {
      

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepcorreios.com.br/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
    }
}