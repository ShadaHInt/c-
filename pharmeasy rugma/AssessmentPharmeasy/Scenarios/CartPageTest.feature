Feature: CartPage

Add product to cart and delete it from cart

@PharmeasyCart
Scenario: Add to cart and delete product from cart
	Given user navigates "http://www.pharmeasy.in"
	When user adds product to cart
	When user select product quantity
	When user clicks view cart
	When user print the price
	When user click on Apply coupon 
	When user select the second coupon available
	When user enter an invalid phone number 
	When user verify the error message
	When user close the otp screen
	When user delete the product added
	When user verifies error message
	Then user quit app
