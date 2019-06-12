using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region Availability Feature
    [Binding]
    public class ProfileSteps
    {
        [Given(@"I Clicked on the write icon to add avialability")]
        public void GivenIClickedOnTheWriteIconToAddAvialability()
        {

            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 50, "//div[@class='extra content']//div[2]//div[1]//i[@class='right floated outline small write icon']", "XPath");

            //click on the write icon to select type of availbity 
            Driver.driver.FindElement(By.XPath("//div[@class='extra content']//div[2]//div[1]//i[@class='right floated outline small write icon']")).Click();


        }

        [When(@"I select type of availability")]
        public void WhenISelectTypeOfAvailability()
        {
        
            //click on the selcet type dropdown arrow and then select availabilty
            Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']//option[contains(text(),'Full Time')]")).Click();
        }

        [Then(@"that availability type should be displayed on the listings")]
        public void ThenThatAvailabilityTypeShouldBeDisplayedOnTheListings()
        {
            //The alert message pops-up on the corner of screen "Availability updated"
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Availability");

                Thread.Sleep(1000);
                string ExpectedValue = "As needed";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div//div[@class='ns-box-inner'][contains(text(),'Availability updated')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Availability Updated Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "AvailabilitUpdated");
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

        #region Availabilty Hours Feature
        [Given(@"I clicked on the write icon to add Hours")]
        public void GivenIClickedOnTheWriteIconToAddHours()
        {
           
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 30, "//div[@class='extra content']//div[3]//div[1]//i[@class='right floated outline small write icon']", "XPath");
           
            //click on the write icon to select type of availbity hours
            Driver.driver.FindElement(By.XPath("//div[@class='extra content']//div[3]//div[1]//i[@class='right floated outline small write icon']")).Click();


        }

        [When(@"I select type of availability Hours")]
        public void WhenISelectTypeOfAvailabilityHours()
        {
            //click on the selcet type dropdown arrow and then select availabilty hours
            Driver.driver.FindElement(By.XPath("//select[@name='availabiltyHour']//option[contains(text(),'As needed')]")).Click();
        
    }

        [Then(@"that availability hours type should be displayed on the listings")]
        public void ThenThatAvailabilityHoursTypeShouldBeDisplayedOnTheListings()
        {
            //The alert message pops-up on the corner of screen "Availability updated"
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Availability Hours");

                Thread.Sleep(1000);
                string ExpectedValue = "As needed";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div//div[@class='ns-box-inner'][contains(text(),'Availability updated')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Availability Updated Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "AvailabilitUpdated");
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

        #region Earn Target Feature

        [Given(@"I clicked on the write icon to choose earn target")]
        public void GivenIClickedOnTheWriteIconToChooseEarnTarget()
        {
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 30, "//div[@class='four wide column']//div[4]//div[1]//i[@class='right floated outline small write icon']", "XPath");

            //Click on the write icon to select "Earn Target"
            Driver.driver.FindElement(By.XPath("//div[@class='four wide column']//div[4]//div[1]//i[@class='right floated outline small write icon']")).Click();

        }

        [When(@"I select type of earn target")]
        public void WhenISelectTypeOfEarnTarget()
        {
            //Click on the select type dropdown arrow and then choose Earn target type fron list
            Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']//option[contains(text(),'More than $1000 per month')]")).Click();

        }


        [Then(@"that earn target type should be displayed on the listings")]
        public void ThenThatEarnTargetTypeShouldBeDisplayedOnTheListings()
        {
            //The alert message pops-up on the corner of screen "Earn Target updated"
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Earn Target");

                Thread.Sleep(1000);
                string ExpectedValue = "As needed";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div//div[@class='ns-box-inner'][contains(text(),'Availability updated')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Availability Updated Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "AvailabilitUpdated");
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