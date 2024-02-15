Feature: AllDropdown

A short summary of the feature

@tag3
Scenario: Verify All categories dropdown
	Given user navigate to url "https://www.amazon.in/"
	When user click on All category
	When user clicks best sellers
	When user clicks All category
	When user clicks Kindle E-Readers & eBooks
	Then user clicks All-new Kindle
