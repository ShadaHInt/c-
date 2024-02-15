Feature: CreateAccount

A short summary of the feature

@tag1
Scenario: Create account in Amazon negative test case
	Given User navigate the url "https://www.amazon.in/"
	When user clicks sign in
	When user clicks create account
	When user enters name, mobile no, password
	Then user clicks continue
