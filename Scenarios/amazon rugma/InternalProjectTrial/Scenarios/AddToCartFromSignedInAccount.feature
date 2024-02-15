Feature: AddToCartFromSignedInAccount

A short summary of the feature

@tag7
Scenario: User add product to cart from signed in account of Amazon
	Given user navigate Amazon url "https://www.amazon.in/"
	When user clicks on sign in
	When user enters mobile no and click continue
	When user enters the password and click sign in
	When user searches for Women tops
    When user clicks on the first product and mouse hover on the review drop down and select See all customer reviews
	When user select size from Select drop down
	When user click Add to cart and click go to cart button
	Then user prints product title
	
