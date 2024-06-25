#TestPlanReference(6874)
#TestSuiteReference(6889)
@Vontobel @Hybrid @TestCase�
Feature: TC003_Hybrid_LocateProductByISIN

Test the functionality of locating a product by ISIN acquired from API search.

@TestCaseCode:Hybrid_TC003 @Author:Ivona_Karas @LocateProductByISIN
#ScenarioTags(Vontobel, [TestCaseCode], Hybrid)
#TestCaseReference(6902)
Scenario: Locate Product By ISIN
#Given I navigate to the "Vontobel Markets" page
When POST request is sent
| Key        | Value             |
| EndPoint   | Get Products List |
Then Response Code is 200
And Field "isin" is not empty
And Save field "isin" as "<ISIN>"
When the "Initial banner" modal is displayed
Then I should see the "Accept Conditions and Decline Cookies" button which is enabled
When I click on the "Accept Conditions and Decline Cookies" button
Then I should see "Search" textbox which is enabled and not empty
And I should see the "Search" button which is enabled
When I enter "<ISIN>" value into "Search" textbox
Then "Search" textbox should contain "<ISIN>" value
And I should see "Search" wrapper
And I should see first result in "Search" wrapper
When I click on first result in "Search" wrapper
Then I should see "Products" page
And I should see the "Isin" button which is enabled
And I should see the "Isin" button which contains text "<ISIN>"


