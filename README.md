# OnlyCats

HTTP endpoint .Net Framework

## Requirements

-   Visual Studio
-   .NET 7.0

## How to use

1.  Pull project and open the solution in visual studio
2.  Build the project and install necessary packages
3.  Run the project using http

## How to test

1.  You can test the endpoint by using postman, Advanced Rest Client, or any other endpoint testing tool
2.  Example: POST to http://localhost:5042/api/replacedog with the body { "text":"dog" }

## Unit testing project

1.  In the solution click "Run All Tests" from the test menu dropdown
2.  This will run a unittest to confirm that the endpoint responds with Ok status code and did properly convert "dog" to "cat"

## Limitations

-   Does not account for capital letters when looking for the string "dog", however, the goal was to look for the exact string "dog". Unsure if this is a limitation.

## Additions to be made given more time

-   Use some sort of API documentation generation tool to fully document the API
-   Given more requirements fully flesh out a CRUD API revolving around feline information
