import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I go to the product page', () => {
  cy.visit('/products');
});

When('I choose to see the category {string}', (category) => {
  cy.get('#categories').select(category);
});

Then('the product {string} should be shown with the price {string}', (productName, price) => {
  cy.get('.product').contains('div.product', productName).find('.price').contains('Pris: ' + price + ' kr')
});