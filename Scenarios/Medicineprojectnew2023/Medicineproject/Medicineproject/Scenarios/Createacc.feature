Feature: Createacc

A short summary of the feature

@tagCreateaccount1
Scenario: Create account with positive test case
	Given the user is navigated to the homepage of the onlinemedical store
	When user clicks on Create an account icon
	Then user enters firstnameone lastnameone emailone passwone and cpasswone
	When user clicks on create an account


@tagCreateaccount2
Scenario: Create account with negative test case
	Given the user is navigated to the homepage of the onlinemedical store
	When user clicks on Create an account icon
	Then user enters firstnametwo lastnametwo emailtwo passwtwo and cpasswtwo
	When user clicks on create an account