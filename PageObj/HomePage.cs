// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SitecoreCarList.PageObj
{
    public class HomePage   : BasePage
    {

        [FindsBy(How = How.XPath, Using = "(//*[@placeholder='All Condition']/parent::div)[1]")]
        private IWebElement allConditionDD;

        [FindsBy(How = How.XPath, Using = "//div[@data-value='used']")]
        private IWebElement usedCar;

        [FindsBy(How = How.XPath, Using = "//*[@type='submit']")]
        private IWebElement searchBtn;

        public HomePage(IWebDriver driver){
            HomePage.driver = driver;
            PageFactory.InitElements(driver,this);
        }


        public void FnClickUsedCar(){
           allConditionDD.Click();
           usedCar.Click();
           searchBtn.Click(); 
        }
    }
}
