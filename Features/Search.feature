Feature: Search
	Perform a search in the New Window search box

@mytag
Scenario: New SearchBox
	Given I navigate to "http://testautomationpractice.blogspot.com/"
	When I click on the searchbox
	And I type in software"
	And I click on searh button
	And I select on software bug
	Then I should be redirected to wikipedia page