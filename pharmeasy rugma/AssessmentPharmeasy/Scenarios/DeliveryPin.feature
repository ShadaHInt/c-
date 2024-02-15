Feature: DeliveryPin

To add a new pincode

@pharmeasyPin
Scenario: To add a new pincode to delivery
	Given user navigated to "http://www.pharmeasy.in"
	When click on Delivery to select Pin code
	When enter pin code as "333"
	When error message displayed
	When enter valid pin code 
	When verify new pincode
	Then user quits app
