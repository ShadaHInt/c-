Feature: SearchButton

To search a product and add to cart

@PharmeasySearch
Scenario: To search a product and add to cart
	Given navigate to "http://www.pharmeasy.in"   
	When user serach shampoo in search box
	When user select the third product displayed
	When user print the name of the product
	When user list the details of pack sizes available
	When user click add to cart
	When user select quantity of product
	When user click on View Cart
	Then user quit application 
