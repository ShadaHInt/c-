Feature: Search

A short summary of the feature

@tagSearch1
Scenario: Valid search
	Given user navigated to the online medical store homepage
	When user enters valid text in search box and click search
	Then click on search button
	When the user select the item searched 
	Then user prints the name of the product



@tagSearch2
Scenario: Invalid search
    Given user navigated to the online medical store homepage
	When user enters invalid text in search box and click search
	Then click on search button and then prints the error message
	
