# Manychois.GoogleApis
This is a project to provide a .Net Core client library for Google AdWords API.

## Motivation
Google does not provide a .Net Core client library for some of its APIs. Instead of a simple port from an existing .Net library, I try to rewrite the whole thing (or reinvent the wheel if you like) in hope of providing a better C# coding experience.

## Project Structure

### Manychois.GoogleApis
Class library (.Net Core) - It provides common utilities, especially OAuth2 authentication, for other Google API client libraries. [Click here for more information](docs/README.md)

### Manychois.GoogleApis.AdWords
Class library (.Net Core) - Client library for AdWords API. [Click here for more information](docs/AdWords/README.md)

### Manychois.GoogleApis.DevConsole
Console Application (.Net 4.6.1) - The code builder of the generated files used in Manychois.GoogleApis.AdWords. People who are interested in providing AdWords client library in other programming languages may find it useful.

### Manychois.GoogleApis.Examples
Console Application (.Net Core) - It provides some samples of the client libraries. It will not run properly without changing the source code and filling in correct configurations.

## License
[The MIT License](LICENSE.md)

Copyright (c) 2017 Siu Pang Tommy Choi