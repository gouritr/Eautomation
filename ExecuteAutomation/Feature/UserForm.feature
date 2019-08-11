Feature: User Form

Scenario: Valid Save when all details are entered.
Given User is on UserForm Page
And User enters below details
| Title | Initial | FirstName | MiddleName | Gender | LanguagesKnown |
| Mr.    | P       | Fname     | Mname      | Male   | english        |
When user clicks save 
Then no error displayed

Scenario:Valid Save using mandatory details.
Scenario: Unsuccesful Save when mandatory details are not given.
Scenario: :Unsuccesful save when All fields are blank.

