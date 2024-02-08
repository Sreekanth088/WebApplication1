2024-01-31 21:09:00

* Run completed with desired output webpage no error occured.  

Part 2

* Appended HelloWorld and HelloWorld/Welcome
Both worked fine with the return text.

* Appended /HelloWorld/Welcome?name=Gopi&numtimes=100 
web page give the response, No error found.

* worked fine and no error occured.

Part 3

* Index page Appeared fine. No error seen :)
* No error happened while running Movie List page appeared fine.
* https://localhost:{PORT}/HelloWorld/Welcome?name=Sharu&numtimes=30
* Yay! Got the 40 text displayed on webpage.

Part 4
A class was added to the Model folder and named "movie.cs".
Next, within the Controllers folder, a New Scaffolded Item was added, opting for the movie option as the model class.
To obtain the Migration folder, the NuGet Package Manager was accessed from the Tools menu,
and the necessary command was executed within the Package Manager Console.
The app was then executed, the Movie App was chosen, and the data was modified.
Models serve to embody the data and business logic of an application.

Part 5
Migration Code appeared
Connected SQL database
Added new data to database

Part 6
Controller methods and views
Used scaffolding to generate code for editing movie data in the database
Used Tag Helpers and data annotations to streamline the HTML markup and validation logic.

Part 7
To incorporate the search bar.
The index method within Controllers/MoviesController.cs was revised.
The parameter was altered to 'id' and all instances of 'searchString' were replaced with 'id'.
Subsequently, the index method was reverted to accept a parameter named 'searchString'.
The Views/Movies/Index.cshtml file was accessed, and the <form> markup was introduced utilizing the form tag helper.
This setup ensures that upon form submission, the filter string is posted to the Index action of the movies controller.

Part 8
To incorporate a Rating Property into the Movie Model.
Added the rating property within Models/Movie.cs.
Updated the [Bind] attribute in MoviesController.cs for both the Create and Edit action methods to include the Rating property.
Edited the /Views/Movies/Index.cshtml file to include a Rating field.
Updated the /Views/Movies/Create.cshtml file with a Rating field.
Adjusted the SeedData by incorporating the rating division to ensure a value for the new column.
The application encountered issues until the database was updated; thus, the database was updated by executing the ADD MIGRATION command in PMC.

Part 9
To implement validation.
Enhanced the Movie class to utilize built-in validation attributes like Required, StringLength, RegularExpression, Range, and the DataType formatting attribute.
Included Minimum Length and Regular Expression attributes to restrict character input.
An error occurred subsequently, which was resolved by assigning ratings to existing movies in the database.
The database was accessed by navigating through View > SQL Server Object Explorer > SQL Server > Databases > MvcMovie context > dbo.movie.

Part 10
To analyze the Details and Delete methods.
Accessed the movie controller class to review the details method.
Referenced the segments defined in program.cs.
Inspected the delete and deleteconfirmed methods.
Named the [HttpPost] method responsible for data deletion as DeleteConfirmed, providing it with a distinct signature or name within the HTTP POST method.
