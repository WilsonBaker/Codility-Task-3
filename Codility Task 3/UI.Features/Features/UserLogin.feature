@UserLoginUI @UIRegression
Feature: UserLogin
	Simple calculator for adding two numbers


Scenario: Login - Login with existing valid username and password
	Given User visits home page
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username ''

Scenario: Register - User successuflly created and then login
	Given User visits home page
	When User registers with username 'TestUser' and password 'TestPassword123'
	And User logs in with username 'TestUser' and password 'TestPassword123'
	And User submits the details
	Then User should see successful login title with username ''
