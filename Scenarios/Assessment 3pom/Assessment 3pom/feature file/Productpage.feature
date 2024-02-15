Feature: Productpage

A short summary of the feature

@tag1
Scenario: product page of hopscotch
	Given User navigated to the product page
	When  user clicks on the check pincode 
    Then user  validate it and verify it
	When user clicks on the add to cart button
	Then user select go to cart button
	When user verify the count of the items left and select the quantity according to the availability
	Then user Print the Total cost and the delivery date and Remove the item and verify the message Cart is empty and There's nothing in here.
	
	


