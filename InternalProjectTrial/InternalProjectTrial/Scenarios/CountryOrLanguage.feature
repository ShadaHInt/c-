Feature: CountryOrLanguage

Change country or language

@tag4
Scenario: Change country or language settings
	Given user navigate url "https://www.amazon.in/"
	When user mouse hovers on flag icon
	When user selects language radio button
	When user hovers on flag icon and clicks change country or region
	When user clicks India drop down and select new country  
	Then user click Go to website
