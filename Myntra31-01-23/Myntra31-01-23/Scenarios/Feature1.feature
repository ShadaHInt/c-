Feature: Feature1

A short summary of the feature

@tag1
Scenario: Myntra
	Given navigated to the myntra homepage
	When user clicks on shirts on the men category
	Then select the first item in the casual shirts 
	When user needs to select size and user add this item to bag
	Then user searches for kurti
    When select the first element with size small and add it to bag
	Then click on bag