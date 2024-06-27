@Vontobel @UI @InitialBanner @BDD
Feature: TC099_InitialBannerExamples

Testing the functionalities of the initial banner shown on Vontobel Markets page.

@TestCaseCode:TC099 @TC099 @Author:Maja_Canaki @InitialBanner
Scenario Outline: Initial Banner Examples
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
	
	When I Select "<Country>" from "Country" dropdown
	When I click on the "Language" dropdown
	Then I should see the "Language" dropdown menu which is enabled and contains values
		| Value            |
		| English          |
	When I Select "<Language>" from "Language" dropdown

	Examples: 

	| Country | Language |
	| Denmark | Danish   |
	| Sweden  | Finnish  |
	| Germany | English  |
	| France  | French   |
