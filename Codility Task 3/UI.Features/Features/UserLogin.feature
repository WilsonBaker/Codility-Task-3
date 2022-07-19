@UserLoginUI @UIRegression
Feature: UserLogin
	Simple calculator for adding two numbers


Scenario: Login - Login with valid username and password
	Given User visits home page
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username ''