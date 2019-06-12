Feature: Description
	In order to update my profile
	As a skill trade
	I want to add Description regarding hobies and experties

@mytag
Scenario: Check if user is able to add Description
	Given I have clicked on the write icon of Description tab under profile page
	When I press save button
	Then the description deatils should be saved

Scenario: Check if user is able to update Description
     Given I have click on the write icon of Description tab under profile page 
	 When I have entered the new details and press Save button
	 Then the description deatils should be updated

Scenario: Check if characters limit exceeded
      Given I click on the Decription tab under profile page
	  When I try to enter characters more than limit
	  Then the decription should not be saved