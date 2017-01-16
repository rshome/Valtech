Feature: ValtechHomePage
	In order to check the Valtech Pages
	As a Valtech User
	I want to see the relevant pages for each section

@smoke
Scenario: View Latest News
	Given I am on the Valtech Homepage
	Then I see the Latest News Section


@Pages
Scenario Outline: View Pages
	Given I am on the Valtech Homepage
	When I navigate to <Section>
	Then I see the Page <Page>

	Examples: 
	| Section  | Page     |
	| cases    | Work     |
	| services | Services |
	| jobs     | Careers  |


@Offices
Scenario Outline: View Offices
	Given I am on the Valtech Homepage
	When I view the Contact Us Page
	Then I view the total number of offices is <Offices>

	Examples: 
	| Offices |
	| 29      |