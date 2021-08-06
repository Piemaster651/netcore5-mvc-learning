## Notes

- Contact
  - mike@maxtrain.com
  - TechTrainingNotes.blogspot.com
- Azure Pass - 30 days or $100 after activation
- One of the labs has you connect to SQL server in Azure
- Once this class ends it should be available for another three months, but beyond that we shall see.
- Book D is the most recent course in skillpipe. Might be a higher letter later.
- Modules 1-7 and 13 are the important ones we will be covering.
- You can make notes similar to google sheets. Public notes will be available to everyone in the current course.
- Section and Paragraph will be on bottom of the page. If you need to know where Mike is, look there then use the position tab.
- You can offline the course by downloading the modules to PDF. This is recommended.
- This course teaches you for the exam. 70-486 isn't too bad. 487 is apparently brutal. 
  - This exam is to get the certification. 
  - This cert won't be available after the end of the year.
- (Core MVC Beginner Tutorial)[https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc]

## Module 1: Exploring ASP.NET Core MVC

- Ajax now means an asynchronous http server call rather than Async JS and XML
- MVC was created in the 70's with smalltalk. It's a programming pattern, not toolkit.
  - Mike calls it RCMV or Routing, Controller, Model, View for reasons that will be explained later.
- Razor pages can be changed, or replaced with different rendering engines
- https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller
- Web API is the '4th generation' of sorts
  - .NET 2.0 ASMX XML SOAP
  - .NET 3.5 WCF XML, XML SOAP, JSON, Binary, ???
  - .NET ~4  WebAPI - RESTful => JSON, XML
    - REST - Representational State Transfer
    - Model, Controller returning machine-readable data. No views, but very similar to MVC
- Any client-side tech is available
- Razor pages uses AJAX and JQuery internally
- IIS on windows servers is the assumed hosting tech
  - Kestrel is built into the framework and we can run it behind IIS, or Apache to get its feature set
  - HTTP.sys is another hosting tech that replaces Kestrel in core for only windows stuff hosted on windows server.
  - Really we can run our app anywhere we can run .NET Core
- We will be learning how to be explicit in .CSHTML files for switching between code and HTML
- Overview of page tech
  - .asp class MS web
  - .aspx WebForms - code behind
  - Razor Pages - no extension nexessary. You can intercept the request and return different pages and such. It's good stuff
- Models will be used to convert data into objects 
  - Represent our data
  - POCOS (Plain, old C# objects)
  - SQL, Data Tools, and Entity Framework are examples of tools "behind the model"
- Views - HTML + Razor
- Controller - C#
  - Master controller that's intercepting the request and is deciding what to do with it.
  - Has the request data (Request object)
  - https://www.toys.com/product/123 -> it would 
- *Mike's ideal structure*
  - Routing
  - Controller
  - Model (Optional) - could be tied directly to data
  - View (Optional) - could be a webservice like and API
- .cs files are compiled, but cshtml files are interpreted. Live code change is totally possible.
- example of routing
  - https://www.toys.com/Tradeshows.asp => TradeShows -> Shows2021
  - https://www.toys.com/Products => /asp/product.asp?products=blocks,legos
  - Routing can intercept old, or new urls and redirect them to another page, so users are able to maintain their old bookmarks
- Configuration
  - .NET Framework
    - web.config        XML
  - .NET Core
    - appsettings.json  JSON
    - web.config        XML
    - settings.ini      text (kind of a joke)
- Authentication
  - Can use just about anything if configured right.
  - Active Directory (Azure Active Directory is the push here)
  - 3rd party (Facebook, Google, etc.)
- Caching
  - Module for this, but we can use this just about anywhere and in different types of projects as it's part of ASP.NET generally
- Compilation
  - MSIL distributed as .dll, or .exe - you can see the MSIL using Ildasm.exe (installed in directories with the framework)
  - Can compile C#, F#, VB, etc. into MSIL
  - Common runtime, so like Java you can run it anywhere as long as that platform has a .NET runtime
  - An int is an int is an int.
  - You can call functions in F# from C# apps due to this
- Overview of Web API
  - Web service
  - Enables external systems to use your application's business logic
  - Accessible to various HTTP clients - no special protocols needed
  - CRUD capable
  (- Example)[https://maxrestdemo.azurewebsites.net/odata/Bikes]
  - supports odata which supports queries
    - ?select=id,price&$filter=color eq 'Red'
  - https://maxrestdemo.azurewebsites.net/WebServiceTester.html
  - People don't like the Burple Bike. :(
  - update: Bikes(749)
    ```JSON
      {
        "color": "Yellow"
      } 
    ```
  - PUT will do a partial update and change bike with 749 to a yellow color
  - Will be using the stuff we learned from the MVC stuff, but without views in module 13
- Intro to Core
  - Razor pages has a codebehind like WebForms
  - In a cshtml page, "@model" up at the top is a directive
  - Core works on multiple platforms and is lighter weight
  - Every website you create is a console app that runs kestrel 
    - The console app can run anywhere and be run from the command line, wheras framework is not a console app, so it must be hosted
  - dotnet.exe ConsoleApp1.dll will run the console app, or more succintly dotnet ConsoleApp1.dll
  - You can compile razor pages to protect against an attacker who wants to deface our website if they gain access
  - The default route is defined in Startup.cs through the UseEndpoints middleware. 
  - Urls don't point to pages they point to resources which are methods in controllers and actions are returned.
  - The controller handles everything. This is the opposite of the convention that my team says is best practice.
  
### Lab 1

- Port: 44383
- TODO: Finish Sections 2 and 3
  
## Module 2: Designing Applications

- UML Use Case Diagram
- Database Design
  - Logical Modeling
    - UML Diagrams
    - Logical Data Model (LDM) Diagrams
  - Domain Model Diagram (DMD) aka conceptual data model shows the high-level conceptual objects 
  - Physical database structure
  - Working with DBAs
  - Database design in agile and extreme programming
- Middle tier with business logic is entity framework for our examples. Our team uses a more "bare metal" approach.
- Planning Globalization and Localization
  - Internally-recognized set of language codes available in browsers to present content customized to suit a user's language or region
  - resource files to provide a localized response
  - separate views if necessary
  - separate css files as well
- Accessibility
  - You can be sued for not making your website accessible.
  - World Wide Web Consortium (W3C) has a project called the Web Accessibility Initiative (WAI) that promotes accessible web content. https://aka.ms/moc-20486d-m2-pg5

### Models

- Just a class with a collection of properties
- It can include methods for getting and setting along with some simple logic related to the properties
- "prop" tab tab will create a new property with get and set
- If configured properly, EF will be able to adapt dynamically if changes are made to the models

### Views

- Wireframes are like mockups, but they should look like it's ideation and high level. Layout, content completion, etc.
- 

### Controllers

- Create one controller for each *business process*
- 

## Module 3: Configure Middleware and Services

### Middleware and Services

- Middleware can be used to add functionality to every page of the application such as checking if the client is connecting with an https connection.
- Http defines a whole host of information in the header. 
  - You can specify the type of data being sent
  - We can intercept them in the middleware and do something interesting with them.
- MVC is created by instatiating specific middleware. Without those middleware pieces you just have a base .NET 5 app that can send and recieve data. (if you specify the type of data. It'll all be interpreted as strings)
- The generic app.Use() function requires the user to call the next.Invoke() function for each middleware they create this way which will call the next one in the chain. All middleware do this behind the scenes.
  
  ```C#
  // ConfigureServices behaves more like AddServices
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();

        services.AddDbContext<TContext>(); 
        // would register a database connection to the service
    }
  ```

  ```C#
  // Configure behaves more like ConfigureServices
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
      if (env.IsDevelopment())
      // env is the DOS (or other platform) environment.
      // It's set from the environment variables, runtime options, command line arguments, etc.
      // IsDevelopment could be set in the environment variables (for example in the dev server), 
        // or it could be set in appsettings.json (like with local dev)
      {
          app.UseDeveloperExceptionPage();
      }
      else
      {
          app.UseExceptionHandler("/Home/Error");
          // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
          app.UseHsts();
      }

      app.Use(async (context, next) =>{
        await context.Response.
        await next.Invoke();
      })

      app.UseHttpsRedirection();
      // Your server needs to have a valid cert in order to use https

      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
          endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");
      });
  }
  ```

  - app.Run() is the end of the pipeline and is technically considered the "endware"
  - MVC is the app.Run() in an MVC app
- (Good diagram)[https://www.programmingwithwolfgang.com/middleware-in-asp-net-core-mvc/]


- There's a whole host of services we can add to the startup file as well as our own custom code
- This would be where you can configure the connection string based on environment and use the 

### Dependency Injection

- Any class that has a constructor can accept another class as a parameter as long as that parameter matches the correct structure needed

```C#
  public class MyClass
  {
      private IDependency _dependency; // Create the space needed for the object

      public MyClass(IDependency dependency) // Pass in the object you need
      {
          _dependency = dependency; // Fill the space with the passed in object
      }

      _dependency.doStuff(); // Use the local reference in whatever way you need.
  }

  public class Dependency : IDependency
  {
      private ISubDependency _subDependency; // Create the space needed for the object

      public Dependency(ISubDependency subDependency) // Pass in the object you need
      {
          _subDependency = subDependency; // Fill the space with the passed in object
      }

      _myDependency.doStuff(); // Use the local reference in whatever way you need.
  }

  public class SubDependency : ISubDependency
  {
      public SubDependency()
      {
          // Functionality
      }
  }
```

- Dependency injection allows the developer to define the structure generically and pass in specific values in runtime.
- Services are all dependency injected

```C#
  // IMyService
  public interface IMyService
  {
      string DoSomething();
  }


  // MyService.cs
  public class MyService : IMyService
  {
      public string DoSomething()
      {
          return "something";
      }
  }

  // Startup.cs
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IMyService, MyService>();
        // AddSingleton means create a single instance of this object to be shared everywhere in the application during runtime.
    }
    
    public void Configure(IApplicationBuilder app, IMyService myService)
    {
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(myService.DoSomething());
        });
    }
  }
```

## Module 4: Developing Controllers

- Views are never returned to the user. The controller forewards the view to the user after it's rendered. That's what razor does.
- Look into Odata query strings
- parameter mapping using routedata instead of method params
- Viewbag accepts any kind of object. It's automatically created by the controller and can be accessed like any other object. 
  - It's replaced the obsolete way of doing things 

```C#
  ViewBag.Message = "Some Text";
  Viewbag.ServerTime = DateTime.Now;
```

### ASP.NET Core Routing Engine

- Determines which controller and action should be called to handle a request
- can be configured centrally in the Startup.cs file and locally by using attributes
- Steps completed when a request is recieved from a web browswer
  1. A controller is instantiated to respond to the request. Routing is used to determine the right controller class to use.
  2. The request URL is examined. Routing is used to determine the action that needs to be called in the controller object.
  3. Model binding is used to determine the values that should be passed to the action as parameters. The model binding mechanism consults the routing entries to determine if any segments of the URL should be passed as parameters. The model binding mechanism can also pass parameters from a posted form, from the URL query string, or from uploaded files.
  4. The action is then invoked. Often, the action creates a new instance of a model class, perhaps by querying the database with the parameters passed to it by the invoker. This model object is passed to a view to render the results and send them to the response. 
- Convention-based routes
  - processed top-down and should be listed from most specific to least specific
  - placeholders
  - dummy placeholders
  - search engine optimization friendly
- Attribute-based routing
  - class decorators
- Complex Type Binding
  - parameters with the same name will be put into any field each object has with the same name
  - Overposting attacks
    - Entity Framework has the ability to write these to prevent that
    - How to prevent
      - Don't use default EF 
- Attributes that are useful
  - RequireHttps
  - Http*Verb*
    - AcceptVerbs(HttpVerbs.Post,HttpVerbs.Get,etc.) to do more than one accepted type of action verb

### Action Filters

- Classes that can be applied by using attributes to your controllers to do things like authorization and such.
- 

## Module 5: Developing Views

- There are many different view engines in .net framework, but in core, .net 6, etc. razor is the primary one.
- @inject IInterface InterfaceName is the way to dependency inject a registered service into a view.
- Tag helpers instead of html helpers. Not every html helper has been given a tag helper. 
  - The benefit of this is that it gives the flexibility of html helpers with the styling and consistency of html.
- Use attribute decorators in models to help format the data properly
- Custom Display/Edit Templates
  - will be discussed after models
- ViewBag is visible to the View, _Layout, and _PartialViews included in there. You can make a ViewBag value in the partial and reference it in the _Layout.
- View Components
  - 

## Module 6: Developing Models

- In EF, we use virtual properties to allow EF to override them with the proper reference. 
  - e.g. you can drill down in to Comment.Photo with Comment having a public virtual Photo Photo prop.
- You can use attribute decorators to limit properties (length and such) and provide more information to the Html Helpers.
- TODO: Model Binders need to be looked into
- Model data annotations help to keep things confined to the data types that users can input. 
- By applying the data annotations you can use "ModelState.IsValid" which looks at the current model(s) [works best with EF] and determines if all properties fit the required format. It will return an error and you can then show the user specific things 
- asp-validation-for is how you can display your error messages.
- @Html.ValidationSummary() makes an unordered list of errors
- @Html.ValidationMessageFor(model => model.Name) will make a span that contains the error.
- TODO: Diplay and Validation Attributes
- [AdditionalMetaData("GovernmentAgency", "true")] - you can toggle fields based on metadata.
- 

- TODO: Finish Lab 6, Task 3 and on. It's a good one! 

## Module 7: Using EF Core

- The EF Core dream
  - Define Models
  - Define DBContext
  - wizard
    - Create database
    - Create tables
  - create controllers, views, actions 
  - done'
- EF Approaches
  - Database First
    - Powershell/dotnet.exe and a connection string needed
      - Scaffold-DbContext [connectionString] -OutputDir Models
      - dotnet ef [connectionString] Microsoft.EntityFrameworkCore.SqlServer -o Models -f -c DemoDbContext
    - Create database, then use EF to generate all the classes for me
    - It's quite good at adding the proper property attributes
  - Model First
  - Code First
- Configure using the Fluent API 
  - https://en.wikipedia.org/wiki/Fluent_interface
  - https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties
- SqlConnection is a C++ com object not managed by .net. That's why you need to put it in a using statement, or call close() and dispose()
- EF is one of many Object Relational Mapping (ORM) frameworks. https://en.wikipedia.org/wiki/Object-relational_mapping
- EF Core is provider driven. One EF and a pluggable provider if we don't want to use SQL.
- You can use NoSQL (cosmosDB in Azure is default)
  - Not same structure
  - Uses json docs in the form of "Key":"Document"
- SQLite is in EVERYTHING. It's memory-based, code driven. It's in every phone, windows machine, PHP and Python, Tax Systems, Even your car.
  - https://sqlite.org/mostdeployed.html
  - https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/
  - https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory
- By defining our DBContext as a service we only use one context for each app. It's better on memory, it's better for performance.
  
### Linq

- var was created for LINQ queries. Use this to iterate through your EF Core objects and do joins and shit. We can make all the tables in C#, use that to keep version control over our database and all our queries are clear, accurate, and in our repo. Intellisense is also bangin'
```C#
  // Put this in cmd if you wanna see how much RAM notepad is using.
  using System.Linq;

  var procs = from proc in System.Diagnostics.Process.GetProcesses()
    where proc.ProcessName == "notepad"\
    orderby proc.WorkingSet64
    select new { proc.ProcessName, proc.WorkingSet64 }
    ;

  var procs2 = System.Diagnostics.Process.GetProcesses()
    .Where(p => p.ProcessName == "notepad")
    .OrderBy(p => p.WorkingSet64)
    .Select(p => new { p.Processname, p.WorkingSet64 });

  foreach (var item in procs)
  {
    Console.WriteLine($"Process {item.ProcessName} is using {item.WorkingSet64} RAM.")
  }
```
- Linq also has many, many projects and extensions with the ability to do joins across providers if the providers support all the linq features
  - Linq to excel - for execs wanting analytics
  - Linq to twitter - is anyone using our products?
  - Linq to facebook
  - etc...
- Linq to entities vs Linq to objects
- Linq SQL syntax vs Linq method syntax
- Navigation properties are used to link objects together. 
  - Choose and ORM pattern
    - Eager
      - When you load customer onbject with an order virtual property it'll load all the orders with it.
      - One request to SQL that might even be a SQL join
    - Lazy
      - When you load customer onbject with an order virtual property it won't load the orders until you call the property using linq.
      - Multiple round trips, but more space efficient.
    - Explicit
      - Take control of when it loads each property.

  ```C#
  // TODO: Section 10 Paragraph 200 demography example
    public class Country
    {
      public int Id
    }
  ```
- Using EF Core to change data
  - _context.People.Remove(person);
  - _context.SaveChanges();
  - You need to save any of the changes you make as it's cached. It's only changed in caching beforehand.
  - It will save ALL changes stored in the cache. This could make multi-option changes super easy.
- You don't need to include the table name unless the object you use in both tables is the same. It's recommended to be verbose though.
- The Repository Pattern
  - Created to satisfy testing purism. It uses dependency injection to allow the separation of the dbcontext and the controllers.
  - You can plug in a mock database class to test on instead of sql server
  - TODO: Module 7, Section 10, Paragraph 367.
  - Look up mocking tools. It'll create a class and an interface that mocks the class you want to mimic, then make all those class calls generic to an interface.
- Migrations
  - A feature built into EF allowing you through powershell, or dotnet.exe that enables applying schema changes to the database.
  - It keeps the models and the database in sync.
- (Beginner Tutorial)[https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli]

## Module 8: Using Layouts, CSS and Javascript

- _ViewStart

## Module 9: Client-Side Development
## Module 10: Testing and Troubleshooting

- Testing methods
  - Unit tests
    - Verify small units of functionality work
    - Process
      - arrange - arrange data to run the test on
      - act - call the functions with your test data
      - assert - run tests by checking results
    - Somewhat difficult to do on routing unless you generate an httprequest object 
    - Practicality Analysis 
      - Testing Database calls: By creating an interface for the entity framework (or a subset of the functions that you're using) as a repository and testing against that interface, you can pass in a test class that implements that interface that contains test data. The problem with this is two fold. One: you need to go though creating an interface for a complex library. Two: it's impossible to test 100% of your code and you need to rely on technologies like Linq which will change from Linq-to-SQL to Linq-to-objects if you pass in something other than EF. That could change the way the code functions even though in practice the data is the same. Essentially unit tests are a slipperly slope that rely on assumptions of assumptions and trust of code wizards and 3rd party libraries. 
      - Testing Views and Controllers: TODO: There's a microsoft article that goes over the process of implementing an IHttpReqest and creating a fake call etc.
      - There are tools such as Moq and NSubsitute that are frameworks from NuGet that would automagically mock the properties and methods of the interface you pass to it.
  - Integration tests
  - Acceptance
- MVC solution to errors: Exception filters applied to actions can help avoid try-catches and use custom exception handlers. Can add custom error codes to give more information.
- environment pseudo-html tag
  - In razor pages you can add <environment></environment> tags to change html based on environment.
- (Logging in Core)[https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/]
  - You inject the logging into the configure class
  - Customize the level of logging you capture dependent on which environment
- 

## Module 11: Managing Security

- You can use configuration providers to store sensitive data and have it passed to your app in runtime.
  
## Module 12: Performance and Communication
## Module 13: Implementing Web APIs
## Module 14: Hosting and Deploying

## Changes we could/should look into for the core transform

### Static File Access (wwwroot)

- Static html files can be served from the wwwroot if you want. Might be cool for an error page or something.

### Services and Middleware
### Dependency Injection
### Annotations
### Entity Framework / Database Connection

- By defining our DBContext as a service we only use one context for each app. It's better on memory, it's better for performance.
- Startup configuration example: 

```C#
  services.AddDbContext<DatabaseContextClassName>(options => 
    options.UseSqlServer(Configuration.GetConnectionString("ConnStringKey"))
  );
    .
    .
    .
  if (env.IsDevelopment())
  {
      app.UseDeveloperExceptionPage();
      // Deletes the database
      ctx.Database.EnsureDeleted();
      // Recreates the database. Make sure you preload some data!
      ctx.Database.EnsureCreated();
  }
```

- You can be sure that the sql being sent to the database will be efficient, safe, and well-written*
- Linq is nearly as fast as the native SQL as it's quite low overhead. 
- The queries we make will be created using intellisense and they'll be stored in our repo. We can't say that about the 'CUDR's.
- EF is a caching environment, so there are options to define how it caches the data thus making it more efficient on page loads as it stores that data in memory
- Migrations through EF allow us to store the schema and apply changes/rollback changes. REALLY NICE!