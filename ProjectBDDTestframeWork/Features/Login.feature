Feature: Login Page Validation

Scenario: Verify user can login into saucedemo page or not
	Given Enter the Demo user name "standard_user" and Password "secret_sauce"		
	When user click on Login button
	Then User can view List of Products "PRODUCTS"

	Scenario: Verify user Remove Product from cart
	Given Enter the Demo user name "standard_user" and Password "secret_sauce"	
	When user click on Login button
	Then User can view List of Products "PRODUCTS"
	And Add First product to Cart
	And Remove Product from Cart
	
