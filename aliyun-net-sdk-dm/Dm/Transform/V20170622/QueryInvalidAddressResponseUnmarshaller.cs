﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryInvalidAddressResponseUnmarshaller
    {
        public static QueryInvalidAddressResponse Unmarshall(UnmarshallerContext context)
        {
			QueryInvalidAddressResponse queryInvalidAddressResponse = new QueryInvalidAddressResponse();

			queryInvalidAddressResponse.HttpResponse = context.HttpResponse;
			queryInvalidAddressResponse.RequestId = context.StringValue("QueryInvalidAddress.RequestId");
			queryInvalidAddressResponse.NextStart = context.StringValue("QueryInvalidAddress.NextStart");
			queryInvalidAddressResponse.TotalCount = context.IntegerValue("QueryInvalidAddress.TotalCount");

			List<QueryInvalidAddressResponse.QueryInvalidAddress_MailDetail> queryInvalidAddressResponse_data = new List<QueryInvalidAddressResponse.QueryInvalidAddress_MailDetail>();
			for (int i = 0; i < context.Length("QueryInvalidAddress.data.Length"); i++) {
				QueryInvalidAddressResponse.QueryInvalidAddress_MailDetail mailDetail = new QueryInvalidAddressResponse.QueryInvalidAddress_MailDetail();
				mailDetail.LastUpdateTime = context.StringValue("QueryInvalidAddress.data[" + i +"].LastUpdateTime");
				mailDetail.UtcLastUpdateTime = context.LongValue("QueryInvalidAddress.data[" + i +"].UtcLastUpdateTime");
				mailDetail.ToAddress = context.StringValue("QueryInvalidAddress.data[" + i +"].ToAddress");

				queryInvalidAddressResponse_data.Add(mailDetail);
			}
			queryInvalidAddressResponse.Data = queryInvalidAddressResponse_data;
        
			return queryInvalidAddressResponse;
        }
    }
}
