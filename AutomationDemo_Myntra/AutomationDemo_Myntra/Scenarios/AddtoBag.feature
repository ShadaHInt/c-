Feature: AddtoBag

A short summary of the feature

@tag1
Scenario: SelectanItem
	Given User select the Myntra website
	When  User search for Tops
	Then  Results should be displayed

@tag1
Scenario: Apply Filter
	Given User select the Myntra website
	When  User search for Tunics
	Then  Results should be displayed
	When  Any Filter selected
	Then  verify filter is applied

@tag1
Scenario: Select a Kurti
	Given User select the Myntra website
	When  User search for Kurti
	Then  Kurtis Results should be displayed
	When  A Kurtis is selected
	Then  Select a size
	When Add to bag is selected
	Then Add the kurti to the cart

