Feature: Homepage

Homepage of Newu

@Home
Scenario: Homepage of NewU Website
	Given the user is navigated to url "https://www.newu.in/"
	When  the user verifies whether navigated to correct url
	Then  the user verifies logo is present
	When  the user verifies the main banner is present
	Then  the user verifies gift icon present or not
	When  the user prints the description about newu at bottom of page
	Then  the user clicks on contact us and prints contact details
	
