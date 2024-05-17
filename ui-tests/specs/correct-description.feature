Feature: As user I want to be able to see the correct description listed when I have chosen a category.

  Scenario Outline: Check that the category <category> shows correct descriptions <description>.
    Given that I am on the product page
    When I choose the category "<category>"
    Then I should see the description "<description>"

    Examples:
      | category    | product                                                                                                             |
      | Padelrack   | Adidas snabbaste rack                                                                                               |
      | Padelrack   | Adidas kontrollrack                                                                                                 |
      | Padelrack   | Adidas allround rack                                                                                                |
      | Padelbollar | För spelaren som söker mycket fart och känsla i sitt spel                                                           |
      | Padelbollar | Snabba bollar för snababt spel                                                                                      |
      | Padelbollar | Perfekt för det nordiska klimatet                                                                                   |
      | Övrigt      | Bullpadels innovativa racketgrepp Hesacore är framtaget för att för att minska de vibrationer som uppstår vid slag. |
      | Övrigt      | Znake Overgrip är en stötupptagande och vibrationsdämpande grepplinda                                               |
      | Övrigt      | För bättre grepp, klister på händerna                                                                               |
      | Övrigt      | Testa detta bla bla                                                                                                 |
      | Skor        | Adidas snabbaste skor                                                                                               |
      | Skor        | Snabba och snygga                                                                                                   |
      | Skor        | Bästa grepp                                                                                                         |
      | Kläder      | Snyggaste på marknaden                                                                                              |
      | Kläder      | Nyaste designen                                                                                                     |
      | Kläder      | Perfekt till soliga dagar                                                                                           |

      














