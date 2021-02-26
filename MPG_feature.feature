Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: MPG - easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficieny should be 8

Scenario: MPG  easy2
	Given Miles driven is 85
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficieny should be 8.5

Scenario: Gas hog
	Given Miles driven is 100
	And Gallons used is 10
	When gasHog is called
	Then the car is a gas hog and should be true

Scenario: Gas rewards
	Given Miles driven is 12000
	And Gallons used is 6000
	When gasRewards is called
	Then the points given should be 720.0
