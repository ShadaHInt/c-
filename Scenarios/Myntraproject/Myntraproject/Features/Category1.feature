Feature: Category1

A short summary of the feature

@Category
Scenario: verify category
	Given the homepage of Myntra site
	When user verify Men category is displayed
	Then user verify Women category is displayed
	When user verify Kids category is displayed
	Then  user verifies Beauty category is displayed
	When  user verifies Home and living category is displayed and print perfume subcategory of it
	Then user verifies Studio category is diplayed and click
	When back navigate to homepage
	
