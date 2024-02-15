Feature: Feature1

A short summary of the feature

@Homepage
Scenario: Homepage of Big Basket
	Given The user is navigated to bigbasket
	When the shopby category is located
	Then category displayed is verified
	When verifying the pincode is displayed
	Then extract the pincode
    When Click on Shop By Category->Beverages
	Then open the first product and display the price and rating os first product
	When Click on Shop by category ->Cleaning and household
	Then Print price of first product and add to cart
	When Click on my cart
	Then print the price present in it


@SecondTestCase
Scenario: Homepage of bigbasket
Given The user is navigated to bigbasket
When The user clicks on offer button
Then user prints the price of second product
