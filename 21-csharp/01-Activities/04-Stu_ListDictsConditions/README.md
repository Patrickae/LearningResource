### Brief

The student script from last time was a good first-pass. Now, it's time to make it a bit more robust.

To start, refactor such that all of your prompts occur within an infinite loop, which doesn't break until the user indicates the information they entered is correct. Only print the information after their confirmation.

Next, refactor your program such that, after users confirm that they've entered the correct information, your program prompts them as to whether they'd like to enter information for additional students.

 * As an "easy" challenge, simply allow them to enter the values again, and print the information after they confirm it's correct.
 * Your recommended challenge is to store student information in a dict.

    When the user confirms their information is correct, add the student to a list of students.

    When the user says "no" to adding more students, print every student in the list.

    Oh, one hint--you'll want to initialize your students list outside of your loop.
 * For additional fun, figure out how to let the user type in either Y or y (lowercase) for "yes". Hint: Call the lower() method on a string.

    What does it do?

### Instructions

* Create a directory for your project and `cd` into it.

* Run `dotnet new console` to create a console application.

* Provide the functionality above within the Program's `Main()` function.

  * To start, wrap your code in an infinite loop. What does this look like?

  * Next, create a dictionary, whose keys and values are both strings.

  * Prompt user for student"s identification information, and store it...

  * Prompt user for student"s contact information, and store it...

  * Print everything to the console...

  * Use a conditional statement to prompt the user if the information is correct. If they say "No", simply continue the loop, so they can enter the information again.

    If they say "No", exit the program.

### Bonus

* Begin thinking about how you would refactor the program to collect a list of students, each having their own dictionary with these attributes.


