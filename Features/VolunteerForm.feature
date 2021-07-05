Feature: Fusion
	I want to fill up volunteer form and able to perform a search in the new window search box

@mytag
Scenario: Fill in Volunteer sign in form with valid details
	Given I navigate to "http://testautomationpractice.blogspot.com/"
	When I fill in the volunteer form
	And I click the submit button
	Then I should get an error message" Due to storgage space"


	Scenario: Fill in Volunteer sign in form with Invalid Details
	Given I navigate to "http://testautomationpractice.blogspot.com/"
	When I enter First name
	And I enter Last name
	And I enter invalid phone number
	And I enter Country Name 
	And I enter city Name 
	And I enter email
	And I select gender
	And I select available days of the week
	And I select best time to contact from thr dropdown
	And I  upload file
	#And I click on file on file explorer
	#And I click on open
	And I click on submit button
	Then I should get an error message" Due to storgage space"

	Scenario Outline: Volunteer sign in form with invalid examples
	Given I navigate to "http://testautomationpractice.blogspot.com/"
	When I leave first name blank 
	And I enter Last name
	And I enter invalid phone number
	And I Enter Invalid country name
	And I enter Invalid city name
	And I enter invalid email
	And I select gender
	And I select available days of the week
	And I select best time to contact from thr dropdown
	And I click on submit button
	Then I should get an error message" Due to storgage space"

	Examples: 
	| "country name | city name | email                   |
	| "untedkingdom" | "lodon "    | "badmusayoola+1gmail "|
	| "unitedkigdom" |" Esex "     | "badmusayool+2@.com" |


