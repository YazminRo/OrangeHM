using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRR.pages.loginPage
{
    class ValidacionesLoginPage:BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Assign Leave")]
        private IWebElement textCondicion;

        [FindsBy(How = How.XPath, Using = "//span[text()='Username cannot be empty']")]
        private IWebElement condicionLoginUserNameEmpty;

        [FindsBy(How = How.XPath, Using = "//span[text()='Password cannot be empty']")]
        private IWebElement condicionLoginPasswordEmpty;


        [FindsBy(How = How.XPath, Using = "//span[text()='Invalid credentials']")]
        private IWebElement condicionLoginInvalidCredentials;



        public ValidacionesLoginPage(IWebDriver driver):base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public bool textIsDisplayed()
        {
            return textCondicion.Displayed;
        }

        public bool condicionUserNameEmpty()
        {
            return condicionLoginUserNameEmpty.Displayed;
        }

        public bool condicionPasswordEmpty()
        {
            return condicionLoginPasswordEmpty.Displayed;
        }

        public bool loginInvalidCredentials()
        {
            return condicionLoginInvalidCredentials.Displayed;
        }



    }
}
