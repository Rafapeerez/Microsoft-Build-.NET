I'm going to use this README to cry telling you my story doing the course, so if you're doing the course and reading this, you'll probably find a solution to some problem or other, or just read my cries.

This course that I have started was free due to an agreement between universities, including the UCO. While I'm doing the course I upload everythin to GitHub separate by the differents modules of 
the course.
- MODULE1,2,3: Introduction and basics of accessibility.

- MODULE4: Create a web UI with ASP.NET Core
My first contact with Razor Pages and .NET has been with this module, I cloned a repository to follow the instructions to start in the .NET world and update the views 
of an already created web application, that's why the reference to the repository.
In order to work with .NET, I decided that the best option (the one that would give me the least version headaches) would be to install "Dev Containers" for VSCode and 
launch a virtual environment with the default settings for the repository.

- MODULE5: Create a web API with ASP.NET Core controllers
After 1 hours having problems because the URL where I had my folder with the project crashed with internal files of SDK, I decided to move the project to /home and surprisingly it worked. Then the course present Http Repl to prove the API that we are doing, and when I installed it and i go to connect the https://localhost:{PORT} the following error appears:
Unable to find an OpenAPI description
And I said, okey i have to trust https certs with "dotnet dev-certs https --trust" and 2 hours (with a lot of errors) later I read that is not compatible with Ubuntu 20.04 and I found a BRILLIANT repo that solve the problem that I want to share: https://github.com/BorisWilhelms/create-dotnet-devcert THANKS YOU

- MODULE6: Publish a web app to Azure with Visual Studio
This module start with problems, I need to work in Windows to be able to install Visual Studio (is not the same Visual Studio Code) because it is not compatible
with Ubuntu. If I want to work with th IDE of Visual, I would have to configure my Visual Studio Code.
I have installed Visual Studio 2022 because the module was geared to work with this IDE. Finally I could complete without problems all the steps.
To launch the project in Azure, the course offers a sandbox to prove  during 3 hours and 10 tries per day.

- MODULE7: Introduction to .NET
I don't understand why at this point in the course we have an Introduction to .NET when we have already created some projects with his technologie.
I completed it and I pushed a summary in a .txt to the folder, anyway, no more.

- MODULE8: Create a new .NET project and work with dependencies
This module has not technique part, I have created an project example to work with depencies and their version. It is a lot of teoric part explaining major version, minor version and patch version.

- MODULE9: Interactively debug .NET apps with the Visual Studio Code debugger
Module 9 is a very small Fibonacci project that I was able to experiment with in the debugger. I used it to fix my .NET programs. Also, I have learned how to use System.Diagnostic.Debug and System.Diagnostic.Trace, as well as different methods of these classes.

- MODULE10: Work with files and directories in a .NET app
This module teach us basically how to work with files and directories. My Program.cs is all commented(all the most important functions that allow work with files and directories) except a function that I think is the most complete that has a little of everything.
This project is cloned to follow the course and to work with the files and directories created. (https://github.com/MicrosoftDocs/mslearn-dotnet-files)

- MODULE11: Introduction to Web Development with Blazor
The module introduce Blazor, a user-interface framework for .NET and Razor. As we already know, Razor is a format that can contain a mix of C# code and HTML. It also explain the two differents types of Blazor exists, Blazor WebAssembly and Blazor Server, when to use this framework and the advantages and disadvantages.
There is no folder for this module because the explanation wasn't long.

- MODULE12: Build a web app with Blazor
This module has been the one that I have liked the most, I have created a Blazor project with "dotnet new blazorserver -f net6.0", then I launched it to see how it was with "dotnet run watch" and following th course I have created a new component with "dotnet new razorcomponent -n {name} -o {path/ubication}". Finally I did a basic TO-DO list with this framework that is better and easily than I expected.

- MODULE13: Interact with data in Blazor web apps
I liked a lot this module too because it is very complete, useful and very visual. On the other hand, sometimes there are parts of code that it is "Ctrl+C, Ctrl+V" if you want that it works. By this I mean that I have to go to other sources of information to know what the code does.  It consists in clone the github repo(https://github.com/MicrosoftDocs/mslearn-interact-with-data-blazor-web-apps.git) and create an UI working with components,  services, access and share data and bind this data with UI. Honestly, the final result is aweasome but it takes time to inderstand the code (is not the 59 minutes that the course says)

- MODULE14: Use pages, routing, and layouts to improve Blazor navigation
It explains how to navigate between different pages and use the URL to guide the customer, how to pass constraint parameters in the URL and hoe to build reusable Blazor components using layouts.
Start by cloning thus repo (https://github.com/MicrosoftDocs/mslearn-blazor-navigation.git), basically is the same project we finish in the last module with some new files and the challenge is to redirect and create some error pages.  
The project gives an error because when I go to read the content of the JSON that should be passed with the order values, it does not read them because I am not sure if it is passed empty or the order values are not passed correctly. I have been trying for a few hours trying to solve it but I cannot find it, so I am going to continue with the course that I have a few days left until the end of the period to finish it.I don't understand why this happens because I have even tried doing copy-paste from the code provided and it doesn't work. When I finished all the course I will return to this module to try to fix it.

- MODULE15: Improve how forms and validation work in Blazor web apps
The first thing I want to say is that here the redirect and JSON pass well(HAVING EXACTLY THE SAME) and the last module no, same old shit anyway. In this module I learn different event handlers and how ato fire it, how to focus, the component EditForm and how take advantage and validate forms.
I have to say that I like a lot the way that Blazor has to validate forms, it is very comfortable. 

- MODULE16: Buid rich interactive components with Blazor web apps
First of all, I had problems running the repository I had cloned (https://github.com/MicrosoftDocs/mslearn-build-interactive-components-blazor.git) because the course is constantly changing the version .NET to run, we went from running the program in version 6 to version 7. 
The firts unit explains how to insert some JavaScript libraris in our code, next explains the lifecycle of the components and how is there function called, and the last unit is about reuse components by creating templates.

- MODULE17: Build reusable components with Blazor
This module has been short, I have built and packaged a Blazor Conponents to use it in a Blazor application. I have created the library with "dotnet new razorclasslib -o FirstClassLibrary -f net6.0" then the Blazor Server "dotnet new blazorserver -o MyBlazorServer -f net6.0" and for last I referenced the library to the server with "dotnet add reference ../FirstClassLibrary".


- MODULE18: Build Connect Four game with Blazor.
Oh god, this module looks funny and then its sucks. First of all the exercises are explained to do with Visual Studio 2022 (again), to people who wants do in terminal to create a WebAssembly Blazor Project is with "dotnet new blazorwasm". Furthemore, that "programming the game" thing is in quotes. They give you all the logic, and a CSS code (it's essential for the pieces to fall) well, spoiler, they give it to you wrong. You have to change CSS variables so that the pieces fall centered and stay in the position that they have (many hours with browser inspector).
Finally I push what I can if I want to continue with the course before it ends (11 days), at least one game can be played.

- MODULE19/20/21: Externalize the configuration of an ASP.NET app by using an Azure key vault,implment logging and immprove session scalability by using Azure Cache for Redis.
These 3 modules dont have folders in the repository because the configuration has been all the time by terminal. There is also a sandbox for azure that is given by the course. In the first two modules  I have used ConfigurationBuilder to retrieve access keys from the Azure keystore at runtime as well as the mechanism for this. I have also seen why logging is important to record and monitor application activities and how to implement them with Azure Blob Storage.
Finally, I have learned how to use Azure Cache for Redis to store session data and improve the scalability of web applications.

- MODULE22: Build a web API with minimal API, ASP.NET Core, and .NET
This module has been short but very useful. Its about how implement an easy API with little code, using the minimal template of Net6.0. Also I have used Swagger by addding like a new package. Created using "dotnet new web -o Pizza -f net6.0"

- MODULE23: Use a database with minimal API, Entity Framework Core, and ASP.NET Core
This module has been interesting connecting a minimal API with a SQLite database to persist data. To create the databse I needed install Microsoft.EntityFrameworkCore.Design (among many other packages that can see in PizzaStore.csj). When the conection string is prepared, is needed to create Migrations folder with "dotnet ef migrations add InitialCreate" and finally "dotnet ef database update" to apply migrations.
To access and try the CRUD operations created, you must do a "dotnet run" adn go to http://localhost:{PORT}/swagger.

- MODULE24: Create a full stack application by using React and minimal API for ASP.NET Core
There is an error like this "npm ERR! Cannot read properties of null (reading 'edgesOut')" installing styled-components. I have used npm instead of yarn and what you hav to do to avoid having the error is install an specific version doing "npm install styled-components@5.3.10".
There is a second bug that is from the repository that the course makes you clone (https://github.com/MicrosoftDocs/minimal-api-work-with-databases). If you do what the module said, you will see an error saying that "JSON.parse: unexpected character at line 1 column 1 of the JSON data". That's because on line 38 of Program.cs it is doing the Get to /pizza while on frontend it is doing to /pizzas. If you change the line 38 to this "app.MapGet("/pizzas", async(PizzaDb db) => await db.Pizzas.ToListAsync());" it will go well.
This moodule is about how to connect a frontend app with an API, using CORS and doing by steps. Fisrt doing the frontend, second launching a mock API with "npx json-server --watch --port 5000 db.json" and adding to the package.json the property proxy, in this case port 5000. And fiinally with an API created using .NET, doing first of all the "dotnet ef database update" then "dotnet run" and changing poxy to port indicate, in this case :5059.

- MODULE25: Build your first microservice with .NET 
I did not like this module, at a theoretical level about what a microservice is it is quite complete, but I did not like the practical exercise nor does it clarify anything, you only use Docker and Docker Compose and it is not very well explained.
The first exercise has been to create the DockerFile, do "docker build -t pizzabackend ." and then "docker build -t pizzabackend .". The second will create the docker-compose.yml by doing a "docker compose build" and a "docker compose build".
Finally to see the pizza menu is at http://localhost:5902

- MODULE26: Deploy a .NET microservice to Kubernetes
In this module I have learned how to deploy a .NET application already partioned into containerized microservices into Kubernetes environment. I first pushed the Docker images to Docker Hub to make the images available to the Kubernetes instance to download. I also have learned how to scale it using Kubernetes. 

- MODULE27: Create and deploy a cloud-native ASP.NET Core microservice
This module doesn't have folder because to work and do the exercises I have to insert my credit card to have a free trial in Azure. I prefer not to do it and see only the theoretical part.
Basically, the module is about implementing a coupon microservice in an online e-commerce made using microservices. The code runs in AKS (Azure Kubernetes Service) and the Docker image is pulished in Azure Container Regisitry. 
I would like to have been able to carry out this practical module because it is quite interesting and resembles reality. If someone who reads this (I think no one will ever get here) knows how to do it so that they don't have to enter bank details, contact me on Twitter (I have it in my personal README).

- MODULE28: Implement resiliency in a cloud-native ASP.NET Core microservice 
What happens in the previous module happens in this, it is neccessary to have Azure Suscription, so I can't do practice.
This module is about the resiliency, both as Code-based resiliency as Infraestucture-based resiliency. It implements the method to have good resiliency in the service made in the previous module using Polly and Linkerd.

- MODULE29: Instrument a cloud-native ASP.NET Core microservice
- MODULE30: Implement feature flags in a cloud-native ASP.NET Core microservices app
- MODULE31: Use managed data stores in a cloud-native ASP.NET Core microservices app
- MODULE32: Understand API gateways in a cloud-native ASP.NET Core microservices app
- MODULE33: Deploy a cloud-native ASP.NET Core microservice with GitHub Actions
I'm upset that all the modules are remain to be done require to have the Azure Sucription. I refuse to have to insert my credit card to complete my course. Meanwhile, I'm going to continue doing the course because there are 6 days left until the course ends and at least I learn something more about microservices even if I don't do the practice.I guess I'll come back when I have more time to finish and do the practical part, I'll register or look for an alternative more carefully. 
In any case, I leave small summaries of all the modules to know what they are about.
(29) --> The module  focuses on the review of logging and monitoring in microservices architectures. It  discusses the importance of structured logging, centralized logging, and log correlation, and  also covers various logging and monitoring tools such as Azure Monitor, Application Insights, and ELK stack. The module emphasizes the need for comprehensive logging strategies to enable effective troubleshooting and monitoring of microservices applications.  
(30) -->
(31) -->
(32) -->
(33) -->  

