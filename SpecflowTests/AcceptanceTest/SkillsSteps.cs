using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region AddS kills Feature
    [Binding]
    public class SkillsSteps
    {
        [Given(@"I Clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {

            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//*[@id='account-profile-section']//a[contains(text(),'Skills')]");

            //Click on the Skills tab 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']//a[contains(text(),'Skills')]")).Click();
        }

        [When(@"I add new skills")]
        public void WhenIAddNewSkills()
        {
            // Click on the Add new button for add skill
            Driver.driver.FindElement(By.XPath("//tr//th//div[@class='ui teal button'][contains(text(),'Add New')]")).Click();

            //Enter skill in "Add Skill' textbox
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Tester");

            //Choose skill level from the dropdown-list
            Driver.driver.FindElement(By.XPath("//select[@name='level']//option[contains(text(),'Beginner')]")).Click();

            //After choosing Skill and Skill Level, Click on the Add button
            Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[contains(@class,'ui teal button')]")).Click();

        }

        [Then(@"that skills should be displayed on my listing")]
        public void ThenThatSkillsShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Add a skills");

                Thread.Sleep(1000);
                string ExpectedValue = "Tester";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been added']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skills Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdded");
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

        #region Update Skills Feature
        [Given(@"I click on the Language tab under profile")]
        public void GivenIClickOnTheLanguageTabUnderProfile()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//*[@id='account-profile-section']//a[contains(text(),'Skills')]");

            //Click on the Skills tab 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']//a[contains(text(),'Skills')]")).Click();

        }

        [When(@"I update the skills")]
        public void WhenIUpdateTheSkills()
        {
            //wait for element Clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 20, "//div[@class='ui bottom attached tab segment tooltip-target active']//tbody[1]//tr[1]//td[3]//span[1]//i[1]", "XPath");

            // Click on the Edit arrow button to Update the skills
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//tbody[1]//tr[1]//td[3]//span[1]//i[1]")).Click();

            //Enter skill in "Add Skill' textbox
            var AddSkill = Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            AddSkill.Clear();
            AddSkill.SendKeys("Tutor");

            //Choose skill level from the dropdown-list
            Driver.driver.FindElement(By.XPath("//select[@name='level']//option[contains(text(),'Expert')]")).Click();

            //After choosing Skill and Skill Level, Click on the Update button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

        }

        [Then(@"that updated skills should be displayed on my listings")]
        public void ThenThatUpdatedSkillsShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Update a skills");

                Thread.Sleep(1000);
                string ExpectedValue = "Tutor";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been updated']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Skills Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsUpdated");
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

        #region Delete Skills Feature
        [Given(@"I click on the skills tab under Profile")]
        public void GivenIClickOnTheSkillsTabUnderProfile()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//*[@id='account-profile-section']//a[contains(text(),'Skills')]");

            //Click on the Skills tab 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']//a[contains(text(),'Skills')]")).Click();
        }
        
        [When(@"I delete the skills that I have added perviously")]
        public void WhenIDeleteTheSkillsThatIHaveAddedPerviously()
        {
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver,20, "//tbody[2]//tr[1]//td[3]//span[2]//i[1]", "XPath");

            //Click on remove icon to delete the skills that I have added previously.
            Driver.driver.FindElement(By.XPath("//tbody[2]//tr[1]//td[3]//span[2]//i[1]")).Click();
        }
        
        [Then(@"that deleted skills should not be displayed on my listings")]
        public void ThenThatDeletedSkillsShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Delete a skills");

                Thread.Sleep(1000);
                string ExpectedValue = "Tester";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been deleted']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Skills Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsDelted");
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