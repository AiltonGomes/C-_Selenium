using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestBuscaCep.testes
{
    [TestClass]
    public class BuscaCep
    {
        private IWebDriver driver;

        [TestMethod]
        public void BuscaCorreios()
        {
            
            Utils util = new Utils();
            ElementsWebDriver elementwebdriver = new ElementsWebDriver();


            util.Inicializa();
            elementwebdriver.digitaDadosPesquisa("80700000");
            elementwebdriver.clicarPesquisaCep();
            elementwebdriver.validaCepInexistente();
            elementwebdriver.clicarVoltarPesquisa();
            elementwebdriver.digitaDadosRepesquisar("01013001");
            elementwebdriver.clicarBuscarCep();
            elementwebdriver.validaCepExistente();


            /*
             *  Não da pra pesquisar o codigo de rastreio pois tem um recaptcha que é 
             *  uma imagem, não sendo possivel na automação coletar o dado necessario 
             *  para digitar no campo de recaptcha.
             *  
             *  
             *  Abaixo estão os passos que seguiriam para pesquisa do codigo de rastreio:  
             *          driver.digitaDadosPesquisa("SS987654321BR");
             *           driver.clicarPesquisaCodRastreio();
            */


            util.Cleanup();
        }
    }
}
