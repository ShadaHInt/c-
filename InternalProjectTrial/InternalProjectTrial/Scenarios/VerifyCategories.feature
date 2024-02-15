Feature: VerifyCategories

A short summary of the feature

@tag2
Scenario: Verify categories in Amazon homepage
	Given user navigates to url "https://www.amazon.in/"
	When all categories are displayed
	Then mouse hover on Prime dropdown
