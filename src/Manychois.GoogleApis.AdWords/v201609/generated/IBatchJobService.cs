using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// Use the {@code BatchJobService} to schedule large batches of updates to
	/// your AdWords campaigns as asynchronous mutate jobs, and to retrieve the
	/// status, results or statistics of your recent jobs.
	///
	/// <p>Use this service when you wish to release your application from actively
	/// waiting on a synchronous response. Your application can do other things or
	/// even shutdown while we execute mutations asynchronously.
	///
	/// <p>Once a job has been submitted, you may check its status periodically, by
	/// calling {@link #get}.
	///
	/// <p class="caution"><b>Caution:</b> Do not poll the job status too frequently
	/// or you will risk getting your customer rate-limited.
	///
	/// <p>Once a job's status changes to {@code DONE}, you can retrieve the job's
	/// results.
	/// </summary>
	public interface IBatchJobService
	{
		/// <summary>
		/// Query the status of existing {@code BatchJob}s.
		///
		/// @param selector The selector specifying the {@code BatchJob}s to return.
		/// @return The list of selected jobs.
		/// @throws ApiException
		/// </summary>
		Task<BatchJobPage> GetAsync(Selector selector);
		/// <summary>
		/// Creates or updates a {@code BatchJob}.
		///
		/// <p class="note"><b>Note:</b> {@link BatchJobOperation} does not support the
		/// {@code REMOVE} operator. It is not necessary to remove BatchJobs.
		///
		/// @param operations A list of operations.
		/// @return The list of created or updated jobs.
		/// @throws ApiException
		/// </summary>
		Task<BatchJobReturnValue> MutateAsync(IEnumerable<BatchJobOperation> operations);
		/// <summary>
		/// Returns the list of {@code BatchJob}s that match the query.
		///
		/// @param query The SQL-like AWQL query string.
		/// @return The list of selected jobs.
		/// @throws ApiException if problems occur while parsing the query or fetching
		/// batchjob information.
		/// </summary>
		Task<BatchJobPage> QueryAsync(string query);
	}
}
