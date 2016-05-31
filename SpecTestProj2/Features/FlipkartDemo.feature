Feature: FlipkartDemo

Background: 
Given I launch Browser

@smoke
Scenario Outline: Verify Search operation iphone_Smoke
	Given I navigate to "http://www.flipkart.com" web site
	When I perform search with "<SearchString>"
	Then The result should be displayed
Examples: 
| SearchString    |
| Apple iphone 5s |


@Regression
Scenario Outline: Verify Search operation iphone_Reg
	Given I navigate to "http://www.flipkart.com" web site
	When I perform search with "<SearchString>"
	Then The result should be displayed
Examples: 
| SearchString    |
| Apple iphone 5s |
| Apple iphone 4  |
| Apple iphone 6s |
