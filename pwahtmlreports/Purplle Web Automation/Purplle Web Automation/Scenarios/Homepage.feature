Feature: Homepage

A short summary of the feature

@Home
Scenario: Home page
	Given the user is Navigated to url "https://www.purplle.com/"
	When the user verifies wheather navigated to correct url
	Then the user verifies the USECODE APPFIRST displayed 
	When user checks the main banner is displayed
	Then  the user clicks on support and prints  Hi How can we help 
	When the user Navigates back and checks logo is present 
	Then click on the cart button and verify it is empty

