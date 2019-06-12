using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    #region Add Description Feature
    [Binding]
    public class DescriptionSteps
    {
        [Given(@"I have clicked on the write icon of Description tab under profile page")]
        public void GivenIHaveClickedOnTheWriteIconOfDescriptionTabUnderProfilePage()
        {
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 10, "//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']", "XPath");
           
            //Click on the write icon to write "Description" regarding skills
            Driver.driver.FindElement(By.XPath("//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']")).Click();
        }

        [When(@"I press save button")]
        public void WhenIPressSaveButton()
        { //Enter description in the texbox
            var Add_Description = Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
            Add_Description.Clear();
            Add_Description.SendKeys("I have 1 year experience with Automation testing and ISTQB certification as well. Back in India I have worked as Developer.");

            //click on the "Save" button
            Driver.driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")).Click();
        
    }

        [Then(@"the description deatils should be saved")]
        public void ThenTheDescriptionDeatilsShouldBeSaved()
        {
            //Description should be added
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "Add a Description");

                Thread.Sleep(1000);
                string ExpectedValue = "I have 1 year experience with Automation testing and ISTQB certification as well. Back in India I have worked as Developer.";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(text),'Description has been saved successfully']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Description Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "DescriptionAdded");
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

    #region Update Description Feature

        [Given(@"I have click on the write icon of Description tab under profile page")]
        public void GivenIHaveClickOnTheWriteIconOfDescriptionTabUnderProfilePage()
        {
           
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 10, "//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']", "XPath");

            //Click on the write icon to update "Description" regarding skills
            Driver.driver.FindElement(By.XPath("//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']")).Click();

    }
        [When(@"I have entered the new details and press Save button")]
        public void WhenIHaveEnteredTheNewDetailsAndPressSaveButton()
        {
        //Updata description details in the texbox
        var Update_Description = Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        Update_Description.Clear();
        Update_Description.SendKeys("I have 3 year experience as Java Developer and certification as well.");

        //click on the "Save" button
        Driver.driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")).Click();
    }




        [Then(@"the description deatils should be updated")]
        public void ThenTheDescriptionDeatilsShouldBeUpdated()
        {
        //New description displayed on the listing
        try
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest(Name: "Update a Description");

            Thread.Sleep(1000);
            string ExpectedValue = "I have 3 year experience as Java Developer and certification as well.";
            string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(text),'Description has been saved successfully']")).Text;
            Thread.Sleep(500);
            if (ExpectedValue == ActualValue)
            {
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Updated a Description Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "DescriptionUpdated");
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

    #region enter characters more than 600 limit

        [Given(@"I click on the Decription tab under profile page")]
        public void GivenIClickOnTheDecriptionTabUnderProfilePage()
        {
            
            //Wait for element to be clickable
            CommonMethods.waitUntilElementClickable(Driver.driver, 10, "//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']", "XPath");

            //Click on the write icon to update "Description" regarding skills
            Driver.driver.FindElement(By.XPath("//div[@class='eight wide column']//h3[@class='ui dividing header']//i[@class='outline write icon']")).Click();

        //clear the text-box
         Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        

    }
        [When(@"I try to enter characters more than limit")]
        public void WhenITryToEnterCharactersMoreThanLimit()
        {
            //Entering more than 600 character
            var Char = Driver.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
            Char.Clear();

            Char.SendKeys("I have 3 year experience as Java Developer and certification as well. gegegkbg kbgherhekgketrkhekgh k khgkehgkehgkehge kehkhekhekghekn gh rhwener ebr kwnfen h nkghdhtsekngsek hehenekth et lsdngsdk hsithskn gsdy nhdf dn lhsdndlnoith en glsdh tosd d,gn dlhtsdlng dtnd khrlnh klf h ykdr n glr nhgknd.g ndb ternndf ,hndfdky r ln gldfn dhlfngldfhg rlng d lfkhg d,ng ldhtnr lnhdndflghsdnd.n gkdngdnkg dn ,gndklxdngldhtldng.,dn knd,gdngdhtkdng,xnk gdngxdk gndgldnlgndhkzdntlsentdente.ntseng,sdnglnlndylnkngng dlh nthniorotneprld dl ljlnt rl n lnlr lntljyemoelnyslneotnelntldnylrtlsdngrohtelntlentldn eljte gdg  d ngdkgdkn ksd nksdngsdk ndngdknh sdgndhnd");
            //click on the "Save" button
            Driver.driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")).Click();

        }

        [Then(@"the decription should not be saved")]
        public void ThenTheDecriptionShouldNotBeSaved()
        {
            //User can only enter 600 characters in the texbox.
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest(Name: "characters limit");

                Thread.Sleep(1000);
                string ExpectedValue = "I have 3 year experience as Java Developer and certification as well. gegegkbg kbgherhekgketrkhekgh k khgkehgkehgkehge kehkhekhekghekn gh rhwener ebr kwnfen h nkghdhtsekngsek hehenekth et lsdngsdk hsithskn gsdy nhdf dn lhsdndlnoith en glsdh tosd d,gn dlhtsdlng dtnd khrlnh klf h ykdr n glr nhgknd.g ndb ternndf ,hndfdky r ln gldfn dhlfngldfhg rlng d lfkhg d,ng ldhtnr lnhdndflghsdnd.n gkdngdnkg dn ,gndklxdngldhtldng.,dn knd,gdngdhtkdng,xnk gdngxdk gndgldnlgndhkzdntlsentdente.ntseng,sdnglnlndylnkngng dlh nthniorotneprld dl ljlnt rl n lnlr lntljyemoelnyslneotnelntldnylrtlsdngrohtelntlentldn eljte gdg  d ngdkgdkn ksd nksdngsdk ndngdknh sdgndhnd";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(text),'Please, enter a less characters']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Please, enter less characters");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CharactersLimit");
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