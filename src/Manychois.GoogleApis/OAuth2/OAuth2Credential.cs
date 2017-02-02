namespace Manychois.GoogleApis.OAuth2
{
	public abstract class OAuth2Credential
	{
		public OAuth2CredentialType AppType { get; protected set; }
		public string ClientId { get; protected set; }
		public string ProjectId { get; protected set; }
		public string AuthUri { get; protected set; }
		public string TokenUri { get; protected set; }
		public string AuthProviderX509CertUrl { get; protected set; }
		public string ClientSecret { get; protected set; }
		public string[] RedirectUrls { get; protected set; }
	}
}
