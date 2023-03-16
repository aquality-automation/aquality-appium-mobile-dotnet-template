Feature: Demo

@demo
Scenario: I try to login with invalid credentials
	When I open 'Login Screen' view
	Then Login Screen is opened
    When I save Login Screen dump
		And I log in with data:
	  | Name     | Value           |
	  | Username | MyUsername      |
	  | Password | InVal1dPa$$w0rd |
	Then 'Invalid login credentials, please try again' alert appears
    When I accept the alert
    Then Login Screen dump is different
