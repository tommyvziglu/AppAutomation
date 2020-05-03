Feature: Log into the app and check the red banner of death doesn't appear
  
  Scenario: Log into the app and ensure the red banner of death doesnt appear
    Given I launch the app
    And I confirm the splash screen intro
    And I input my email address
    When I navigate to my email app
    And I select the correct email
    When I redirect back to the device
    And input my passcode
    Then I should be successfully logged into the application
    And no red banner of death will be present
    