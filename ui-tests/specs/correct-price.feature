Feature: As user I want to be able to see the correct prices listed when I have chosen a category.

  Scenario Outline: Check that the category <category> shows the correct prices <price>.
    Given that I am on the product page
    When I choose the category "<category>"
    Then I should see the price "<price>"

    Examples:
      | category    | price  |
      | Padelrack   | 3399   |
      | Padelrack   | 3149   |
      | Padelrack   | 3249   |
      | Padelbollar | 85     |
      | Padelbollar | 89     |
      | Padelbollar | 79     |
      | Övrigt      | 219    |
      | Övrigt      | 39     |
      | Övrigt      | 99     |
      | Övrigt      | 29     |
      | Skor        | 1299   |
      | Skor        | 899    |
      | Skor        | 1099   |
      | Kläder      | 499    |
      | Kläder      | 399    |
      | Kläder      | 299    |





