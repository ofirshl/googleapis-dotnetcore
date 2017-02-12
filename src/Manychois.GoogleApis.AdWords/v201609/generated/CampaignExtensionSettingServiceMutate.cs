using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Applies the list of mutate operations (add, remove, and set).
	///
	/// <p> Beginning in v201509, add and set operations are treated identically. Performing an add
	/// operation on a campaign with an existing ExtensionSetting will cause the operation to be
	/// treated like a set operation. Performing a set operation on a campaign with no
	/// ExtensionSetting will cause the operation to be treated like an add operation.
	///
	/// @param operations The operations to apply. The same {@link CampaignExtensionSetting} cannot be
	/// specified in more than one operation.
	/// @return The changed {@link CampaignExtensionSetting}s.
	/// @throws ApiException Indicates a problem with the request.
	/// </summary>
	internal class CampaignExtensionSettingServiceMutate : ISoapable
	{
		/// <summary>
		/// <span class="constraint ContentsNotNull">This field must not contain {@code null} elements.</span>
		/// <span class="constraint DistinctIds">Elements in this field must have distinct IDs for following {@link Operator}s : ADD, SET, REMOVE.</span>
		/// <span class="constraint NotEmpty">This field must contain at least one element.</span>
		/// <span class="constraint Required">This field is required and should not be {@code null}.</span>
		/// </summary>
		public List<CampaignExtensionSettingOperation> Operations { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			Operations = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "operations")
				{
					if (Operations == null) Operations = new List<CampaignExtensionSettingOperation>();
					var operationsItem = new CampaignExtensionSettingOperation();
					operationsItem.ReadFrom(xItem);
					Operations.Add(operationsItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (Operations != null)
			{
				foreach (var operationsItem in Operations)
				{
					xItem = new XElement(XName.Get("operations", "https://adwords.google.com/api/adwords/cm/v201609"));
					operationsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
		}
	}
}
