Feature: HomePageVerification

Verifying the features present in the home page

@tag1
Scenario: Verify Amazon home page
	Given user navigated to url "https://www.amazon.in/"
	When verify the AMAZON logo
	When verify the Select your address is displayed
	When verify the Returns and orders is displayed
	When verify the functionality of forward and backward button
	When verify if search bar is enabled
	Then user type pen in search and click search
	
	
