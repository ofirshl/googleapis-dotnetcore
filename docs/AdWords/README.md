# Manychois.GoogleApis.AdWords
.Net Core client library for AdWords API (v201609).

**Please note that it is still in development phase, be prepared for changes when you choose to use it.**

There are a few key differences from the corresponding official .Net client library:
- **No configuration file.** I find this way easier for now, but I may change my mind later. 
- **No direct support of OAuth2 flow.** Basically you will only need access token and developer token to make the API call. How to retrieve, refresh and store the access token is out of this library concern. However, you can find some useful utility in the common library Manychois.GoogleApis.
- **Easier for unit testing.** Each service has a corresponding interface, e.g. `ICampaignService` for `CampaignService`. ~~(Ironically I haven't built unit tests for this library yet.)~~ (Some unit tests are written to prove correctness, I am still improving it.)
- **Async methods for all network traffic.** Leverage async power in service methods, e.g. `public Task<CampaignReturnValue> MutateAsync(IEnumerable<CampaignOperation> operations)`.
- **Utilize `IEnumerable<T>` and `List<T>`.** Most array-type parameters and object properties in the official library are converted to a more flexible type.
- **Follow C# coding convention.** No more camelcase property or method names. Enum members are converted from something like `FAMILY_SAFE` to `FamilySafe`.
- **Less hard-coded string.** Use e.g. `Selector<CampaignServiceField>` and deal with Enums to reduce typo mistakes.

## Code example
```
var adWordsApiConfig = new AdWordsApiConfig();
adWordsApiConfig.AccessToken = "...";
adWordsApiConfig.ClientCustomerId = "...";
adWordsApiConfig.DeveloperToken = "...";

ICampaignService campaignService = new CampaignService(adWordsApiConfig, netUtil, loggerFactory);
var selector = new Selector<CampaignServiceField>()
	.AddFields(CampaignServiceField.Id, CampaignServiceField.Name)
	.AddPredicate(CampaignServiceField.Status, PredicateOperator.Equals, CampaignStatus.Enabled.ToXmlValue());
var campaignPage = await campaignService.GetAsync(selector);
```

More sample codes can be found in the project [Manychois.GoogleApis.Examples](https://github.com/manychois/googleapis-dotnetcore/tree/master/src/Manychois.GoogleApis.Examples).

## Versioning
Say you want to use AdWords API v201609, please look for this library version 2016.9.* (Last number indicates incremental updates of this library). Versions prior to v201609 will never be implemented.

## To-do list
- Increase unit test coverage.
- Add richer comments in the source code.
- Minimize the usage of hard-coded string when using `Selector`, `Predicate` in generating reports.
- Help parsing report content.

## Change log

**v2016.9.2**
- Change service constructor parameters (adding INetUtility and ILoggerFactory).
- Simplify AdWordsApiConfig into a plain object.
- ReportUtility now support AWQL.
- Introduce `Selector<T>` and a lot of new Enums to reduce string hard-coding.
- Bug fixes (generating SOAP request, AWQL report request).

**v2016.9.1** - Initial release.

## Reference

AdWords API call structure (SOAP)
https://developers.google.com/adwords/api/docs/guides/call-structure

AdWords API call structure for Reporting
https://developers.google.com/adwords/api/docs/guides/reporting 

## License
[The MIT License](../../LICENSE.md)

Copyright (c) 2017 Siu Pang Tommy Choi