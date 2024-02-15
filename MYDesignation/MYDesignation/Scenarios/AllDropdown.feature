Feature: AllDropdown

Verify All drop down

@tag1
Scenario: Verify All drop down
	Given user navigate noon application "https://www.noon.com/"
	When user mouse hovers on all category
	When user mouse hovers electronics and clicks mobiles
	When user clicks on tablets
	Then user clicks view all
