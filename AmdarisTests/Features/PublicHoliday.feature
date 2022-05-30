Feature: Interaction with Public Holidays 
Interactions with Public Holidays subpage like creating, search, edit and delete holiday.

@positive
Scenario: Add public holiday
	When user press add public holiday button
	And choose date
	And add a description
    And press save button
	Then holiday is created

@positive
Scenario: Search holiday
    When user enter search term
    Then search results are shown

@positive
Scenario: Edit holiday
	When user press edit button on created holiday
	And change description
	Then press save button
	And holiday is updated

@positive
Scenario: Delete holiday
    When user press Delete button on created holiday
    And confirm deletion
    Then holiday is deleted

@negative
Scenario: Exceed max length of description
    When user press add public holiday button
    And choose date
    And add a description exceeding max length of character
    Then error is shown