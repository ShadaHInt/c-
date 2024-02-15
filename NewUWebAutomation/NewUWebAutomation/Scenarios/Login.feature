Feature: Login

A short summary of the feature

@LoginTestNegative
Scenario: Login test Negative
	Given the user is navigated to url "https://www.newu.in/"
	Then the user clicks on user icon
	When the user enters wrong email and password
	Then the user enters clicks on Login and verify the error message


@LoginTestPositive
Scenario: Login test Positive
	Given the user is navigated to url "https://www.newu.in/"
	Then the user clicks on user icon
	When the user enters correct email and password
	Then the user prints account details