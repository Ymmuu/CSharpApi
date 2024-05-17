Feature: As user I want to be able to see the correct prices listed when I have chosen a category.

  Scenario Outline: Check that the category <category> shows the product <product>.
    Given that I am on the product page
    When I choose the category "<category>"
    Then I should see the product "<product>"

    Examples:
      | category    | product                       |
      | Padelrack   | Adidas Adipower               |
      | Padelrack   | Adidas Ctrl                   |
      | Padelrack   | Adidas Metalbone              |
      | Padelbollar | Tretorn Tour1                 |
      | Padelbollar | Head Pro S                    |
      | Padelbollar | Varlion Summum Pro            |
      | Övrigt      | Bullpadel Hesacore Padel Grip |
      | Övrigt      | Znake Overgrip                |
      | Övrigt      | Gorilla Gold Padel            |
      | Övrigt      | Nytt i lager                  |
      | Skor        | Adidas SuperFast              |
      | Skor        | Bullpadel CourtMaster         |
      | Skor        | Babolat GripMaster            |
      | Kläder      | Adidas shorts                 |
      | Kläder      | Adidas t-shirt                |
      | Kläder      | Adidas kept                   |