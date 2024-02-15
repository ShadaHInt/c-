Feature: VerifyCategories

To Verify categories in home page

@tag1
Scenario: Verify categories in home page
	Given user navigated to noon application "https://www.noon.com/"
	When all categories are displayed
	Then mouse hover on Women dropdown
