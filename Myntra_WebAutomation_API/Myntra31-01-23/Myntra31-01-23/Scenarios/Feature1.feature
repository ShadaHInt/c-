Feature: Feature1

A short summary of the feature

@tag1
Scenario: Myntra
	Given Navigated to the myntra homepage
	When User clicks on shirts on the men category
	When User select the first item in the casual shirts 
	When User needs to select size
	Then User add this item to bag
	When User searches for kurti
    When User select the first element with size small
	When User add this item to the bag
	Then Click on bag to view the list of items
	
