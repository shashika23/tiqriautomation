Feature: Login

@Test
Scenario: Verify the user is allowed to enter to the application using valid user name and the password
	
	Given I enter username and the password and i clicked the login button
	| UserName | Password |
	| Shashika | Zn1heZ   |
	When I should click the myleave button
	Then I see the my leave
