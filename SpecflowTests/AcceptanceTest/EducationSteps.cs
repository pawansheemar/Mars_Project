using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region Add Education Feature
    [Binding]
    public class EducationSteps
    {
        [Given(@"I clicked on the Education tab under profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            
            //Wait for element visible
             CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@id='account-profile-section']//a[contains(text(),'Education')]");
           
            //Click on the Education tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//a[contains(text(),'Education')]")).Click();

        }

        [When(@"I add education")]
        public void WhenIAddEducation()
        {
            //Click on AddNew button 
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();

            //Add Education
            Driver.driver.FindElement(By.XPath("//div[@class='ten wide field']//input[@placeholder='College/University Name']")).SendKeys("AUT");

            //Choose "Country of College/University"
            Driver.driver.FindElement(By.XPath("//select[@name='country']//option[contains(text(),'New Zealand')]")).Click();

            //Choose "Tittle" of course form the dropdown list
            Driver.driver.FindElement(By.XPath("//select[@name='title']//option[contains(text(),'B.Tech')]")).Click();

            //Click on the "Degree" textbox, to add yor Degree in the list
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']")).SendKeys("Information Technology");

            //Choose the "Year of graduation" from the dropdown-list
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']//option[contains(text(),'2017')]")).Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
        }

        [Then(@"that Education should be displayed on my listings")]
        public void ThenThatEducationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Education");

                Thread.Sleep(1000);
                string ExpectedValue = "Bachelor in IT";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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

    #region Update Education Feature
        [Given(@"I click on the Education tab under Profile page")]
        public void GivenIClickOnTheEducationTabUnderProfilePage()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@id='account-profile-section']//a[contains(text(),'Education')]");

            //Click on the Education tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//a[contains(text(),'Education')]")).Click();


        }
        [When(@"I edit the education")]
        public void WhenIEditTheEducation()
        {
            //wait for element clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 10, "//tbody[1]//tr[1]//td[6]//span[1]//i[1]", "XPath");

            //Click on write icon button for update the Education 
            Driver.driver.FindElement(By.XPath("//tbody[1]//tr[1]//td[6]//span[1]//i[1]")).Click();


            //Update Education and enter new input in the textbox
            var UpdateEducation = Driver.driver.FindElement(By.XPath("//div[@class='ten wide field']//input[@placeholder='College/University Name']"));
            UpdateEducation.Clear();
            UpdateEducation.SendKeys("Massey University");

            //Update "Country of College/University" 
            Driver.driver.FindElement(By.XPath("//select[@name='country']//option[contains(text(),'Australia')]")).Click();

            //Update the "Tittle" of course form the dropdown list
            Driver.driver.FindElement(By.XPath("//select[@name='title']//option[contains(text(),'M.Tech')]")).Click();

            //Click on the "Degree" textbox, to add yor Degree in the list
            Driver.driver.FindElement(By.XPath("//div//div//input[@placeholder='Degree']")).SendKeys("Information Technology");

            //Update the "Year of graduation" from the dropdown-list
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']//option[contains(text(),'2015')]")).Click();

            //Click on Update button 
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
        }

        [Then(@"that updated education should be displayed on my listings")]
        public void ThenThatUpdatedEducationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Education");

                Thread.Sleep(1000);
                string ExpectedValue = "Massey University";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationUpdated");
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

    #region Delete Education Feature
        [Given(@"I click on the Education tab under profile page")]
        public void GivenIClickOnTheEducationTabUnderprofilePage()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@id='account-profile-section']//a[contains(text(),'Education')]");

            //Click on the Education tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']//a[contains(text(),'Education')]")).Click();

        }

        [When(@"I delete the Education that I have added perviously")]
        public void WhenIDeleteTheEducationThatIHaveAddedPerviously()
        {
            
            //Wait for the element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 10, "//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='remove icon']", "XPath");

            //click on the cross icon to delete the Education fron listing
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='remove icon']")).Click();

        }

        [Then(@"that deleted education should not be displayed on my listing")]
        public void ThenThatDeletedEducationShouldNotBeDisplayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Education");

                Thread.Sleep(1000);
                string ExpectedValue = "Massey University";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationDelteted");
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
