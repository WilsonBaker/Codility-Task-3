@UserLoginUI @UIRegression
Feature: UserLogin
	Simple calculator for adding two numbers


Scenario: Login - Login with valid username and password
	Given User visits login page 
	When User logs in with username '' and password ''
	Then User should see the '' page