### Brief

Now we will continue the coffee shop application, but we will be rendering live data from a MySQL database using Entity Framework as our ORM.

### Instructions

- Continue working with the coffee shop application from the last activity.

- From within the application's directory, run each of the commands below to include the necessary libraries for the ORM, Entity Framework.

  - `dotnet add package Microsoft.EntityFrameworkCore`
  - `dotnet add package Pomelo.EntityFrameworkCore.MySql`
  - `dotnet add package Microsoft.EntityFrameworkCore.Design`

- Create a Coffee Model `Coffee.cs` that has the following properties: `ID`, `Name`, `Roast`.

- Create a `MyDbContext.cs` file in your `Models` directory using the instructor's example as a guide. You will need a DbSet of `Coffees`. Also, make sure that you update your MySQL connection string to match your database.

- Create an instance of `MyDbContext` within your `Startup` class' constructor.

- Also within your `Startup.cs` provide some seed Coffee data at the end of the `Configure()` method (use instructor's example as a guide).

- You Model is all set, but you still need to update your Controller and View to see the Coffee.

- Inside of the Controller's `Index()` route, create and instance of `MyDbContext`, then pass it to your `View()` method.

- Finally, edit your `Index.cshtml` so that it declares the model of enumerable coffees, then iterates them to rendering each Roast.

