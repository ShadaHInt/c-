Feature: Categoriespage

A short summary of the feature

@Category
Scenario: Categories page
	Given the user is navigated to url "https://www.newu.in/"
	When the user verifies menu bar 
	Then user checks Jaquline usa is displyed and prints the text
	When  the user mousehover to shop makeup and clicks on foundation
	Then the user navigates back and mousehover to hair and clicks on hair brushes

