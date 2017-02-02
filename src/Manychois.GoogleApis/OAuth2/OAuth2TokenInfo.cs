using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public class OAuth2TokenInfo
	{
		public static OAuth2TokenInfo CreateFromJson(string json)
		{
			var jsonObj = JsonConvert.DeserializeObject<Json>(json);
			var token = new OAuth2TokenInfo();
			token.AccessToken = jsonObj.access_token;
			token.ExpiresIn = jsonObj.expires_in;
			token.RefreshToken = jsonObj.refresh_token;
			token.IdToken = jsonObj.id_token;
			return token;
		}

		public string RefreshToken { get; set; }
		public string AccessToken { get; set; }
		public DateTime IssuedTime { get; set; }
		public int ExpiresIn { get; set; }
		public string IdToken { get; set; }

		private class Json
		{
			public string access_token { get; set; }
			public int expires_in { get; set; }
			public string refresh_token { get; set; }
			public string id_token { get; set; }
		}
	}
}
