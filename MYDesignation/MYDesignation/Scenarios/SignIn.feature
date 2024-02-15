Feature: SignIn

Sign in with an already registered account

@tag1
Scenario: Sign in with an already registered account negative test cases
	Given user navigate to "https://www.noon.com/" 
	When user click sign in symbol
	Then user enters fields and clicks sign in button
@tag1
Scenario: Sign in with an already registered account positive test cases
	Given user navigate to "https://www.noon.com/" 
	When user click sign in symbol
	Then user enter fields and clicks sign in button