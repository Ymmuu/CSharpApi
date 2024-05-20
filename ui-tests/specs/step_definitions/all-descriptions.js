import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I will go to the product page', () => {
  cy.visit('/products');
});

When('I want to view the category {string}', (category) => {
  cy.get('#categories').select(category);
});

Then('the product {string} should be shown with the description {string}', (productName, description) => {
  cy.get('.product').contains('div.product', productName).find('.description').contains(description)
});