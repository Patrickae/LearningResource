### Brief

In this exercise, you'll continue creating the coffee shop application.

### Instructions

- Create new view files for your `CoffeesController`'s `Index` and `About` routes. Return a `View()` from each of them. Make the appropriate changes to the methods' return types.
- Update your index template such that it displays a user's first and last names. Set these values in the `ViewData` dictionary in your `Index` method.
- Similarly, write a short description of your application in your `About` template. Use a variable called `"AppName"`. Set it in the `ViewData` dictionary in your `About` method.

### Bonus

* Research receiving parameters from the browser's URL.
* Pull the user's first and last name off of the URL, then set the ViewData for the Index method from that.