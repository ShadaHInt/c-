Feature: Homepagefeature1

A short summary of the feature

@tag1
Scenario: navigated to webpage
	Given the website of the page
	When verify the logo header
	Then verify the coupon code displayed
	When Verify the options are displayed
	Then user clicks on loctation button and send valid pincode and select login button and verify the pincode displayed
	When user search icecream and verify it
	Then login icon and try entering atleast three different invalid phone number combinations and verify the error message displayed <examples>
	When user clicks on menu
	Then hover over phones and variables and then mobile phone ,iphone
	When Click on first product 
	Then display all features
	When user add to cart
	Then user click on apply coupon
	And user verify the alert message and print message

	Examples:

	| examples  |
	| 00000     |
	| 1111111   |
	| 222222222 |
