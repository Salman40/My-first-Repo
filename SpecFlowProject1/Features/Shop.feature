Feature: User Go to Site and Place an order of buying phone.

A short summary of the feature
@mytag
Scenario: Customer place an order by purchasing item from Site
	Given I am at Home Page of Site
	And  I select Samsung Phone
	And  Add product to the cart
	When  I Go to the Cart
	And place the order of Phone
	Then Fill the details for shipping
	And Click on Purchase Button
	And Close the Browser after done