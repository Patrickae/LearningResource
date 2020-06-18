### Instructions

* Create a directory for your project and `cd` into it.
* Run `dotnet new console` to create a console application.
* Provide the functionality within the Program's `Main()` function.
  * Create necessary methods:
    * **saveAttribute()** : Write a method that accepts a string (attribute) and a Dictionary<string, string> (student). This method should prompt the user for the one of the student's attributes (e.g., "first name", "last name"), and save the user's input to the dictionary.
    * **printEntries()** : Write a method that accepts a Dictionary<string, string> (student), and prints all of its key/value pairs.
    * **confirm()** : Write a method that prompts a user as to whether the information they've entered for the student is correct. It should return true if the user enters "Y" or "y", and false otherwise (a boolean).
    * You are free to include your helper functions directly in Program.cs. If you finish early, however, try the below exercise as a bonus.
  * Create the main logic:
    * Create an instance of 'students' that is a List of Dictionaries.
    * Inside of an infinite loop:
      * Create in instance of a 'student'.
      * Create an array of strings that will represent our students' attributes.
      * Iterate those attributes, and collect their values using the *saveAttribute()* function.
      * Print the entries using *printEntries()*.
      * Utilize *confirm()* to determine if you should exit the loop.


### Bonus

* If you get everything working and have time to spare, try moving them to a Helpers.cs file. Remember to put Helpers.cs in the correct namespace.
* If you try to compile this, you'll get an error. If you add the keyword "public" before the keyword "static" on each method in Helpers.cs, the  error will go away.
* We'll discuss his in detail during the review, but for now--why do you think C# does this? Don't worry about coming up with the "right" answer. Just come up with some ideas to share.