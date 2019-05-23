Feature: Login

@Test
Scenario: Verify the user is allowed to enter application using valid user name and the password
	Given I have navigated to the login screen
	When I enter username and the password and i clicked the login button
	| UserName | Password |
	| your name| your wpd|
	Then I should click the myleave button
