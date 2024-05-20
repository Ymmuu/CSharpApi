import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('I will go to the product page', () => {
  cy.visit('/products');
});

When('I will choose to see the category {string}', (category) => {
  cy.get('#categories').select(category);
});

Then('the product {string} should be shown', (productName) => {
  cy.get('.product .name').contains(productName);
});