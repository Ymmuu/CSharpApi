Feature: As a user I want to be able to see all descriptions of all products when I have chosen the category "Alla".

  Scenario: Check that the category "Alla" shows all descriptions.
    Given that I am on the product page
    When I choose the category "Alla"
    Then I should see the description "Adidas snabbaste rack"
    And I should see the description "Adidas kontrollrack"
    And I should see the description "Adidas allround rack"
    And I should see the description "För spelaren som söker mycket fart och känsla i sitt spel"
    And I should see the description "Snabba bollar för snababt spel"
    And I should see the description "Perfekt för det nordiska klimatet"
    And I should see the description "Bullpadels innovativa racketgrepp Hesacore är framtaget för att för att minska de vibrationer som uppstår vid slag."
    And I should see the description "Znake Overgrip är en stötupptagande och vibrationsdämpande grepplinda"
    And I should see the description "För bättre grepp, klister på händerna"
    And I should see the description "Testa detta bla bla"
    And I should see the description "Adidas snabbaste skor"
    And I should see the description "Snabba och snygga"
    And I should see the description "Bästa grepp"
    And I should see the description "Snyggaste på marknaden"
    And I should see the description "Nyaste designen"
    And I should see the description "Perfekt till soliga dagar"



