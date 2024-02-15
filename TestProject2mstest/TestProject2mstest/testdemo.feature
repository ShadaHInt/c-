Feature: testdemo

A short summary of the feature

@tag1
Scenario: Navigation
	Given I have navigated to "https://google.com/"
	When I navigated to "https://amazon.com/"
	Then I can back navigate to "https://google.com/"
	Then I can forward navigate to "https://amazon.com/"
	Then I can refresh the page
