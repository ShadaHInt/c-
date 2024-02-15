Feature: SearchItem

A short summary of the feature

@tag1
Scenario: SearchedforSunscreen
	Given User select the MyntraHomepage
	When user enter an item in the search box
	Then the search icon is selected
	When user verify the URL
    Then select an item
	When Add to bag is selected
	Then Item should be added to bag

@tag2
Scenario:SerachedforInvalidItem
	Given User select the MyntraHomepage
	When user enter an Invalid item in the search box
	Then  Verify Error message is displayed

