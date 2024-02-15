Feature: AlarmFeature

A short summary of the feature

@tag1
Scenario: Set New Alarm
	Given Alarm App is opened
	When Click on Add Icon
	Then  Set the Alarm Time
	When The save icon is choosed
	Then Alarm should be set


Scenario: Set New Alarm and Edit
	When I Click on the Existing alarm
	Then Edit the time
	When I save the alarm
	Then Alarm should be updated


Scenario: Turn off the Alarm
   
	When I Click on the Existing alam switch to Off
	Then Alarm should be disabled

