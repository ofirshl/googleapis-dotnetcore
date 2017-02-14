﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// TrialService manages the life cycle of campaign trials. It is used to create new trials from
	/// drafts, modify trial properties, promote changes in a trial back to its base campaign, and to
	/// archive a trial.
	///
	/// <p>A trial is an experiment, running two variants (trial arms) - the base campaign and the trial
	/// - at the same time, directing a fixed share of traffic to each trial arm. A trial is created from
	/// a draft of the base campaign and will be a snapshot of changes in the draft at the time of
	/// creation.
	///
	/// <h3>Constraints</h3>
	///
	/// <ul>
	/// <li>A campaign cannot have running/scheduled "AdWords Campaign Experiments" (ACE) and
	/// running/scheduled trials at the same time. Trial creation will fail, if the base campaign
	/// has a running/scheduled ACE experiment.</li>
	/// <li>Trial names must be unique across all of the customer's non-deleted trial and campaign
	/// names.</li>
	/// <li>When creating a trial, [startDate, endDate] cannot be in the past or overlap with any other
	/// running/scheduled trial, must be within the base campaign's [startDate, endDate] and
	/// endDate must be later than startDate.</li>
	/// <li>A future startDate/endDate can be updated to a different future startDate/endDate as long
	/// as the constraints on [startDate, endDate] are not violated.</li>
	/// <li>There is at most one trial running and at most one trial scheduled for the future at a
	/// time, per base campaign.</li>
	/// <li>The base campaign's budget cannot be shared with any other campaign. Trial creation will
	/// fail if the base campaign's budget is shared with another campaign.</li>
	/// </ul>
	///
	/// <h3>Life cycle</h3>
	///
	/// A trial's {@link Trial#status status} reflects the state of the trial within its life cycle. Some
	/// status transitions are performed explicitly by sending a {@link Operator#SET SET} operation,
	/// while other status transitions occur asynchronously without a client operation.
	///
	/// <p>When a trial is first {@link Operator#ADD ADD}ed, its status is
	/// {@link TrialStatus#CREATING CREATING}. The trial will be created asynchronously, and once it
	/// is fully created, its status will change to {@link TrialStatus#ACTIVE ACTIVE}.
	///
	/// <p>If the asynchronous creation of the trial fails, its status will change to
	/// {@link TrialStatus#CREATION_FAILED CREATION_FAILED}.
	///
	/// <p>To promote changes in an {@link TrialStatus#ACTIVE ACTIVE} trial back to the base campaign,
	/// set the trial status to {@link TrialStatus#PROMOTING PROMOTING}. The promotion itself will occur
	/// asynchronously. If the promotion operation fails after some of the base campaign has already been
	/// updated, the status will change to {@link TrialStatus#PROMOTE_FAILED PROMOTE_FAILED}.
	///
	/// <p>To graduate an {@link TrialStatus#ACTIVE ACTIVE} trial, which will allow its associated
	/// campaign to act independently of the trial and free it of restrictions from the trial, set the
	/// status to {@link TrialStatus#GRADUATED GRADUATED} and provide a new
	/// {@link Budget#budgetid budgetId} for the campaign to use (since it can no longer share the base
	/// campaign's budget).
	///
	/// <p>Any trial that is not {@link TrialStatus#CREATING CREATING} or
	/// {@link TrialStatus#PROMOTING PROMOTING} can be archived by setting the status to the value of the
	/// same name.
	/// </summary>
	public interface ITrialService
	{
		/// <summary>
		/// Loads a TrialPage containing a list of {@link Trial} objects matching the selector.
		///
		/// @param selector defines which subset of all available trials to return, the sort order, and
		/// which fields to include
		///
		/// @return Returns a page of matching trial objects.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// retrieving the results.
		/// </summary>
		Task<TrialPage> GetAsync(Selector selector);
		/// <summary>
		/// Creates new trials, updates properties and controls the life cycle of existing trials.
		/// See {@link TrialService} for details on the trial life cycle.
		///
		/// @return Returns the list of updated Trials, in the same order as the {@code operations} list.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// processing the request.
		/// </summary>
		Task<TrialReturnValue> MutateAsync(IEnumerable<TrialOperation> operations);
		/// <summary>
		/// Loads a TrialPage containing a list of {@link Trial} objects matching the query.
		///
		/// @param query defines which subset of all available trials to return, the sort order, and
		/// which fields to include
		///
		/// @return Returns a page of matching trial objects.
		/// @throws com.google.ads.api.services.common.error.ApiException if errors occurred while
		/// retrieving the results.
		/// </summary>
		Task<TrialPage> QueryAsync(string query);
	}
}
