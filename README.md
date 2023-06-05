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
