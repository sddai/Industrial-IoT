// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Agent.Framework {
    using Microsoft.Azure.IIoT.Agent.Framework.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Job repository events
    /// </summary>
    public interface IJobEventHandler {

        /// <summary>
        /// Job creating
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        Task OnJobCreatingAsync(JobInfoModel job);

        /// <summary>
        /// Job deleting
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        Task OnJobDeletingAsync(JobInfoModel job);

        /// <summary>
        /// Job created
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        Task OnJobCreatedAsync(JobInfoModel job);

        /// <summary>
        /// Job deleted
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        Task OnJobDeletedAsync(JobInfoModel job);

        /// <summary>
        /// Assign a job to an edge device scope
        /// </summary>
        /// <param name="job"></param>
        /// <param name="deviceScope"></param>
        /// <returns></returns>
        Task OnJobAssignmentAsync(JobInfoModel job, string deviceScope);
    }
}