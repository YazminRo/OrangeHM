using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRR.pages.loginPage
{
    class LoginPage: BasePage
    {
        [FindsBy(How = How.Name, Using = "txtUsername")]
        private IWebElement userNameField;

        [FindsBy(How = How.Name, Using = "txtPassword")]
        private IWebElement passwordField;

        [FindsBy(How = How.Name, Using = "Submit")]
        private IWebElement btnSumit;

        public LoginPage(IWebDriver driver) :base(driver) 
        {
            
            PageFactory.InitElements(driver, this);
        }

        public ValidacionesLoginPage doLogin(string user, string passwordL)
        {
            typeOnElement(userNameField, user);
            typeOnElement(passwordField, passwordL);
            clickOnElement(btnSumit);
            return new ValidacionesLoginPage(driver);
        }
    }
}
