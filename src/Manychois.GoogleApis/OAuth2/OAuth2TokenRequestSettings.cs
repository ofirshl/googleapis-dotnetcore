using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public class OAuth2TokenRequestSettings
	{
		private List<string> _scopes = new List<string>();
		private List<OAuth2TokenRequestPrompt> _prompts = new List<OAuth2TokenRequestPrompt>();
		public OAuth2TokenRequestSettings()
		{
			IsOnlineAccess = true;
		}
		public string RedirectUri { get; set; }
		public IList<string> Scopes { get { return _scopes; } }

		public string State { get; set; }

		public bool IsOnlineAccess { get; set; }

		public IList<OAuth2TokenRequestPrompt> Prompts { get { return _prompts; } }

		public string LoginHint { get; set; }
		public bool IncludeGrantedScopes { get; set; }
	}
}
