@Vontobel @UI @InitialBanner @BDD
Feature: TC001_InitialBanner

Testing the functionalities of the initial banner shown on Vontobel Markets page.

@TestCaseCode:TC001 @TC001 @Author:Maja_Canaki @InitialBanner
Scenario: Initial Banner
	Given I navigate to the "Vontobel Markets" page
	When the "Initial Banner" modal is displayed
	Then I should see the "Country" dropdown which is enabled and contains a default value
	And I should see the "Language" dropdown which is enabled and contains a default value
	And I should see the "Investor Profile" dropdown which is enabled and contains a default value
	And I should see the "Terms and Conditions of Use" wrapper which is not empty
	And I should see the "Read more" link which is enabled
	And I should see the "Privacy and Cookies" wrapper which is not empty
	And I should see the "Privacy Policy" button which is enabled
	And I should see the "Cookie Settings" button which is enabled
	And I should see the "Accept Conditions and Cookies" button which is enabled
	And I should see the "Accept Conditions and Cookies" button which contains text "Accept Conditions and Cookies"
	And I should see the "Accept Conditions and Decline Cookies" button which is enabled
	When I click on the "Country" dropdown
	Then I should see the "Country" dropdown menu which is enabled and contains values
		| Value          |
		| Czech Republic |
		| Denmark        |
		| Finland        |
		| France         |
		| Germany        |
		| Hong Kong      |
		| Hungary        |
		| Italy          |
		| Netherlands    |
		| Norway         |
		| Sweden         |
		| Switzerland    |
	When I click on the "Language" dropdown
	Then I should see the "Language" dropdown menu which is enabled and contains values
		| Value            |
		| English          |
		| Norwegian Bokm�l |
	When I click on the "Investor Profile" dropdown
	Then I should see the "Investor Profile" dropdown menu which is enabled and contains values
		| Value        |
		| Private      |
		| Professional |
	When I click on the "Read more" link
	Then I should see the "Terms and Conditions of Use" wrapper which is expanded
	And I should see the "https://prospectus.vontobel.com" link which is enabled
	And I should see the "https://www.vontobel.com/privacypolicy" link which is enabled
	When I click on the "Privacy Policy" button
	Then I should see the "Privacy Policy" wrapper which is not empty
	And I should see the "Terms and Conditions of Use, Cookie Policy" link which is enabled
	And I should see the "Cookie Policy" link which is enabled
	And I should see the "Vontobel's Social Media Terms of Use" link which is enabled
	And I should see the "vontobelgroup@vontobel.com" link which is enabled
	And I should see the "dpo.ch@vontobel.com" link which is enabled
	And I should see the "dpo.de@vontobel.com" link which is enabled
	And I should see the "dpo.vontobelgroup@vontobel.com" link which is enabled
	And I should see the "www.vontobel.com/mifid" link which is enabled
	When I click on the "Cookie Settings" button
	Then I should see the "Accept Conditions and Cookies" button which contains text "Accept Conditions and Cookie preferences"
	And I should see the "Functional Cookies" toggle button which is disabled and toggled
	And I should see the "Functional Cookies" button which is enabled
	And I should see the "Analytics Cookies" toggle button which is enabled and not toggled
	And I should see the "Analytics Cookies" button which is enabled
	And I should see the "Marketing Cookies" toggle button which is enabled and not toggled
	And I should see the "Marketing Cookies" button which is enabled
	And I should see the "Performance & Tracking Cookies" toggle button which is enabled and not toggled
	And I should see the "Performance & Tracking Cookies" button which is enabled
	When I click on the "Functional Cookies" button
	Then I should see the "Functional Cookies" wrapper which is not empty
	When I click on the "Analytics Cookies" toggle button
	Then I should see the "Analytics Cookies" toggle button which is toggled
	When I click on the "Analytics Cookies" button
	Then I should see the "Analytics Cookies" wrapper which is not empty
	When I click on the "Marketing Cookies" toggle button
	Then I should see the "Marketing Cookies" toggle button which is toggled
	When I click on the "Marketing Cookies" button
	Then I should see the "Marketing Cookies" wrapper which is not empty
	When I click on the "Performance & Tracking Cookies" toggle button
	Then I should see the "Performance & Tracking Cookies" toggle button which is toggled
	And I should see the "Accept Conditions and Cookies" button which contains text "Accept Conditions and Cookies"
	When I click on the "Performance & Tracking Cookies" button
	Then I should see the "Performance & Tracking Cookies" wrapper which is not empty
