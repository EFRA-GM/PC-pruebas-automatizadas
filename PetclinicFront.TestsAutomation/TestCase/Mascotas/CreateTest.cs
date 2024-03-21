using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetclinicFront.TestsAutomation.Handlers;
using PetclinicFront.TestsAutomation.PageObject.Mascotas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace PetclinicFront.TestsAutomation.TestCase.Mascotas
{
    public class CreateTest : IDisposable
    {
        protected IWebDriver Driver;
        protected string urlIndex = "https://egmtestsk.azurewebsites.net/DevOps/Index";
        protected string urlCreate = "https://egmtestsk.azurewebsites.net/DevOps/Create";
        protected By tabla = By.XPath("//*[@id='tabla_mascotas']/tbody/tr");

        /// <summary>
        /// 
        /// </summary>
        public CreateTest()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if(Driver != null)
            {
                Driver.Quit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void CreateMascota()
        {
            int time = 400;
            Driver.Navigate().GoToUrl(urlIndex);
            int rows = Driver.FindElements(tabla).Count;

            Thread.Sleep(time);
            Driver.Navigate().GoToUrl(urlCreate);
            CreatePage cp = new CreatePage(Driver);

            Thread.Sleep(time);
            cp.TypeFieldTipoMascota("Perro");

            Thread.Sleep(time); 
            cp.TypeFieldNombreMascota("Black");

            Thread.Sleep(time);
            cp.TypeFieldPesoMascota("20");

            Thread.Sleep(time);
            cp.TypeFieldColorMascota("Negro");

            Thread.Sleep(time);
            cp.ClickSubmit();

            Driver.SwitchTo().Alert().Accept();

            Thread.Sleep(time);
            Driver.Navigate().GoToUrl(urlIndex);

            Thread.Sleep(time);
            int rows2 = Driver.FindElements(tabla).Count;

            Assert.Equal(rows + 1, rows2);
        }
    }
}
