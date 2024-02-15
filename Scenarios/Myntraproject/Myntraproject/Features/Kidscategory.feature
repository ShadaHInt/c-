Feature: Kidscategory

A short summary of the feature

@Kidscategory
Scenario: Kids category
	Given user is navigated to the homepage of myntra
	When user mouse hover over kids category
	Then user verifies on Tshirt under Boys clothing is displayed and validate whether equal
	When user verifies Tops under Girls clothing is displayed
	Then user verifies Casual shoes under footwear is diaplayed and validate whether equal
	When user verifies Body suit under Infant is displayed
	Then user clicks on Body suit and print text Kids Wear Online Store
