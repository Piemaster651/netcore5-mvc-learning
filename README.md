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
- 

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
  - Example: https://maxrestdemo.azurewebsites.net/odata/Bikes
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

- Middleware can be used to add functionality to every page of the application such as checking if the client is connecting with an https connection.
- Http defines a whole host of information in the header. 
  - You can specify the type of data being sent
  - We can intercept them in the middleware and do something interesting with them.
- MVC is created by instatiating specific middleware. Without those middleware pieces you just have a base .NET 5 app that can send and recieve data. (if you specify the type of data. It'll all be interpreted as strings)
- ConfigureServices behaves more like AddServices
- Configure behaves more like ConfigureServices
  - app.Use() invokes the next.Invoke() function for each middleware which will call the next one in the chain
  
  ```C#
    services.AddDbContext<TContext>(); 
    // would register a database connection to the service
  ```

  ```C#
    
  ```

  - app.Run() is the end of the pipeline and is technically considered the "endware"
  - MVC is the app.Run() in an MVC app
- Good diagram: https://www.programmingwithwolfgang.com/middleware-in-asp-net-core-mvc/


- There's a whole host of services we can add to the startup file as well as our own custom code
- This would be where you can configure the connection string based on environment and use the 
## Module 4: Developing Controllers
## Module 5: Developing Views
## Module 6: Developing Models
## Module 7: Using EF Core
## Module 8: Using Layouts, CSS and Javascript
## Module 9: Client-Side Development
## Module 10: Testing and Troubleshooting
## Module 11: Managing Security
## Module 12: Performance and Communication
## Module 13: Implementing Web APIs
## Module 14: Hosting and Deploying