﻿@UIRegression
Feature: UserLogin
	Covers user creation and login on the home page https://responsivefight.herokuapp.com/

@UserLoginUI
Scenario: Login - Login with existing valid username and password
	Given User visits home page
	And User clicks login button
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username 'WilsonBak'

@UserCreationUI
Scenario: Register - User successuflly created and then login
	Given User visits home page
	When User registers with username 'TestUser5' and password 'Password123' and repeat password 'Password123'
	And User logs in with username 'TestUser5' and password 'Password123'
	And User submits the details
	Then User should see successful login title with username 'TestUser5'

@UserLoginUI
Scenario: Login - Try to login with invalid credentials and see correct error message
	Given User visits home page
	And User clicks login button
	When User logs in with username 'Invalid' and password 'FakePwd'
	And User submits the details
	Then User sees login error

@UserCreationUI
Scenario: Register - User tries to register with unmatched password and sees correct error message
	Given User visits home page
	When User registers with username 'TestUser6' and password 'Password123' and repeat password 'Password321'
	Then User sees register error 'Passwords do not match' 
