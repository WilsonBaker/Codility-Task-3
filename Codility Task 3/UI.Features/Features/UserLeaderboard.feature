@UIRegression @UserLeaderboard
Feature: UserLeaderboard
	This covers when the user logs in and checks the leaderboard

Background: User logs in
	Given User visits home page
	And User clicks login button
	When User logs in with username 'WilsonBak' and password 'P@ssword1234'
	And User submits the details
	Then User should see successful login title with username 'WilsonBak'

Scenario: User checks their score on the leaderboard
	Given User with username 'WilsonBak' has a score on the leaderboard of '0'
	When User visits leaderbaord page
	Then User should see their username 'WilsonBak' and score of '0'

