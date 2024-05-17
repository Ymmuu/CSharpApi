Feature: As a user I want to be able to see all products listed when I have chosen the category "Alla".

  Scenario: Check that the category "Alla" shows all products.
    Given that I am on the product page
    When I choose the category "Alla"
    Then I should see the product "Adidas Adipower"
    And I should see the product "Adidas Ctrl"
    And I should see the product "Adidas Metalbone"
    And I should see the product "Tretorn Tour1"
    And I should see the product "Head Pro S"
    And I should see the product "Varlion Summum Pro"
    And I should see the product "Bullpadel Hesacore Padel Grip"
    And I should see the product "Znake Overgrip"
    And I should see the product "Gorilla Gold Padel"
    And I should see the product "Nytt i lager"
    And I should see the product "Adidas SuperFast"
    And I should see the product "Bullpadel CourtMaster"
    And I should see the product "Babolat GripMaster"
    And I should see the product "Adidas shorts"
    And I should see the product "Adidas t-shirt"
    And I should see the product "Adidas kept"
