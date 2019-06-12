Feature: Profile
	 In order to update my profile
	As a skill trade
	I want to add the Profile details


@mytag
Scenario: Check if user able to Add a Availabilty
	Given I Clicked on the write icon to add avialability 
	When I select type of availability
	Then that availability type should be displayed on the listings

Scenario: Check if user is able to add availability Hours
     Given I clicked on the write icon to add Hours
	 When I select type of availability Hours
	 Then that availability hours type should be displayed on the listings

Scenario: check if user able to choose Earn Target
      Given I clicked on the write icon to choose earn target
	  When I select type of earn target
	  Then that earn target type should be displayed on the listings


