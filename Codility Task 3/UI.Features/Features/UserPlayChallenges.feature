@UIRegression
Feature: UserPlayChallenges
	Covers user playing the COVID multi-choice game after they have logged in

Background: Ensure user already logged in
	Given User visits home page
	And User clicks login button
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username 'WilsonBak'

Scenario: User plays game with correct answer
	Given User clicks start game button
	And User clicks Enter at your own risk button
	And User clicks start button
	When User chooses correct answer
	Then User should see message saying they are correct