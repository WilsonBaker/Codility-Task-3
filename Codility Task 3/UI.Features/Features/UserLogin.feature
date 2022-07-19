@UserLoginUI @UIRegression
Feature: UserLogin
	Simple calculator for adding two numbers


Scenario: Login - Login with existing valid username and password
	Given User visits home page
	And User clicks login button
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username 'WilsonBak'

Scenario: Register - User successuflly created and then login
	Given User visits home page
	When User registers with username 'TestUser5' and password 'Password123'
	And User logs in with username 'TestUser5' and password 'Password123'
	And User submits the details
	Then User should see successful login title with username 'TestUser5'

Scenario: Login - Try to login with invalid credentials and see correct error message
	Given User visits home page
	And User clicks login button
	When User logs in with username 'Invalid' and password 'FakePwd'
	And User submits the details
	Then User sees login error
