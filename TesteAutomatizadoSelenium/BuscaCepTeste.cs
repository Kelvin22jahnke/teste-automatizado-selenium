using NUnit.Framework;
using OpenQA.Selenium;
using TesteAutomatizadoSelenium.Core;

namespace TesteAutomatizadoSelenium
{
    public class BuscaCepTeste: TesteAutomatizado
    {
        [Test]
        public void Teste()
        {

            //Informa que a busca será por CEP
            EscreveTexto("/html/body/div[1]/main/section[1]/div/div/form/div[1]/div[1]/select", "Buscar usando CEP");
            //Digita o CEP 
            EscreveTexto("/html/body/div[1]/main/section[1]/div/div/form/div[1]/div[2]/input", "96170000");
            //Clica No botão
            ClicaNoBotao("/html/body/div[1]/main/section[1]/div/div/form/div[1]/div[3]/input");
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driverQuit = false;
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[2]/table/tbody/tr[2]/td[2]")).Text, Does.Contain("São Lourenço do Sul"));
            Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[2]/table/tbody/tr[3]/td[2]")).Text, Does.Contain("Rio Grande do Sul"));

        }
    }
}
