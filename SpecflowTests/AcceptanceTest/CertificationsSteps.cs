using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region Add Certification Feature
    [Binding]
    public class CertificationsSteps
    {
        [Given(@"I clicked on the Certifications tab under the profile page")]
        public void GivenIClickedOnTheCertificationsTabUnderTheProfilePage()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]");

            //click on the "Certification" tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]")).Click();

        }

        [When(@"I add certifications")]
        public void WhenIAddCertifications()
        {
            //wait
            Thread.Sleep(2000);
            //Click on the "Add New" button
            Driver.driver.FindElement(By.XPath("//*[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();

            //Enter "Certifiactions or Award" in the textbox
            Driver.driver.FindElement(By.XPath("//div//input[@placeholder='Certificate or Award']")).SendKeys("ISTQB Certification");

            //Fill the "Certified From" textbox
            Driver.driver.FindElement(By.XPath("//div[@class='eight wide field']//input[@placeholder='Certified From (e.g. Adobe)']")).SendKeys("ISTQB");

            //Choose the "Year" from the dropdown list
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']//option[contains(text(),'2018')]")).Click();

            //Click on the "Add" button
            Driver.driver.FindElement(By.XPath("//div[@class='five wide field']//input[contains(@class,'ui teal button')]")).Click();

        }

        [Then(@"that certifications should be added on the listings")]
        public void ThenThatCertificationsShouldBeAddedOnTheListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Add a Certificationss");

                Thread.Sleep(1000);
                string ExpectedValue = "ISTQB Certifications";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been added']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationsAdded");
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

        #region Update Certification Feauture
        [Given(@"I click on the Certifications tab under Profile page")]
        public void GivenIClickOnTheCertificationsTabUnderProfilePage()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]");

            //click on the "Certification" tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]")).Click();
        }
        [When(@"I edit the certifications")]
        public void WhenIEditTheCertifications()
        {
           
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 20, "//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']", "XPath");
            
            //Click on the arrow button for Update Certificatons
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']")).Click();

            //Enter "Certifiactions or Award" in the textbox
            var Certification = Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            Certification.Clear();
            Certification.SendKeys("Networking CCNA");

            //Fill the "Certified From" textbox
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']")).SendKeys("Cisco");

            //Choose the "Year" from the dropdown list
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']//option[contains(text(),'2015')]")).Click();

            //Click on the "Update" button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();


        }

        [Then(@"that updated certifications should be displayed on my listings")]
        public void ThenThatUpdatedCertificationsShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Add a Certificationss");

                Thread.Sleep(1000);
                string ExpectedValue = "Networking CCNA";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been updated']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationsUpdateded");
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

        #region Delete Certification Feature
        [Given(@"I click on the Certifications tab under Profile")]
        public void GivenIClickOnTheCertificationsTabUnderProfile()
        {
            //Wait for element visible
            CommonMethods.ElementVisible(Driver.driver, "XPath", "//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]");

            //click on the "Certification" tab under Profile page
            Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[contains(text(),'Certifications')]")).Click();

        }

        [When(@"I delete the certifications that I have added perviously")]
        public void WhenIDeleteTheCertificationsThatIHaveAddedPerviously()
        {
            
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 20, "//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='remove icon']", "XPath");

            //Click on the cross button to delete the Certification
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='remove icon']")).Click();
           
        }

        [Then(@"that deleted certifications should not be displayed on my listings")]
        public void ThenThatDeletedCertificationsShouldNotBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Delete a Certificationss");

                Thread.Sleep(1000);
                string ExpectedValue = "Networking CCNA";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*div[@contains(text),'has been deleted']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationsDeleted");
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