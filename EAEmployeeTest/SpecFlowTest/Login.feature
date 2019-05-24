
Feature: Login feature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario:01 Verify the user is allowed to enter to the application using valid user name and the password
	
	Given I enter username and the password and i clicked the login button
	| UserName | Password |
	| Shashika | v4@XBU   |
	When I should click the myleave button
	Then I see the my leave
