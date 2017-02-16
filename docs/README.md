# Manychois.GoogleApis
Class library (.Net Core) - It provides common utilities, especially OAuth2 authentication, for other Google API client libraries.

## Code examples (OAuth2)
Create an `OAuth2Credential` instance which holds the secrets downloaded from your Google API Console.
```
var credential = InstalledAppCredential.ReadFromFile("credential.json");
// or
var credential = WebAppCredential.ReadFromFile("credential.json");
```
If you already have a refresh token, you can get a new access token like this:
```
var oauth2Util = new OAuth2Utility(new NetUtility());
var tokenInfo = await oauth2Util.GetTokenInfoAsync(credential, "refreshToken");
```
If you don't and require users to grant the permissions, try this:
```
var rs = new OAuth2TokenRequestSettings();
rs.RedirectUri = credential.RedirectUrls[0];
rs.Scopes.Add("https://www.googleapis.com/auth/userinfo.email");
rs.State = Guid.NewGuid().ToString();
string url = oauth2Util.GetAuthorizationCodeRequestUrl(credential, rs);
// present this URL to user and wait for the authorization code

string authCode = ""; // now assume we got the authorization code
var tokenInfo = await oauth2Util.GetTokenInfoAsync(credential, credential.RedirectUrls[0], authCode);
// tokenInfo will contain the refresh token, store it securely
```

## To-do list
- Increase unit test coverage.
- Add richer comments in the source code.
- Provide methods for server accounts authentication.

## Reference

Using OAuth 2.0 to Access Google APIs
https://developers.google.com/identity/protocols/OAuth2

## License
[The MIT License](../LICENSE.md)

Copyright (c) 2017 Siu Pang Tommy Choi