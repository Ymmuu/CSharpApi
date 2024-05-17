Feature: As a user I want to be able to see all prices of all products when I have chosen the category "Alla".

  Scenario: Check that the category "Alla" shows all prices.
    Given that I am on the product page
    When I choose the category "Alla"
    Then I should see the price "3399"
    And I should see the price "3149"
    And I should see the price "3249"
    And I should see the price "85"
    And I should see the price "89"
    And I should see the price "79"
    And I should see the price "219"
    And I should see the price "39"
    And I should see the price "99"
    And I should see the price "29"
    And I should see the price "1299"
    And I should see the price "899"
    And I should see the price "1099"
    And I should see the price "499"
    And I should see the price "399"
    And I should see the price "299"
