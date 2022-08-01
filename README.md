# # Project name : SauseDemo project
## Pre-Requisites for project execution
- Visual Studio 2022
- Latest Chrome Driver version 99.0.5060.134 (

## 01 - Automation Framework design Approach

###### IDE & Language
   - Visual Studio 2022 & C#
###### Automation Tool
   - Selenium WebDriver
###### Project Type
   - BDD-SpecFlow
###### Design Pattern
   - Singleton with POM
###### DataDriven
   - Scenario Outline
###### Reports
   - Extent Reports
###### Browsers
   - Chrome Driver
## 02 - Test Scenarios
- Scenario 1 : Verify user can login into saucedemo page or not
- Scenario 2 : Verify user can Remove Product from cart
- Scenario 3 : Successful Login with Multiple Valid Credentials
- Scenario 4 : Verify the Item and Price on chekout page and validate the successful order
- 
 ## 03 - Brief Description about framework Approach
 - Reports created using ExtentReports and ScreenShots captured for failed scenarios
 
 - In Project solution 
     ###### 1. ObjectRepsitoryLibrary : 
      which contains common utilities, locators (defined in page classfiles : HomePageRepo and CareerPageRepo),Constants, SingletonBaseclass 
       
       
    ###### 2. HelperLibrary : 
     which contains the methods which are specific to the respective pages (Pagehelper class)
     we can call Pagehelper methods from Teststeps methods.
       
    ###### 4. BDDFramework(SpecFlow Project) 
       Feature files
       Stepdefination files 
       Hooks

