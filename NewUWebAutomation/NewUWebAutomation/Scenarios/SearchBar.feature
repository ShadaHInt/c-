Feature: SearchBar

A short summary of the feature

@SearchBar
Scenario: SearchBar
	Given the user is navigated to url "https://www.newu.in/"
	When the user verifies searchbar is displayed
	Then  the user clicks and enters Invalid input 
	When the user enters valid input  
	Then  the user clicks on the logo
