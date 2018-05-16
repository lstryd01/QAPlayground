Feature: Playground
	In order to buy some red shoes
	As a customer
	I want to search for red shoes

@mytag
Scenario: Search for Red Shoes
	Given I have loaded the Asos website
	When I enter Red Shoes into the search bar
	And I click search
	Then the results will include red shoes
