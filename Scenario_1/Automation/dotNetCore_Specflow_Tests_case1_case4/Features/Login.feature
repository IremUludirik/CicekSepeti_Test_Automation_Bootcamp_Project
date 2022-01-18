Feature: MIZU success login scenarios
MIZU success login scenarios with different email and password

Background: First of all login page should be open
	Given Firstly I am on home page
	And I am on login page
	
@Positives
Scenario Outline: Success login
	When I enter the <email> and <password> information	
	And I click Sign In button
	Then I see My Account button
	And I log out
Examples:
		| email                              | password    |
		| user.deneme444@gmail.com           | 12345       |
		| user.deneme.robotdegilim@gmail.com | abcdef      |
		| user.deneme.user1234@gmail.com     | çiçeksepeti |
    



