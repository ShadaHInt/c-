Feature: Home Page Test

A short summary of the feature

@tag1
Scenario: Homepage test
	Given I navigated to Nykaa
	When  I verify the whether navigated to the correct url
	Then I must view the logo
	When I click on Account icon
	Then click onthe Phone/email button

Scenario: Validations
  Given I am in login screen
  When I enter the invalid phone number
  And I click on the Proceed button
  Then I must see  validation 'Enter a valid mobile number'