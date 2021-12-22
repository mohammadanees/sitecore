// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using SitecoreCarList.PageObj;

namespace SitecoreCarList{
    class Program   : BasePage{

        HomePage homePage;
        SearchResultPage searchResultPage;

        
        public static void Main(){

        }
        

        [OneTimeSetUp]
        public void SetUp(){
            Inialize();
            homePage = new HomePage(driver);
            searchResultPage = new SearchResultPage(driver);
        }


        [Test]
        public void ValidateCarPrice(){
            homePage.FnClickUsedCar();
            searchResultPage.FnVerifyCarPrice(1000); 
        }

        [OneTimeTearDown]
        public void CloseDriver(){
            TearDown();
        }
    }
}
