Feature: Login

@Smoke
  Scenario: Successful login
    Given I am on the login page
    When I login with valid credentials
    Then I should be redirected to the dashboard