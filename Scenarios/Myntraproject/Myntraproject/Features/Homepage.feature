Feature: Homepage

A short summary of the feature

@Homepage
Scenario: Homepage of myntra
	Given the user is navigated to myntra homepage
	When user verifies whether navigated to the correct url
	Then user validate the myntra logo in the header
	When user verifies coupon code is displayed
	Then user verifies profile button is displayed
	When user verifies bag button is displayed
	Then clicks on the bag button
