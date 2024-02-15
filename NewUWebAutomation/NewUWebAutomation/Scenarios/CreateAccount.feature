Feature: CreateAccount

A short summary of the feature

@signupInvalid
Scenario: Create New Account with invalid data
	Given the user is navigated to url "https://www.newu.in/"
	When the user clicks on Create an account
	Then the user provides invalid first name and last name
	When the user provides invalid email and password
	Then the user prints the error message

@signupValid
Scenario: Create New Account with valid data
     Given the user is navigated to url "https://www.newu.in/"
	 When the user clicks on Create an account
	 Then the user provides valid first name and last name
	 When the user provides valid email and password
	 Then the user clicks on user icon