Feature: Aftersignin

A short summary of the feature

@tagAddtoCart
Scenario: Add to cart
	Given user navigated to the online medical store homepage
	When when user sign in
	Then user verifies whether welcome message is printed
	When user mouse hover on categories 
	Then user mouse hover on the first aid and health care an then on cough cold an flu
	When user clicks on quantity button and prints product details and price
	Then user add the item to cart
	When user mouse hover on homeo and select an element print description price and add it to cart
	Then user again mouse hover on category and then baby care and then over baby gripe water
	When user prints price description and add it to cart
	Then user mouse hover on category then protein and on weight loss
	When user selects a range and select an element then added it to the cart
	Then user mouse hover homeo then disease and then children
	When user selects price range and then click on the element print price and add to cart
	Then user clicks on google icon and then selects user and enters password

@tagPayment
Scenario: Payment
    Given user navigated to the online medical store homepage
	When when user sign in
	Then user mouse hover on categories and then on first aid and on health device 
	When again mouse hover on health instruments and on thermometer
	Then clicks on add to cart
	When user clcik on bag button and then on checkout button
	Then user enters all the credentials required
	When user clicks on next option
	Then user selects a payment option and proceed it 



