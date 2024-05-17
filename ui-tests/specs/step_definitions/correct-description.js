import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Then('I should see the description {string}', (productDescription) => {
  cy.get('.product .description').contains(productDescription);
});