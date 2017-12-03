// -----------------------------------------------------------------------
// <copyright file="ActivityBase.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Common.Models.Activities
{
    using System;

    public class ActivityBase : Core
    {
        public long? Id { get; set; }
        public ActivityType Type { get; set; }
        public bool? IsCampaignResponse { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Contacts.Contact Owner { get; set; }
        public ActivityPriority Priority { get; set; }
        public DateTime? Due { get; set; }
        public bool? State { get; set; }
        public ActivityStatusReason StatusReason { get; set; }
        public int? Duration { get; set; }
        //public int? Order { get; set; }
    }
}
