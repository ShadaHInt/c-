Feature: Feature1

A short summary of the feature

@manual
Scenario: Launch Amazon web application
	Given Amazon webpage is launched in chrome browser
	When Google webpage is launched
	Then user quit

	Scenario: Launch Amazon web application test
	Given Amazon webpage is launched in browser
	When Google webpage is back navigate
	Then user quit app
