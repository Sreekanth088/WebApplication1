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
* Used Tools > NuGet Package MAnager, Command executed successfully
* After migration Migrations\20240201031658_InitialCreate.cs appeared.
* Examined generated database

Part 5
* Migration Code appeared
* Connected to SQL database, No errors found
* Added new movies to seed data.

Part 6
* Controller methods and views
* Used scaffolding to generate code for editing movie data in the database
* Used Tag Helpers and data annotations to streamline the HTML markup and validation logic.

Part 7
* Implimenting search bar.
* Added searchstring to do the searching action by replacing the index methode. 
* replaced 'searchString' with 'id' and viceversa examined the filtering methode.
* Added MovieGenre view model as a filter option.
* Verified the search and filtering are working fine, and it worked perfectly fine.  

Part 8
* Added the rating property within Models/Movie.cs.
* Updated the [Bind] attribute in MoviesController.cs for both the Create and Edit action methods to include the Rating property.
* Added Rating field /Views/Movies/Index.cshtml.
* Added Rating field /Views/Movies/Create.cshtml.
* Added new rate field and data to SeedData.
* Ran Migration command to view the reflection.

Part 9
* validation
* Included the character limit and 
* error occurred while running the webpage error occured but when the rating field got updated the error got resolved.

Part 10
* Gone through Details & Delete methods.
* Reviewed the details method.
* Gone through program.cs as mentioned on the instruction.
* examined delete and deleteconfirmed.

