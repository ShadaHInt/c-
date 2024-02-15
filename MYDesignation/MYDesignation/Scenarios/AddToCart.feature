Feature: AddToCart

Add product to cart from signed in account

@tag1
Scenario: Add product to cart from signed in account
	Given user navigate "https://www.noon.com/" 
	When user clicks sign in symbol
	When user enters fields and clicks sign in button
	When user searches for shoes for men
	When user selects size and sorts by rating and clicks on first product
	When user clicks on rating ang prints review
	When user add to cart
	Then user clicks checkout and removes product from cart

