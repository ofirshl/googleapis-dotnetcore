﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Returns a list of all gender criteria.
	///
	/// @return A list of genders.
	/// @throws ApiException when there is at least one error with the request.
	/// </summary>
	internal class ConstantDataServiceGetGenderCriterion : ISoapable
	{
		public virtual void ReadFrom(XElement xE)
		{
			foreach (var xItem in xE.Elements())
			{
				var localName = xItem.Name.LocalName;
			}
		}
		public virtual void WriteTo(XElement xE)
		{
		}
	}
}
