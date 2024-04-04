Feature: Login into Geek For Geeks

Login into Website

Background: 
Given User lands on the homepage to login
When User enters ID and Password to login

@RoughWork
Scenario: Login into Geek For Geeks
	#Given User lands on the homepage to login
	#When User enters ID and Password to login
	When User click on the profile
	Then User click on the Logout
@RoughWork
#@DataSource:TestData.csv @DataField:Loginfield=UserName @DataField:Passwordfield=Password
Scenario Outline: Search for DSA in the Search field

#Given User lands on the homepage to login
#When User enters <Loginfield> and <Passwordfield> to login
Then User Search for the <searchData> in the search field and select the required data

	Examples:
	|searchData|
	|DSA|

#@RoughWork
#Scenario: Logout from Geek For Geeks
#	When User clik on the profile
#	Then User click on the Logout