Feature: AddItems

A short summary of the feature

@AddItems
Scenario: Add Items to Cart
	Given the user is navigated to url "https://www.newu.in/"
	Then the user clicks on user icon
	When the user enters correct email and password
	When  the user mousehover to shop makeup and clicks on foundation
	Then the user adds first product to the cart
	Then the user navigates back and mousehover to hair and clicks on hair brushes 
	Then the user adds first product to the cart
	When  the user mousehover to the shop skin and clicks on Lip balm
	Then the user adds first product to the cart
	When the user mousehover to shop bath and body and clicks on sunscreen
	Then the user adds first product to the cart
	When the user clicks on proceed to checkout
	Then the user prints the total amount
