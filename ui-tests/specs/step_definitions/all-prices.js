import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Then('I should see the price {int}', (productPrice) => {
  cy.get('.product .price').contains(productPrice);
});

