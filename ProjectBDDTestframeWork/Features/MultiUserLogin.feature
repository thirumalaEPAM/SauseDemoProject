Feature: Multi user Login Page Validation

@mytag
Scenario Outline: Successful Login with Valid Credentials	
	Given User enter <username> and <password>
	When user click on Login button
	Then User can view List of Products "PRODUCTS"
Examples:
| username   | password |
| standard_user | secret_sauce |
| locked_out_user | secret_sauce |
| problem_user | secret_sauce |
| performance_glitch_user | secret_sauce |