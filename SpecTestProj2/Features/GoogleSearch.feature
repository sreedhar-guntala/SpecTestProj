Feature: GoogleSearch
	Feature to test Google page search
@SmokeTest
Scenario: Google Search for Execute Automation
	Given I have navigated to Google page
	And I see the google page fully loaded
	When I type search keyword as
	| Keyword			|
	|selenium	|
	Then I should see the results for keyword
	| Keyword |
	|  selenium |


