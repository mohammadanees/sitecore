// See https://aka.ms/new-console-template for more information
using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SitecoreCarList
{
    public class SearchResultPage : BasePage
    {

        [FindsBy(How = How.XPath, Using ="(//div[@class='grid  grid--full  cf'])[1]//div[@class='grid  push-half--top']//*[@class='two-thirds']/div[2]")]
        private IWebElement priceFirstResult;

        public SearchResultPage(IWebDriver driver){
            SearchResultPage.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void FnVerifyCarPrice(long expCarPrice){
            var actPriceWithRM = priceFirstResult.Text;
            String[] price= actPriceWithRM.Split(" ");
            long actPrice=long.Parse(price[1].Replace(",",""));
            Assert.True(actPrice>expCarPrice, actPrice + " price is not greater than " + expCarPrice);
        }

    }
}
