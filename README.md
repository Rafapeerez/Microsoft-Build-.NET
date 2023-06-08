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

- MODULE19: Externalize the configuration of an ASP.NET app by using an Azure key vault
