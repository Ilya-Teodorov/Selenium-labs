Feature: Ilya_Teodorov.feature 

Scenario: Functionality of searching words option
	Given user navigates to https://www.epam.com/
	And user clicks on search
	When user writting word
	Then search results should be given

Scenario: Positioned video functionality
	Given user navigates to https://www.epam.com/about/who-we-are/social-responsibility/covid-19-response
	And user presses the button to view the video
	When video downloads from youtube
	Then the page is not sent to YouTube, but the video is played on the site

Scenario: Check epam events
    Given the user navigates to https://www.epam.com/
    When the user hovers over "ABOUT"
    And the user clicks on "Events" in "INVESTORS" section
    And the user clicks on "VIEW ALL" button
    Then list of epam events is shown

Scenario: Checking the functionality of the language change button
	Given language change button
	And user switches language via button
	When user changes language
	Then all information is displayed correctly in the selected language

Scenario: Functionality of 'contact us' button
	Given user navigates to https://www.epam.com/
	And user clicks 'contact us' button
	Then all the information you need to contact appears on the page

Scenario: Functionality of the menu interface when the window is not full size
	Given user navigates to https://www.epam.com/
	And user does not open the page in the whole window
	When user clicks on Menu -> Careers -> Blog	
	Then the entire interface is displayed correctly and takes the user to the career blog page

Scenario: Functionality of "Learn more about Epam Continuum"
	Given user navigates to https://www.epam.com/
	And the panel with the button tends to be replaced by another
	When user clicks on "Epam Continuum"-button
	Then the page https://www.epam.com/services/consult-and-design opens 
	And not opens the page that following the next button

Scenario: Displaying the map, scrolling and clicking on the cookie agreement button
	Given user navigates to https://www.epam.com/
	And clicks on 'Our Work' button
	When cookie agreement bar appears
	And user clicks Accept
	Then cookie agreement bar disappears
	When user scrolls down the page and clicks on 'Canada'
	Then on the next page a map with the location of the epam's office opens







