Feature: SignIn

A short summary of the feature

@tag6
Scenario: Sign in with an already registered account negative test case
	Given user navigated Amazon url "https://www.amazon.in/"
	When user click on sign in
	When user enter mobileone and click continue
	Then user enter passwordone and click sign in
	
	@tag2
Scenario: Sign in with an already registered account negative test case two
	Given user navigated Amazon url "https://www.amazon.in/"
	When user click on sign in
	When user ente mobiletwo and clicks continue
	Then user enter passwordtwo and click sign in

	@tag3
	Scenario: Sign in with already registered account positive test case
	Given user navigated Amazon url "https://www.amazon.in/"
	When user click on sign in
	When user enter mobilethree and click continue
	Then user enters passwordthree and clicks sign in



