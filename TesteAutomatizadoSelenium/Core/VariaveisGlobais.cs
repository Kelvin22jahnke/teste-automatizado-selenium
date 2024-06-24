using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoSelenium.Core
{
    public class VariaveisGlobais
    {
        //Define 'driver' como trigger para os WebElements
        public IWebDriver driver;
        //Define 'Fechar navegador ao final do teste' como padrão
        public bool driverQuit = true;
    }
}
