using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetclinicFront.TestsAutomation.PageObject.Mascotas
{
    public class CreatePage
    {
        /// <summary>
        /// Selenium web driver
        /// </summary>
        protected IWebDriver Driver;

        /// <summary>
        /// Identificadores de campos
        /// </summary>
        protected By TipoMascotaInput = By.Id("tipo_mascota");
        protected By NombreMascotaInput = By.Id("nombre_mascota");
        protected By PesoMascotaInput = By.Id("peso");
        protected By ColorMascotaInput = By.Id("color");
        protected By Submit = By.Id("submit");

        /// <summary>
        /// Constructor. Lanza una excepcion si el titulo de la página del create no es el correcto
        /// </summary>
        /// <param name="driver"></param>
        public CreatePage(IWebDriver driver)
        {
            Driver = driver;

            /**
            if(!Driver.Title.Equals("Crear registro"))
            {
                throw new Exception("Esta no es la página para agregar mascotas");
            }
            */
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void TypeFieldTipoMascota(string value)
        {
            Driver.FindElement(TipoMascotaInput).SendKeys(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void TypeFieldNombreMascota(string value)
        {
            Driver.FindElement(NombreMascotaInput).SendKeys(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void TypeFieldPesoMascota(string value)
        {
            Driver.FindElement(PesoMascotaInput).SendKeys(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void TypeFieldColorMascota(string value)
        {
            Driver.FindElement(ColorMascotaInput).SendKeys(value);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClickSubmit()
        {
            Driver.FindElement(Submit).Click();
        }
    }
}
