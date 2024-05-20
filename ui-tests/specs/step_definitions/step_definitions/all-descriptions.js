import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

/* No duplicate steps, this one already in all-prices.js
Given('that I go to the product page', () => {});*/

/* No duplicate steps, this one already in all-prices.js
When('I choose to see the category {string}', (category) => {});*/

Then('the product {string} should be shown with the description {description}', (productName, description) => {
  cy.get('.product').contains('div.product', productName).find('.description').contains(description)
});