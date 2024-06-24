using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoSelenium.Core
{
    public class DSL: VariaveisGlobais
    {
        /// <summary>
        /// Função que Escreve um texto no componente com Patch informado
        /// </summary>
        /// <param name="parPatch">Patch Completo do componente</param>
        /// <param name="parTexto">Texto digitado</param>
        public void EscreveTexto(string parPatch, string parTexto) 
        {
            driver.FindElement(By.XPath(parPatch)).SendKeys(parTexto);
        }

        /// <summary>
        /// Função que Clica no Botão 
        /// </summary>
        /// <param name="parPatch">Patch Completo do componente</param>
        public void ClicaNoBotao(string parPatch) 
        {
           driver.FindElement(By.XPath(parPatch)).Click();
        }
    }
}
