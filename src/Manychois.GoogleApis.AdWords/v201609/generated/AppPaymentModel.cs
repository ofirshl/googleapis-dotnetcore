using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a criterion for targeting paid apps.
	///
	/// <p>Possible IDs: {@code 30} ({@code APP_PAYMENT_MODEL_PAID}).</p>
	/// <p>A criterion of this type can only be created using an ID. A criterion of this type is only targetable.
	/// <span class="constraint AdxEnabled">This is disabled for AdX when it is contained within Operators: ADD, SET.</span>
	/// </summary>
	public class AppPaymentModel : Criterion, ISoapable
	{
		/// <summary>
		/// <span class="constraint Selectable">This field can be selected using the value "AppPaymentModelType".</span>
		/// <span class="constraint ReadOnly">This field is read only and will be ignored when sent to the API.</span>
		/// </summary>
		public AppPaymentModelAppPaymentModelType? AppPaymentModelType { get; set; }
		public override void ReadFrom(XElement xE)
		{
			base.ReadFrom(xE);
			AppPaymentModelType = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "appPaymentModelType")
				{
					AppPaymentModelType = AppPaymentModelAppPaymentModelTypeExtensions.Parse(xItem.Value);
				}
			}
		}
		public override void WriteTo(XElement xE)
		{
			base.WriteTo(xE);
			XmlUtility.SetXsiType(xE, "https://adwords.google.com/api/adwords/cm/v201609", "AppPaymentModel");
			XElement xItem = null;
			if (AppPaymentModelType != null)
			{
				xItem = new XElement(XName.Get("appPaymentModelType", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(AppPaymentModelType.Value.ToXmlValue());
				xE.Add(xItem);
			}
		}
	}
}
