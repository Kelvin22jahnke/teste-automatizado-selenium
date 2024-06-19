using NUnit.Framework;
using OpenQA.Selenium;

namespace TesteAutomatizadoSelenium
{
    public class BuscaCepTeste: TesteAutomatizado
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.Id("tipo_consulta")).SendKeys("Buscar usando CEP");
            driver.FindElement(By.Id("dados_consulta")).SendKeys("96170000");
            driver.FindElement(By.Id("botaoBuscar")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[2]/table/tbody/tr[2]/td[2]")).Text, Does.Contain("São Lourenço do Sul"));
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[2]/table/tbody/tr[3]/td[2]")).Text, Does.Contain("Rio Grande do Sul"));

        }
    }
}
