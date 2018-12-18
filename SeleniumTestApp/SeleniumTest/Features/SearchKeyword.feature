Feature: SearchKeyword
	In order to return 5th link text from google search result with provided keyword
	As an user I can search a keyword in google
	It should print 5th link from search result

Scenario: Verify Search Keyword in google
	Given I am on google search page
	When I Search for a keyword called 'Aviva'
	Then I should see 'Aviva - Google Search' on the goole search
	And  I should print the 5th Text of Search Result
	And  I should see 6 links in first page of search result
