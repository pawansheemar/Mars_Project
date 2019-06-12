Feature: Education
	In order to update my profile
	As a skill trade
	I want to add the Education that I have done

@mytag
Scenario: Check if user able to add his/her Education
	Given I clicked on the Education tab under profile page
	When I add education
	Then that Education should be displayed on my listings

Scenario: Check if user able to Edit his/her Education
	Given I click on the Education tab under Profile page
	When I edit the education
	Then that updated education should be displayed on my listings


Scenario: Check if user able to Delete the Education
    Given I click on the Education tab under profile page
	When I delete the Education that I have added perviously
	Then that deleted education should not be displayed on my listing
