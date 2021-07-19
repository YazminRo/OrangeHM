using NUnit.Framework;
using OrangeHRR.pages.loginPage;
using System;
using System.Collections.Generic;
using System.Text;


namespace OrangeHRR.tests.loginTests
{
    class LoginTest:TestBase
    {
        [Test]
        public void testLogin()
        {
            string url = "https://opensource-demo.orangehrmlive.com/";
            driver.Url = url;
            string user = "Admin";
            string password = "admin123";
            LoginPage loginPage = new LoginPage(driver);
           // loginPage.doLogin(user, password);
            ValidacionesLoginPage validacionesLogin = loginPage.doLogin(user, password);
            Assert.IsTrue(validacionesLogin.textIsDisplayed());
        }

        [Test]
        public void testLoginUserNull()
        {
            string url = "https://opensource-demo.orangehrmlive.com/";
            driver.Url = url;
            string user = "";
            string password = "admin123";
            LoginPage loginPage = new LoginPage(driver);
            // loginPage.doLogin(user, password);
            ValidacionesLoginPage validacionesLogin = loginPage.doLogin(user, password);
            Assert.IsTrue(validacionesLogin.condicionUserNameEmpty());
        }
        [Test]
        public void testLoginPasswordNull()
        {
            string url = "https://opensource-demo.orangehrmlive.com/";
            driver.Url = url;
            string user = "Admin";
            string password = "";
            LoginPage loginPage = new LoginPage(driver);
            // loginPage.doLogin(user, password);
            ValidacionesLoginPage validacionesLogin = loginPage.doLogin(user, password);
            Assert.IsTrue(validacionesLogin.condicionPasswordEmpty());
        }
        [Test]
        public void testLoginInvalidCredits()
        {
            string url = "https://opensource-demo.orangehrmlive.com/";
            driver.Url = url;
            string user = "uyrdetf";
            string password = "34567";
            LoginPage loginPage = new LoginPage(driver);
            // loginPage.doLogin(user, password);
            ValidacionesLoginPage validacionesLogin = loginPage.doLogin(user, password);
            Assert.IsTrue(validacionesLogin.loginInvalidCredentials());
        }


    }
}
