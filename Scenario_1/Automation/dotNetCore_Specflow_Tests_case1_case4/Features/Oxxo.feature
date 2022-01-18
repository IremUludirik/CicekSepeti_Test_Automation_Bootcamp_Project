Feature: MIZU Mexico City-Oxxo payment scenarios
MIZU Mexico City-Oxxo payment scenarios with different adress and billing information

Background: First of all login page should be open
	Given I am on home page
	And I am on flowers page
	
@Positives
Scenario Outline: Mexico City-Oxxo payment
	When I enter the shipping address for mexico city	
	And I click the first product
    And I set the shipping date and time on product page
    And I add the product to the cart
    And I click the guest checkout button
    And I enter the <name>, <number>, <address>, <interiorno>, postcode and choose deliverily location on order page
	And I click the next buttons
    And I enter the <sendername>, <sendernumber>, <senderemail> and select the country on sender page
    And I click the next button
    And I choose the OXXO and accept the conditions for payment on payment page
    And I click the pay button
	Then I see confirmation message
Examples:
| name         | number       | address                        | interiorno | sendername    | sendernumber | senderemail                  |
| irem uludirik| 1531233533   | AGRÍCOLA PANTITLÁN IZTACALCO 4 | 21         | çiçek sepeti  | 6573867567   | user_.deneme@gmail.com       |
| çiçek sepeti | 6673934567   | PRIVADA UNIÓN 11               | 6          | irem uludirik | 1231373333   | user_.robotdegilim@gmail.com |
