Feature: Homepage

A short summary of the feature

@Tag1
 Scenario: Display
	Given navigated to the online medical store homepage
	When user verifies category is displayed
	Then user verifies ayurvedhic medicine  is displayed
	When user user verifies homeo medicine is displayed
	Then user verifies brand is displayed
	When user verifies blog is displayed
	Then user verfies coupon is displayed and prints the coupon text
	When user verifies profile button is displayed
	Then user verifies whishlist is displayed
	When user verifies bag is displayed
	Then user verify logo is displayed
	

@Tag2
 Scenario: Selecting
         
    Given navigated to the online medical store homepage
    When user selects the first element in the featured product and click on add to cart
    Then user selects the first element in the new arrival and click on add to cart
    #When user clicks on cart button and remove the first element


@Tag3
 Scenario:Blog
    Given navigated to the online medical store homepage
    When user clicks on first element in the latest news
    Then  verify navigated to the correct url 
    When user prints the title of the blog
	Then user back navigate to homepage
