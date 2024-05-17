import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I am on the product page', () => {
  cy.visit('/products');
});

When('I choose the category alla', () => {
  cy.visit('/category/alla');
});

Then('I should see the product {string}', (productName) => {
  cy.get('.product .name').contains(productName);
});