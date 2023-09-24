# WIICMATH Server

Welcome to the server side of the WIICMATH project.

## Relevant Development Resources

These YouTube videos are valuable resources for learning how to use this solution and gaining a better understanding of the project:

- [Base Principles Part 1](https://www.youtube.com/watch?v=dwMFg6uxQ0I)
- [Base Min API Principles Part 2](https://www.youtube.com/watch?v=5tYSO5mAjXs)

Understanding ClassLibrary in general:

- [ClassLibrary](https://www.youtube.com/watch?v=C6LV_xMGdKc)

## Getting Started Locally (Visual Studio)

To set up and run the API project locally using Visual Studio, follow these steps:

Double click the solution file to open the solution in Visual Studio.

1. Open the solution in Visual Studio.
2. Right-click the `WIICMATH_API` project and ensure it is set as the startup project.
3. Right-click the `WIICMATH_DB` project, click "Publish." In the popup:
   - Click "Edit."
   - Click "Browse."
   - Select "Local."
   - Choose "MYSQLLocalDB."
   - Click "OK."
   - Name the database.
   - Save the profile in the project folder (easier for future publishing).
   - Double-click the newly created publish file.
   - Click "Publish."

4. Search for "SQL Server Object Explorer" in Visual Studio.
5. Navigate until you find your named database.
6. Right-click the database and select "Properties" to find the connection string.
7. Open the `WIICMATH_API` project and access the `appsettings.json` file.
8. Replace the connection string with the one you found in step 6. The connection string should resemble the following format:
   ```
   "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WIICMATH_DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
   ```
   Ensure there are no spaces in `(TrustServerCertificate)`, `(ApplicationIntent)`, and `(MultiSubnetFailover)`.
9. Save the `appsettings.json` file.
10. Run the project.