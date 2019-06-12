Feature: Skills
	In order to update my profile
	As a skill trader
	I want to add the skills that I know

@mytag
Scenario: Check if user able to add a Skills
	Given I Clicked on the skills tab under Profile page
	When I add new skills
	Then that skills should be displayed on my listing

Scenario: Check if user able to Update Skills
	Given I click on the Language tab under profile
	When I update the skills
	Then that updated skills should be displayed on my listings

Scenario: Check if user able to Delete the skills
    Given I click on the skills tab under Profile
    When I delete the skills that I have added perviously
	Then that deleted skills should not be displayed on my listings

	                                                          
        
