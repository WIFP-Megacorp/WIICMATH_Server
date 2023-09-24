# WIICMATH_Server

For the server side of the WIICMATH project.

## Relevant dev resocurces

These YouTube videos are a great resource for learning how to use this solution and understand more about the project.
- [Base principals Part1](https://www.youtube.com/watch?v=dwMFg6uxQ0I)
- [Base min API principals Part2](https://www.youtube.com/watch?v=5tYSO5mAjXs)

Understading classLibrary in general:
- [ClassLibrary](https://www.youtube.com/watch?v=C6LV_xMGdKc)


How to make the api project work locally(Visual Studio):

1. Open the solution in Visual Studio.
2. right-click the WIICMATH_API, make sure it is set as startup projeckt
3. right-click the WIICMATH_API, click publish. In the popup:
	- click edit
	- click browse
	- select local
	- select MYSQLLocalDB
	- click ok
	- name the db
	- save profile as in the projekt folder (easyer to publish later)
	- dobble click the new publish file
	- click publish
4.Search "SQL server Object Explorer".
5.Navigate til you find your named DB
6.Right-click the DB and click properties, find the connetion string.	
7.Open the WIICMATH_API project, open the appsettings.json file.
8.Replace the connection string with the one you found in step 6.
	- The connection string should look something like this: "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WIICMATH_DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
	- Make sure there are no spaces in (TrustServerCertificate ,ApplicationIntent and MultiSubnetFailover)	
9. Save the appsettings.json
1. Run the project
