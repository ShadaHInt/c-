Feature: jeepfeaturefile

A short summary of the feature

@tag1
Scenario: Jeep App Testing
	Given Appium call to the mobile app Jeep
	When The Jeep app is opened
	When Accept all the permissions
	

	Scenario: report testing
	When navigate to the demo mode
	When click the report option
	When perform scroll
	Then return back to the home page

	Scenario: Speed alert
	
	When home page is opened
	When click on the speed
	When create new speed alert
	When delete the created alert with name Testing Alert
	Then close the app


