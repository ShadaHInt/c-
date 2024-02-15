Feature: Search

A short summary of the feature

@Search1
Scenario: invalid input
	Given the homepage of myntra
	When User verifies search box is enabled
	Then user searches for invalid input 
	
@Search2
Scenario: valid input
	Given the homepage of myntra
	When User verifies search box is enabled
	Then user searches for valid input 