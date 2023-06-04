I'm going to use this README to cry telling you my story doing the course, so if you're doing the course and reading this, you'll probably find a solution to some problem or other, or just read my cries.

This course that I have started was free due to an agreement between universities, including the UCO. While I'm doing the course I upload everythin to GitHub separate by the differents modules of 
the course.

My first contact with Razor Pages and .NET has been with this course, for example in module4/ I cloned a repository to follow the instructions to start in the .NET world and update the views 
of an already created web application, that's why the reference to the repository.
In order to work with .NET, I decided that the best option (the one that would give me the least version headaches) would be to install "Dev Containers" for VSCode and 
launch a virtual environment with the default settings for the repository.

MODULE5
After 1 hours having problems because the URL where I had my folder with the project crashed with internal files of SDK, I decided to move the project to /home and surprisingly it worked. Then the course present Http Repl to prove the API that we are doing, and when I installed it and i go to connect the https://localhost:{PORT} the following error appears:
Unable to find an OpenAPI description
And I said, okey i have to trust https certs with "dotnet dev-certs https --trust" and 2 hours (with a lot of errors) later I read that is not compatible with Ubuntu 20.04 and I found a BRILLIANT repo that solve the problem that I want to share: https://github.com/BorisWilhelms/create-dotnet-devcert THANKS YOU
