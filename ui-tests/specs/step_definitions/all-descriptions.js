import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Then('I should see the description {string}', (description) => {
  cy.get('.product .description').contains(description);
});


