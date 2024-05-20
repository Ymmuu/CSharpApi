Feature: As a user I want to be able to see all prices of all products when I have chosen the category "Alla" and that correct prices shows on all products when i choose a category.

  Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown with the price "<price>".
    Given that I go to the product page
    When I choose to see the category "<category>"
    Then the product "<productName>" should be shown with the price "<price>"

    Examples:
      | category    | productName                   | price |
      | Alla        | Adidas Adipower               | 3399 |
      | Alla        | Adidas Ctrl                   | 3149 |
      | Alla        | Adidas Metalbone              | 3249 |
      | Alla        | Tretorn Tour1                 | 85   |
      | Alla        | Head Pro S                    | 89   |
      | Alla        | Varlion Summum Pro            | 79   |
      | Alla        | Bullpadel Hesacore Padel Grip | 219  |
      | Alla        | Znake Overgrip                | 39   |
      | Alla        | Gorilla Gold Padel            | 99   |
      | Alla        | Nytt i lager                  | 29   |
      | Alla        | Adidas SuperFast              | 1299 |
      | Alla        | Bullpadel CourtMaster         | 899  |
      | Alla        | Babolat GripMaster            | 1099 |
      | Alla        | Adidas shorts                 | 499  |
      | Alla        | Adidas t-shirt                | 399  |
      | Alla        | Adidas kept                   | 299  |
      | Padelrack   | Adidas Adipower               | 3399 |
      | Padelrack   | Adidas Ctrl                   | 3149 |
      | Padelrack   | Adidas Metalbone              | 3249 |
      | Padelbollar | Tretorn Tour1                 | 85   |
      | Padelbollar | Head Pro S                    | 89   |
      | Padelbollar | Varlion Summum Pro            | 79   |
      | Övrigt      | Bullpadel Hesacore Padel Grip | 219  |
      | Övrigt      | Znake Overgrip                | 39   |
      | Övrigt      | Gorilla Gold Padel            | 99   |
      | Övrigt      | Nytt i lager                  | 29   |
      | Skor        | Adidas SuperFast              | 1299 |
      | Skor        | Bullpadel CourtMaster         | 899  |
      | Skor        | Babolat GripMaster            | 1099 |
      | Kläder      | Adidas shorts                 | 499  |
      | Kläder      | Adidas t-shirt                | 399  |
      | Kläder      | Adidas kept                   | 299  |




