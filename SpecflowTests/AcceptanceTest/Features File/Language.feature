Feature: Language
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

	Scenario: Check if user able to Update language
	Given I click on the Language tab under Profile page
	When I update the language
	Then that updated language should be displayed on my listings

Scenario: Check if user able to Delete the language
    Given I click on the Language tab under Profile
    When I delete the language that I have added perviously
	Then that deleted language should not be displayed on my listings
	