﻿using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the status of a job or process, indicating its current state in the workflow.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JobStatusType
    {
        /// <summary>
        /// The job is pending and has not started yet.
        /// </summary>
        [JsonStringEnumMemberName("pending")]
        Pending,

        /// <summary>
        /// The job is currently in progress.
        /// </summary>
        [JsonStringEnumMemberName("in_progress")]
        InProgress,

        /// <summary>
        /// The job has been completed successfully.
        /// </summary>
        [JsonStringEnumMemberName("completed")]
        Completed,

        /// <summary>
        /// The job has failed and was not successfully completed.
        /// </summary>
        [JsonStringEnumMemberName("failed")]
        Failed
    }
}