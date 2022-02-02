/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

using System.Runtime.Serialization;

namespace Osc
{
	[DataContract]
	public class ShardStats
	{
		[DataMember(Name ="commit")]
		public ShardCommit Commit { get; internal set; }

		[DataMember(Name ="completion")]
		public ShardCompletion Completion { get; internal set; }

		[DataMember(Name ="docs")]
		public ShardDocs Documents { get; internal set; }

		[DataMember(Name ="fielddata")]
		public ShardFielddata Fielddata { get; internal set; }

		[DataMember(Name ="flush")]
		public ShardFlush Flush { get; internal set; }

		[DataMember(Name ="get")]
		public ShardGet Get { get; internal set; }

		[DataMember(Name ="indexing")]
		public ShardIndexing Indexing { get; internal set; }

		[DataMember(Name ="merges")]
		public ShardMerges Merges { get; internal set; }

		[DataMember(Name ="shard_path")]
		public ShardPath Path { get; internal set; }

		[DataMember(Name ="query_cache")]
		public ShardQueryCache QueryCache { get; internal set; }

		[DataMember(Name ="recovery")]
		public ShardStatsRecovery Recovery { get; internal set; }

		[DataMember(Name ="refresh")]
		public ShardRefresh Refresh { get; internal set; }

		[DataMember(Name ="request_cache")]
		public ShardRequestCache RequestCache { get; internal set; }

		[DataMember(Name ="routing")]
		public ShardRouting Routing { get; internal set; }

		[DataMember(Name ="search")]
		public ShardSearch Search { get; internal set; }

		[DataMember(Name ="segments")]
		public ShardSegments Segments { get; internal set; }

		[DataMember(Name ="seq_no")]
		public ShardSequenceNumber SequenceNumber { get; internal set; }

		[DataMember(Name ="store")]
		public ShardStatsStore Store { get; internal set; }

		[DataMember(Name ="translog")]
		public ShardTransactionLog TransactionLog { get; internal set; }

		[DataMember(Name ="warmer")]
		public ShardWarmer Warmer { get; internal set; }
	}
}