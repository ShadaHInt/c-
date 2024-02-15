Feature: Login Feature1

A short summary of the feature

@tag1
Scenario: Login
	Given User is at the Home Page
	And Navigate to LogIn Page
	When The user enter UserName and Password
	And Click on the LogIn button
	Then Successful LogIN message should display
