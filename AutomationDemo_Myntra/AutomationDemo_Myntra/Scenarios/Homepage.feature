Feature: Homepage

A short summary of the feature

@tag1
Scenario: VerifyIcon
	Given User Navigated to the Homepage
	When  User verify the Title
	Then  Icon should be displayed

@tag2
Scenario: SelectWishlist
	Given User Navigated to the Homepage
	When  Wishlist is selected
	Then  Verify Wishlist page

@tag3
Scenario: CartDisplayed
	Given User Navigated to the Homepage
	When  Cart is selected
	Then  Verify Cart page
	When  Cart Items details listed
	Then  Display the details



