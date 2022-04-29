Feature: TMFeature

A short summary of the feature

Scenario: create time and material record with the 
	Given I logged into turn up portal successfully
	When I navigate to Time and Material page
	When I create a new time and material record
	Then the record should be created successfully

Scenario Outline: edit time and material record with valid details
			Given I logged into turn up portal successfully
			When I navigate to Time and Material page
			When I update '<Description>','<Code>' and '<Price>' on an existing time and material record
			Then the record should have the updated '<Description>','<Code>' and '<Price>'
			
			Examples: 
			| Description | code     | price |
			| Time        | lei      | 30    |
			| Material    | Keyboard | 100   |
			| EditedRecord|  Mouse	 | 1500  |