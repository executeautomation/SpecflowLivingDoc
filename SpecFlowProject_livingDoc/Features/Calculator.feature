Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I open the application 
	And I set all the environment settings
	And the setting includes 
		| settings                |
		| Admin more enabled      |
		| Scientific calc enabled |
		| Memory cleared          |

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120


@mytag
Scenario: Add three numbers
	Given I enter following numbers
		| number1 | number2 | number3 |
		| 20      | 30      | 56      |
	When the two numbers are added
	Then the result should be 120