Feature: Homepage

A short summary of the feature

@tag1
Scenario: Navigate to pharmeasy application
	Given the user is navigated to "http://www.pharmeasy.in"
	When  the user can see categories
	Then user quit the application
