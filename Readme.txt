About the Application:
----------------------

1. The application contains 4 Window forms
	1. Main Form - Asks for user name, once submitted for the first time will save it in DB and take it to Security Questions Form
	2. Security Questions Form - There will be 3 dropdowns with 10 security questions, will take answers and save it in DB
	3. Answer Form - User will be taken to this form if its the existing user and validate answers for the security questions until right answer is provided
	4. Update Security Questions Form - User will be taken to this form after providing valid answer for the security answer and chooses to update security questions
2. Validation, Transactions & Exception Handling
	1. Null check validation implemeneted
	2. Transactions & Exception handling implemeneted if the user tries to use the same questions
3. Tools/Frameworks used
	1. SQLite DB 
	2. Dapper framework for connecting to SQLite
	3. System.core.SQLite for connecting to SQLite
4. Application Components
	1. DemoLibrary - Contains DAO, DB Object model and Data Access components
	2. WinFormUI - Contains all Window forms


About DB Setup.sql file:
-------------------------
1. Used 3 tables Person, Questions, SecAnswers
2. Person to store users, Questions contains all the static questions, SecAnswers contains user selected question and answers


How to setup and run the application:
---------------------------

1. Unzip the Elixir_Coding.zip file into a folder
2. Open Visual Studio and select open Project/Solution option
3. Go to Elixir_Coding/Security_Questions folder and select Security_Questions.sln solution file
4. Build project and run the application 
