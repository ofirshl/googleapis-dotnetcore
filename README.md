# Manychois.GoogleApis
This is a project to provide a .Net Core client libraries for Google AdWords API.

## Motivation
Google does not provide a .Net Core client library for some of its APIs. Instead of a simple port from an existing .Net library, I try to rewrite the whole thing (or reinvent the wheel if you like) in hope of providing a better C# coding experience.

## Project Structure

### Manychois.GoogleApis
Class library (.Net Core) - It provides common utilities for other Google API client libraries.

### Manychois.GoogleApis.AdWords
Class library (.Net Core) - Client library for AdWords API.

### Manychois.GoogleApis.DevConsole
Console Application (.Net 4.6.1) - The code builder of the generated files used in Manychois.GoogleApis.AdWords. People who are interested in providing AdWords client library in other programming languages may find it useful.

### Manychois.GoogleApis.Examples
Console Application (.Net Core) - It provides some sample usage of the client libraries. Change of source code and configuration file is required to run the program.

## Reference
Using OAuth 2.0 to Access Google APIs
https://developers.google.com/identity/protocols/OAuth2

## License
[The MIT License](LICENSE.md)

Copyright (c) 2017 Siu Pang Tommy Choi