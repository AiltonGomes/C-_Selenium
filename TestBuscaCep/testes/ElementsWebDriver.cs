using OpenQA.Selenium;
using System;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBuscaCep.testes
{
    internal class ElementsWebDriver {
        WebDriver driver;
        WebDriverWait esperar;

        public void digitaDadosPesquisa(String elemento) 
        {
            IWebElement caixaPesquisaGoogle = driver.FindElement(By.Id("relaxation"));
            caixaPesquisaGoogle.SendKeys(elemento);
        }
        public void digitaDadosRepesquisar(String elemento)
        {
            IWebElement caixaPesquisaGoogle = driver.FindElement(By.Id("endereco"));
            caixaPesquisaGoogle.SendKeys(elemento);
        }

        //endereco
        public void clicarPesquisaCep()
        {
            IWebElement pesquisaGoogle = driver.FindElement(By.XPath("(//i[@class='ic-busca-out'])[1]"));
            pesquisaGoogle.Click();
        }
        public void clicarVoltarPesquisa()
        {
            IWebElement pesquisaGoogle = driver.FindElement(By.XPath("//a[contains(.,'Voltar ao menu')]"));
            pesquisaGoogle.Click();
        }
        public void clicarBuscarCep()
        {
            IWebElement pesquisaGoogle = driver.FindElement(By.Id("btn_pesquisar"));
            pesquisaGoogle.Click();
        }
        public void clicarPesquisaCodRastreio()
        {
            IWebElement pesquisaGoogle = driver.FindElement(By.XPath("(//i[@class='ic-busca-out'])[2]"));
            pesquisaGoogle.Click();
        }
        public void validaCepInexistente() {
            IWebElement validar = driver.FindElement(By.Id("mensagem-resultado-alerta"));
            Assert.AreEqual(validar, "Dados não encontrado");
        }
        public void validaCepExistente()
        {
            IWebElement validar = driver.FindElement(By.XPath("//td[@data-th='Logradouro/Nome'][contains(.,'Rua Quinze de Novembro - lado ímpar')]"));
            Assert.AreEqual(validar, "Rua Quinze de Novembro - lado ímpar");
        }
    }
}
