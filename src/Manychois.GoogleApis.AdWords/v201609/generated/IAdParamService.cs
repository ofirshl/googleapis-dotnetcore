using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use this service to manage ad parameters, which let you quickly update
	/// parameterized values (such as prices or inventory levels) in a text ad.
	/// Whereas updates to regular ad text can take hours to go live, updates to
	/// parameterized values go live in minutes.
	///
	/// <p>To define where parameterized values appear in an ad, you insert
	/// <code>{param#:<var>default-value</var>}</code> tags in your ad text. You
	/// can use these tags in any line of display text, and also in the
	/// destination URL. When the text ad is displayed, values in these tags are
	/// replaced by the ad parameter's {@linkplain AdParam#insertionText
	/// insertion text}. <code>default-value</code> specifies the string to display
	/// if one of the following conditions is true:</p>
	/// <ul>
	/// <li>The parameter has not been set.</li>
	/// <li>The parameter's insertion text is too long for the display line.</li>
	/// <li>The ad is being shown on the
	/// {@linkplain NetworkTarget#networkCoverageType Google Display Network}.</li>
	/// </ul>
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public interface IAdParamService
	{
		/// <summary>
		/// Returns the ad parameters that match the criteria specified in the
		/// selector.
		///
		/// @param serviceSelector Specifies which ad parameters to return.
		/// @return A list of ad parameters.
		/// </summary>
		Task<AdParamPage> GetAsync(Selector serviceSelector);
		/// <summary>
		/// Sets and removes ad parameters.
		/// <p class="note"><b>Note:</b> {@code ADD} is not supported. Use {@code SET}
		/// for new ad parameters.</p>
		///
		/// <ul class="nolist">
		/// <li>{@code SET}: Creates or updates an ad parameter, setting the new
		/// parameterized value for the given ad group / keyword pair.
		/// <li>{@code REMOVE}: Removes an ad parameter. The <code><var>default-value</var>
		/// </code> specified in the ad text will be used.</li>
		/// </ul>
		///
		/// @param operations The operations to perform.
		/// @return A list of ad parameters, where each entry in the list is the
		/// result of applying the operation in the input list with the same index.
		/// For a {@code SET} operation, the returned ad parameter will contain the
		/// updated values. For a {@code REMOVE} operation, the returned ad parameter
		/// will simply be the ad parameter that was removed.
		/// </summary>
		Task<IEnumerable<AdParam>> MutateAsync(IEnumerable<AdParamOperation> operations);
	}
}
