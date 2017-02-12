using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Approval and policy information attached to an entity.
	/// </summary>
	public class PolicyData : ISoapable
	{
		/// <summary>
		/// List of disapproval reasons attached to the entity.
		/// </summary>
		public List<DisapprovalReason> DisapprovalReasons { get; set; }
		/// <summary>
		/// Indicates that this instance is a subtype of PolicyData.
		/// Although this field is returned in the response, it is ignored on input
		/// and cannot be selected. Specify xsi:type instead.
		/// </summary>
		public string PolicyDataType { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			DisapprovalReasons = null;
			PolicyDataType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "disapprovalReasons")
				{
					if (DisapprovalReasons == null) DisapprovalReasons = new List<DisapprovalReason>();
					var disapprovalReasonsItem = new DisapprovalReason();
					disapprovalReasonsItem.ReadFrom(xItem);
					DisapprovalReasons.Add(disapprovalReasonsItem);
				}
				else if (localName == "PolicyData.Type")
				{
					PolicyDataType = xItem.Value;
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (DisapprovalReasons != null)
			{
				foreach (var disapprovalReasonsItem in DisapprovalReasons)
				{
					xItem = new XElement(XName.Get("disapprovalReasons", "https://adwords.google.com/api/adwords/cm/v201609"));
					disapprovalReasonsItem.WriteTo(xItem);
					xE.Add(xItem);
				}
			}
			if (PolicyDataType != null)
			{
				xItem = new XElement(XName.Get("PolicyData.Type", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(PolicyDataType);
				xE.Add(xItem);
			}
		}
	}
}
