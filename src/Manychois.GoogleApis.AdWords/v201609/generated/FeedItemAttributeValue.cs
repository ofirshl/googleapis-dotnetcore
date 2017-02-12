using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Represents a feed item's value for a particular feed attribute. A feed item's value is
	/// composed of a collection of these attribute values.
	/// </summary>
	public class FeedItemAttributeValue : ISoapable
	{
		/// <summary>
		/// Feed attribute id
		/// </summary>
		public long? FeedAttributeId { get; set; }
		/// <summary>
		/// Integer value. Should be set if feedAttributeId refers to a feed attribute of type INT64. Leave
		/// empty to clear an existing INT64 attribute value.
		/// </summary>
		public long? IntegerValue { get; set; }
		/// <summary>
		/// Double value. Should be set if feedAttributeId refers to a feed attribute of type FLOAT. Leave
		/// empty to clear an existing FLOAT attribute value.
		/// </summary>
		public double? DoubleValue { get; set; }
		/// <summary>
		/// Boolean value. Should be set if feedAttributeId refers to a feed attribute of type BOOLEAN.
		/// Leave empty to clear an existing BOOLEAN attribute value.
		/// </summary>
		public bool? BooleanValue { get; set; }
		/// <summary>
		/// String value. Should be set if feedAttributeId refers to a feed attribute of type STRING,
		/// URL, or DATE_TIME.
		/// The format of DATE_TIME is 'YYYYMMDD hhmmss' (e.g., 20130101 163031 to represent
		/// Jan 1, 2013 4:30:31pm). All date times are interpreted in the account's time zone.
		/// A time zone id may be appended to the date time, but it must match the account's time zone.
		/// For example '20130101 163031 America/Los_Angeles' may be specified in the above example as long
		/// as the account's time zone is America/Los_Angeles.
		/// Leave empty to clear an existing STRING, URL, or DATE_TIME attribute value.
		/// </summary>
		public string StringValue { get; set; }
		/// <summary>
		/// List of integer values. Should be set if feedAttributeId refers to a feed attribute of type
		/// INT64_LIST. Leave empty to clear an existing INT64_LIST attribute value.
		/// </summary>
		public List<long> IntegerValues { get; set; }
		/// <summary>
		/// List of double values. Should be set if feedAttributeId refers to a feed attribute of type
		/// FLOAT_LIST. Leave empty to clear an existing FLOAT_LIST attribute value.
		/// </summary>
		public List<double> DoubleValues { get; set; }
		/// <summary>
		/// List of boolean values. Should be set if feedAttributeId refers to a feed attribute of type
		/// BOOLEAN_LIST. Leave empty to clear an existing BOOLEAN_LIST attribute value.
		/// </summary>
		public List<bool> BooleanValues { get; set; }
		/// <summary>
		/// List of string values. Should be set if feedAttributeId refers to a feed attribute of type
		/// STRING_LIST, URL_LIST, or DATE_TIME_LIST. All strings in this list must be of the same type
		/// and format. For example, if the type is DATE_TIME_LIST, all strings in the list must be
		/// DATE_TIME formatted strings. See {@link #stringValue} for specific formatting requirements.
		/// </summary>
		public List<string> StringValues { get; set; }
		/// <summary>
		/// MoneyWithCurrency value. Should be set if feedAttributeId refers to a feed attribute of type
		/// PRICE. Leave empty to clear an existing PRICE attribute value.
		/// </summary>
		public MoneyWithCurrency MoneyWithCurrencyValue { get; set; }
		public virtual void ReadFrom(XElement xE)
		{
			FeedAttributeId = null;
			IntegerValue = null;
			DoubleValue = null;
			BooleanValue = null;
			StringValue = null;
			IntegerValues = null;
			DoubleValues = null;
			BooleanValues = null;
			StringValues = null;
			MoneyWithCurrencyValue = null;
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
				if (localName == "feedAttributeId")
				{
					FeedAttributeId = long.Parse(xItem.Value);
				}
				else if (localName == "integerValue")
				{
					IntegerValue = long.Parse(xItem.Value);
				}
				else if (localName == "doubleValue")
				{
					DoubleValue = double.Parse(xItem.Value);
				}
				else if (localName == "booleanValue")
				{
					BooleanValue = bool.Parse(xItem.Value);
				}
				else if (localName == "stringValue")
				{
					StringValue = xItem.Value;
				}
				else if (localName == "integerValues")
				{
					if (IntegerValues == null) IntegerValues = new List<long>();
					IntegerValues.Add(long.Parse(xItem.Value));
				}
				else if (localName == "doubleValues")
				{
					if (DoubleValues == null) DoubleValues = new List<double>();
					DoubleValues.Add(double.Parse(xItem.Value));
				}
				else if (localName == "booleanValues")
				{
					if (BooleanValues == null) BooleanValues = new List<bool>();
					BooleanValues.Add(bool.Parse(xItem.Value));
				}
				else if (localName == "stringValues")
				{
					if (StringValues == null) StringValues = new List<string>();
					StringValues.Add(xItem.Value);
				}
				else if (localName == "moneyWithCurrencyValue")
				{
					MoneyWithCurrencyValue = new MoneyWithCurrency();
					MoneyWithCurrencyValue.ReadFrom(xItem);
				}
			}
		}
		public virtual void WriteTo(XElement xE)
		{
			XElement xItem = null;
			if (FeedAttributeId != null)
			{
				xItem = new XElement(XName.Get("feedAttributeId", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(FeedAttributeId.Value.ToString());
				xE.Add(xItem);
			}
			if (IntegerValue != null)
			{
				xItem = new XElement(XName.Get("integerValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(IntegerValue.Value.ToString());
				xE.Add(xItem);
			}
			if (DoubleValue != null)
			{
				xItem = new XElement(XName.Get("doubleValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(DoubleValue.Value.ToString());
				xE.Add(xItem);
			}
			if (BooleanValue != null)
			{
				xItem = new XElement(XName.Get("booleanValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(BooleanValue.Value.ToString());
				xE.Add(xItem);
			}
			if (StringValue != null)
			{
				xItem = new XElement(XName.Get("stringValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				xItem.Add(StringValue);
				xE.Add(xItem);
			}
			if (IntegerValues != null)
			{
				foreach (var integerValuesItem in IntegerValues)
				{
					xItem = new XElement(XName.Get("integerValues", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(integerValuesItem.ToString());
					xE.Add(xItem);
				}
			}
			if (DoubleValues != null)
			{
				foreach (var doubleValuesItem in DoubleValues)
				{
					xItem = new XElement(XName.Get("doubleValues", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(doubleValuesItem.ToString());
					xE.Add(xItem);
				}
			}
			if (BooleanValues != null)
			{
				foreach (var booleanValuesItem in BooleanValues)
				{
					xItem = new XElement(XName.Get("booleanValues", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(booleanValuesItem.ToString());
					xE.Add(xItem);
				}
			}
			if (StringValues != null)
			{
				foreach (var stringValuesItem in StringValues)
				{
					xItem = new XElement(XName.Get("stringValues", "https://adwords.google.com/api/adwords/cm/v201609"));
					xItem.Add(stringValuesItem);
					xE.Add(xItem);
				}
			}
			if (MoneyWithCurrencyValue != null)
			{
				xItem = new XElement(XName.Get("moneyWithCurrencyValue", "https://adwords.google.com/api/adwords/cm/v201609"));
				MoneyWithCurrencyValue.WriteTo(xItem);
				xE.Add(xItem);
			}
		}
	}
}
