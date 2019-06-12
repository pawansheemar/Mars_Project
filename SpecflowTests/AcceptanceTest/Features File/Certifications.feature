Feature: Certifications
	In order to update my profile
	As a skill trader
	I want to add my Ceritfications that I have done

@mytag
Scenario: Check if user able to add his/her Certifications
	Given I clicked on the Certifications tab under the profile page
	When I add certifications
	Then that certifications should be added on the listings

Scenario: Check if user able to Update Certifications
	Given I click on the Certifications tab under Profile page
	When I edit the certifications
	Then that updated certifications should be displayed on my listings

Scenario: Check if user able to Delete the certifications
	Given I click on the Certifications tab under Profile
	When I delete the certifications that I have added perviously
	Then that deleted certifications should not be displayed on my listings