Feature: login

A short summary of the feature

@tag1
Scenario: Login in bigbasket
	When the user is navigated to bigbasket it is validated
    Then the user Click on Login button
    When the user Create negative cases to test signin functionality mobile number as  <MobileNumber> 
    Then the Validations are needed for each of these tests

    Examples:
    | MobileNumber |
    | 0000000000   |
    | 1            |
    | 12222222222  |
    
    
