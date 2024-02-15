Feature: Homepage

A short summary of the feature

@tag1
Scenario: Given the website of tatacliq
	Given The user is navigated to url
	When verify the logo header
	Then verify the discount cuopon displayed
	When verify the options are dispalyed
	Then Mouse hover Categories to Kid'sFashion to BoysClothing and click on Shirts and verify the text Kids Boys Clothing Shirts is displayed
@tag2
Scenario: Given the shopage
    Given the shopage 
	When Select the color black 
	Then click on the second item displayed
	When Print the original price without Discount and select one of the available sizes
	Then  Add to Bag and Go To Bag
	

