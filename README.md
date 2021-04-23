# test-probabilities

This has been implemented as a REST API on .NET Core 3.1 and Swagger can be used to enter the inputs and see the output (It's the landing page when the app starts). As the purpose of the exercise was not to create an API itself , I haven't formatted the responses in any special way.

The path for the file with the output can be set on the appsettings config file (AppSettings/LogFilePath property)

Implementation of the calculator has been done probably in an over architected way but just to prove the use of some common OO design patterns and make it all reusable and extensible. 

More extensive unit/integration tests could have been created but I believe the ones I added are enough to prove the idea.
