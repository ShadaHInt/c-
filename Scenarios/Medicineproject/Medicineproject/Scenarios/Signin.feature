Feature: Signin

A short summary of the feature

@tagSignin1
Scenario: Signin positive test case
	Given user navigated to the online medical store homepage
	When the user clicks on the sign in button
	Then the user enters emailone and passone
	When user selects the sign in button

@tagSignin1
Scenario: Signin negative test case
	Given user navigated to the online medical store homepage 
	When the user clicks on the sign in button
	Then the user enters emailthree and passthree
	When user selects the sign in button




