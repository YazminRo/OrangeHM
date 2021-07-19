using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRR.pages
{
    class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;


        public BasePage(IWebDriver driver)
        {

            this.driver = driver;
            //EXPLICITAS
            //Instacion del objeto wait
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            /////////////////////////////////////////////////////////////////////////////
           
            
            ///ESPERA EXPLICITAS FLUIDAS//////////////////////////
            /// // Estableco que se consulte si el elemento web esta cada 200 millisegundos
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            ///////////////////////////////////////////////////////////////////////////////

            //////////ESPERA IMPLICITA////////////////////////////////////////////////////
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            ///////////////////////////////////////////////////////////


        }

        public void typeOnElement(IWebElement element, String text)
        {

           

            /////////////////////////////////////////////////////////////
            ///ESPERA EXPLICITA/////////////////////////////////////
            // uso de la instancia wait y pasadole la condicion
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Clear();
            element.SendKeys(text);
            /////////////////////////////////////////////////////////////

           

        }

        public void clickOnElement(IWebElement element)
        {
           // wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
            //////////ESPERA EXPLICITA
            Thread.Sleep(200);

        }

        /* public void onSelectableElement(IWebElement element, String text)
         {
             new Select(element)).
         }

         */

        public void selectOptionWithText(IWebElement element, String text)
        {
            /////////////ESPERA FLUIDA///////////////
            ///// Establesco la condicion que se va a ignorar si no se encuentra el elemento 
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            // el mensaje que se va a imprimir en consola///////
            wait.Message = "Element to be searchDefaultWaited not found";
            //wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
            element.SendKeys(text);
            element.SendKeys(Keys.Tab);
            element.SendKeys(Keys.Enter);

        }

    }
}
