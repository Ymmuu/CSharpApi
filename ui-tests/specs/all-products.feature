Feature: As a user I want to be able to see all products when I have chosen the category "Alla" and that correct products shows when i choose a category.

  Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown
    Given I will go to the product page
    When I will choose to see the category "<category>"
    Then the product "<productName>" should be shown

    Examples:
      | category    | productName                   |
      | Alla        | Adidas Adipower               |
      | Alla        | Adidas Ctrl                   |
      | Alla        | Adidas Metalbone              |
      | Alla        | Tretorn Tour1                 |
      | Alla        | Head Pro S                    |
      | Alla        | Varlion Summum Pro            |
      | Alla        | Bullpadel Hesacore Padel Grip |
      | Alla        | Znake Overgrip                |
      | Alla        | Gorilla Gold Padel            |
      | Alla        | Nytt i lager                  |
      | Alla        | Adidas SuperFast              |
      | Alla        | Bullpadel CourtMaster         |
      | Alla        | Babolat GripMaster            |
      | Alla        | Adidas shorts                 |
      | Alla        | Adidas t-shirt                |
      | Alla        | Adidas kept                   |
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
