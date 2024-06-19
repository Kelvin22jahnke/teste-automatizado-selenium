using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteAutomatizadoSelenium
{
    public class TesteAutomatizado
    {
        public IWebDriver driver;

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
        }
    }
}