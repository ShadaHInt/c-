Feature: Search

Verify search functionality

@tag1
Scenario: Verify search functionality
	Given user navigates the url "https://www.noon.com/"
	When user searches bag and selects women's sling bag
	When user clicks sort by dropdown and selects price low to high
	When user clicks display dropdown and changes per page product number
	When user searches for shoes and selects shoes for men
	Then user clicks on size dropdown and selects size
