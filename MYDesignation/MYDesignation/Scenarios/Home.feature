Feature: Home

To verify home page

@tag1
Scenario: Verify home page
	Given user navigate to noon application "https://www.noon.com/"
	When Noon logo displyayed
	When sign in symbol displayed
	When cart diplayed
	When cashback banner displayed
	When search bar is enabled
	When user clicks forward and backward button
	Then categories in slider displayed
