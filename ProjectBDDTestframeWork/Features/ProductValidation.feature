Feature: Product Name and Price validation in All the pages

@mytag
Scenario: Verify Item Name and Price
	Given Enter the Demo user name "standard_user" and Password "secret_sauce"	
	When user click on Login button
	Then User can view List of Products "PRODUCTS"
	And Add First product to Cart
	And Validate the Item  and Price of product in Cart page
	And Click on checkout and enter the sample details and click continue
	And Verify the Item and Price on chekout page and click finish