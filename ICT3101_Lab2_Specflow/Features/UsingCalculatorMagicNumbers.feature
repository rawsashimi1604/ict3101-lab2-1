Feature: UsingCalculatorMagicNumbers
In order to be cool
As a magic numbers random person
I want to perform magic on numbers

@Availability
Scenario: Calculating with positive number
    Given I have a calculator
    When I have entered a postive number and press Magic Number
    Then the positive magic number result should be "?"
@Availability
Scenario: Calculating with negative number
    Given I have a calculator
    When I have entered a negative number and press Magic Number
    Then the negative magic number result should be "?"