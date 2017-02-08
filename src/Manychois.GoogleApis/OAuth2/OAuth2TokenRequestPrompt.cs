using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.OAuth2
{
	public enum OAuth2TokenRequestPrompt
	{
		/// <summary>
		/// Do not display any authentication or consent screens. Must not be specified with other values.
		/// </summary>
		None,
		/// <summary>
		/// Prompt the user for consent.
		/// </summary>
		Consent,
		/// <summary>
		/// Prompt the user to select an account.
		/// </summary>
		SelectAccount
	}
}
