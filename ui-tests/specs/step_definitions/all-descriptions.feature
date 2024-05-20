Feature: As a user I want to be able to see all descriptions of all products when I have chosen the category "Alla" and that correct descriptions shows on all products when i choose a category.

  Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown with the description "<description>".
    Given that I go to the product page
    When I choose to see the category "<category>"
    Then the product "<productName>" should be shown with the description "<description>"

    Examples:
      Examples:
      | category    | productName                   | description                                                                                                          |
      | Alla        | Adidas Adipower               | Adidas snabbaste rack                                                                                                |
      | Alla        | Adidas Ctrl                   | Adidas kontrollrack                                                                                                  |
      | Alla        | Adidas Metalbone              | Adidas allround rack                                                                                                 |
      | Alla        | Tretorn Tour1                 | För spelaren som söker mycket fart och känsla i sitt spel                                                            |
      | Alla        | Head Pro S                    | Snabba bollar för snababt spel                                                                                       |
      | Alla        | Varlion Summum Pro            | Perfekt för det nordiska klimatet                                                                                    |
      | Alla        | Bullpadel Hesacore Padel Grip | Bullpadels innovativa racketgrepp Hesacore är framtaget för att för att minska de vibrationer som uppstår vid slag.  |
      | Alla        | Znake Overgrip                | Znake Overgrip är en stötupptagande och vibrationsdämpande grepplinda                                                |
      | Alla        | Gorilla Gold Padel            | För bättre grepp, klister på händerna                                                                                |
      | Alla        | Nytt i lager                  | Testa detta bla bla                                                                                                  |                           
      | Alla        | Adidas SuperFast              | Adidas snabbaste skor                                                                                                |
      | Alla        | Bullpadel CourtMaster         | Snabba och snygga                                                                                                    |
      | Alla        | Babolat GripMaster            | Bästa grepp                                                                                                          |
      | Alla        | Adidas shorts                 | Snyggaste på marknaden                                                                                               |
      | Alla        | Adidas t-shirt                | Nyaste designen                                                                                                      |
      | Alla        | Adidas kept                   | Perfekt till soliga dagar                                                                                            |
      | Padelrack   | Adidas Adipower               | Adidas snabbaste rack                                                                                                |
      | Padelrack   | Adidas Ctrl                   | Adidas kontrollrack                                                                                                  |
      | Padelrack   | Adidas Metalbone              | Adidas allround rack                                                                                                 |
      | Padelbollar | Tretorn Tour1                 | För spelaren som söker mycket fart och känsla i sitt spel                                                            |
      | Padelbollar | Head Pro S                    | Snabba bollar för snababt spel                                                                                       |
      | Padelbollar | Varlion Summum Pro            | Perfekt för det nordiska klimatet                                                                                    |
      | Övrigt      | Bullpadel Hesacore Padel Grip | Bullpadels innovativa racketgrepp Hesacore är framtaget för att för att minska de vibrationer som uppstår vid slag.  |
      | Övrigt      | Znake Overgrip                | Znake Overgrip är en stötupptagande och vibrationsdämpande grepplinda                                                |
      | Övrigt      | Gorilla Gold Padel            | För bättre grepp, klister på händerna                                                                                |             
      | Övrigt      | Nytt i lager                  | Testa detta bla bla                                                                                                  |
      | Skor        | Adidas SuperFast              | Adidas snabbaste skor                                                                                                |
      | Skor        | Bullpadel CourtMaster         | Snabba och snygga                                                                                                    |
      | Skor        | Babolat GripMaster            | Bästa grepp                                                                                                          |
      | Kläder      | Adidas shorts                 | Snyggaste på marknaden                                                                                               |
      | Kläder      | Adidas t-shirt                | Nyaste designen                                                                                                      |
      | Kläder      | Adidas kept                   | Perfekt till soliga dagar                                                                                            |









      | category    | product         | description     |                                                                                                    |
      | 
      | Övrigt      |                                               |
      | Övrigt      |                                                                                |
      | Övrigt      |                                                                                                  |
      | Skor        |                                                                                                |
      | Skor        |                                                                                                    |
      | Skor        |                                                                                                          |
      | Kläder      |                                                                                               |
      | Kläder      |                                                                                                      |
      | Kläder      |                                                                                            |




