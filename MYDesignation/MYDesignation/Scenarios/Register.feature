Feature: Register

Register new account

@tag1
Scenario: Register new account positive test case
	Given user navigates to "https://www.noon.com/"
	When user clicks login symbol
	When user selects register and enter fields
	Then user clicks register button

Scenario: Register new account negative test case
	Given user navigates to "https://www.noon.com/"
	When user clicks login symbol
	When user selects register and enters fields
	Then user click register button
