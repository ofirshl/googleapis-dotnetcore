# Manychois.GoogleApis.AdWords
.Net Core client library for AdWords API (v201609).

**Please note that it is still in development phase, be prepared for changes when you choose to use it.**

There are a few key differences from the corresponding official .Net client library:
- **No direct support of OAuth2 flow.** Basically you will only need access token and developer token to make the API call. How to retrieve, refresh and store the access token is out of this library concern.
- **Easier for unit testing.** Each service has a corresponding interface, e.g. `ICampaignService` for `CampaignService`. (Ironically I haven't built unit tests for this library yet.)
- **Async methods for all network traffic.** Leverage async power in service methods, e.g. `public Task<CampaignReturnValue> MutateAsync(IEnumerable<CampaignOperation> operations)`.
- **Utilize `IEnumerable<T>` and `List<T>`.** Most array-type parameters and object properties in the official library are converted to a more flexible type.
- **Follow C# coding convention.** No more camelcase property or method names. Enum members are converted from something like `FAMILY_SAFE` to `FamilySafe`.

## Motivation
Google does not provide a .Net Core client library for AdWords API. Instead of a simple port from an existing .Net library, I try to rewrite the whole thing (or reinvent the wheel if you like) in hope of providing a better C# coding experience.

## Code example
```
var config = new AdWordsApiConfig(null); // ILoggerFactory is optional
config.AccessToken = "...";
config.DeveloperToken = "...";
config.ClientCustomerId = "...";

ICampaignService service = new CampaignService(config);
var selector = new Selector();
selector.Fields = new List<string>(new string[] { "CampaignId", "CampaignName" } );
var campaignPage = await service.GetAsync(selector).ConfigureAwait(false);
```

More examples can be found in the project Manychois.GoogleApis.Examples.

## Versioning
Say you want to use AdWords API v201609, please look for this library version 2016.9.* (Last number indicates incremental updates for v201609). Versions prior to v201609 will never be implemented.

## To-do list
- Add unit test.
- Add comments to non-auto generated classes.
- Add support to AWQL.
- More coding examples.
- Minimize the usage of hard-coded string when using `Selector`, `Predicate`, etc.

## Reference

AdWords API call structure (SOAP)
https://developers.google.com/adwords/api/docs/guides/call-structure

AdWords API call strucure for Reporting
https://developers.google.com/adwords/api/docs/guides/reporting 

## License
[The MIT License](../../LICENSE.md)

Copyright (c) 2017 Siu Pang Tommy Choi