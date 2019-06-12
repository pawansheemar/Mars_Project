using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region Add Language Feature
    [Binding]
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//*//a[@class='item active'][contains(text(),'Languages')]");

            // Click on langauge tab under Profile page
            Driver.driver.FindElement(By.XPath("//*//a[@class='item active'][contains(text(),'Languages')]")).Click();

        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("French");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        #endregion

    #region Update Language Feature
        [Given(@"I click on the Language tab under Profile page")]
        public void GivenIClickOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            CommonMethods.waitUntilElementVisible(Driver.driver, 10, "//*//a[@class='item active'][contains(text(),'Languages')]", "XPath");

            // Click on langauge tab under Profile page
            Driver.driver.FindElement(By.XPath("//*//a[@class='item active'][contains(text(),'Languages')]")).Click();
        }

        [When(@"I update the language")]
        public void WhenIUpdateTheLanguage()
        {
           
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 30, "//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[1]//tr[1]//td[3]//span[1]//i[1]", "XPath");

            //Click on write icon button for Update the Language
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[1]//tr[1]//td[3]//span[1]//i[1]")).Click();

            //Update Language, change to "English"
            var AddLang = Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            AddLang.Clear();
            AddLang.SendKeys("English");

            //Click on Language Level to Update the new Language level "Fluent"
            Driver.driver.FindElement(By.XPath("//select[@name='level']//option[contains(text(),'Fluent')]")).Click();

            //Click on Update button
            Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@class='ui teal button']")).Click();
        }

        [Then(@"that updated language should be displayed on my listings")]
        public void ThenThatUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been Updated']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Languages Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageUpdated");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        #endregion

    #region Delete Language Feature
        [Given(@"I click on the Language tab under Profile")]
        public void GivenIClickOnTheLanguageTabUnderProfile()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//*//a[@class='item active'][contains(text(),'Languages')]");

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*//a[@class='item active'][contains(text(),'Languages')]")).Click();
        }

        [When(@"I delete the language that I have added perviously")]
        public void WhenIDeleteTheLanguageThatIHaveAddedPerviously()
        {
             //wait for element clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 30, "//body//span[2]//i[@class='remove icon']", "XPath");

            //select the Langauge from the list and click on the cross icon, then that skill will be deleted from list.
            Driver.driver.FindElement(By.XPath("//body//span[2]//i[@class='remove icon']")).Click();

        }

        [Then(@"that deleted language should not be displayed on my listings")]
        public void ThenThatDeletedLanguageShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "German";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been Deleted']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Languages Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);


            }
        }

      
    }

}

  #endregion
