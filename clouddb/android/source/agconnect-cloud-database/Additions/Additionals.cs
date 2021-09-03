/*      Copyright 2021. Huawei Technologies Co., Ltd. All rights reserved.

        Licensed under the Apache License, Version 2.0 (the "License");
        you may not use this file except in compliance with the License.
        You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

        Unless required by applicable law or agreed to in writing, software
        distributed under the License is distributed on an "AS IS" BASIS,
        WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
        See the License for the specific language governing permissions and
        limitations under the License.
*/
using Android.Runtime;
using System;
using System.Threading.Tasks;
using HuaweiTask = Huawei.Hmf.Tasks.Task;

namespace Huawei.Agconnect.Cloud.Database
{
    public partial class AGConnectCloudDB
    {

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<CloudDBZone> OpenCloudDBZone2Async(CloudDBZoneConfig config, bool isAllowToCreate) =>
            await OpenCloudDBZone2(config, isAllowToCreate).CastTask<CloudDBZone>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<bool> SetUserKeyAsync(string userKey, string userReKey) =>
            (bool)await SetUserKey(userKey, userReKey).CastTask<Java.Lang.Boolean>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<bool> UpdateDataEncryptionKeyAsync() =>
            (bool)await UpdateDataEncryptionKey().CastTask<Java.Lang.Boolean>();

    }

    public partial class CloudDBZone
    {

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<int> ExecuteUpsertAsync(CloudDBZoneObject cloudDBZoneObject) =>
            (int)await ExecuteUpsert(cloudDBZoneObject).CastTask<Java.Lang.Integer>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<int> ExecuteUpsertAsync(System.Collections.Generic.IList<Huawei.Agconnect.Cloud.Database.CloudDBZoneObject> objectList) =>
            (int)await ExecuteUpsert(objectList).CastTask<Java.Lang.Integer>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<int> ExecuteDeleteAsync(CloudDBZoneObject cloudDBZoneObject) =>
            (int)await ExecuteDelete(cloudDBZoneObject).CastTask<Java.Lang.Integer>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<int> ExecuteDeleteAsync(System.Collections.Generic.IList<Huawei.Agconnect.Cloud.Database.CloudDBZoneObject> objectList) =>
            (int)await ExecuteDelete(objectList).CastTask<Java.Lang.Integer>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<Java.Lang.Number> ExecuteSumQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, string fieldName, Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            await ExecuteSumQuery(cloudDBZoneQuery, fieldName, queryPolicy).CastTask<Java.Lang.Number>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<Java.Lang.Number> ExecuteMaximumQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, string fieldName, Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            await ExecuteMaximumQuery(cloudDBZoneQuery, fieldName, queryPolicy).CastTask<Java.Lang.Number>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<Java.Lang.Number> ExecuteMinimalQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, string fieldName, Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            await ExecuteMinimalQuery(cloudDBZoneQuery, fieldName, queryPolicy).CastTask<Java.Lang.Number>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<long> ExecuteCountQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, string fieldName, Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            (long)await ExecuteCountQuery(cloudDBZoneQuery, fieldName, queryPolicy).CastTask<Java.Lang.Long>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<CloudDBZoneSnapshot> ExecuteQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, global::Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            await ExecuteQuery(cloudDBZoneQuery, queryPolicy).CastTask<CloudDBZoneSnapshot>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<CloudDBZoneSnapshot> ExecuteQueryUnsyncedAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery) =>
            await ExecuteQueryUnsynced(cloudDBZoneQuery).CastTask<CloudDBZoneSnapshot>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<double> ExecuteAverageQueryAsync(Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery cloudDBZoneQuery, string fieldName,global::Huawei.Agconnect.Cloud.Database.CloudDBZoneQuery.CloudDBZoneQueryPolicy queryPolicy) =>
            (double)await ExecuteAverageQuery(cloudDBZoneQuery, fieldName, queryPolicy).CastTask<Java.Lang.Double>();

        //async Task<NAME> MyMethod(params) => await MyNativeMethod(params).CastTask<NAME>();
        public async Task<bool> RunTransactionAsync(Huawei.Agconnect.Cloud.Database.Transaction.IFunction function) =>
            (bool)await RunTransaction(function).CastTask<Java.Lang.Boolean>();

    }
}

namespace Huawei.Agconnect.Cloud
{
    #region Task Extensions
    /// <summary>
    /// Task Extension Class for convert HuaweiTask to System.Threading.Task
    /// </summary>
    internal static class HuaweiTaskExtensions
    {
        /// <summary>
        /// Convert HuaweiTask to System.Threading.Task without return type
        /// </summary>
        /// <param name="HuaweiTask">Huawei.Hmf.Tasks.Task</param>
        /// <returns>System.Threading.Task</returns>
        public static Task CastTask(this HuaweiTask HuaweiTask)
        {
            var tcs = new TaskCompletionSource<bool>();

            HuaweiTask.AddOnCompleteListener(new HuaweiTaskCompleteListener(
                t =>
                {
                    if (t.Exception == null)
                        tcs.TrySetResult(false);
                    else
                        tcs.TrySetException(t.Exception);
                }
            ));

            return tcs.Task;
        }


        /// <summary>
        /// Convert HuaweiTask to System.Threading.Task with Generic return type
        /// </summary>
        /// <typeparam name="TResult">Return type,a Java object</typeparam>
        /// <param name="HuaweiTask">Huawei.Hmf.Tasks.Task class</param>
        /// <returns>System.Threading.Task with wrapped a generic type</returns>
        public static Task<TResult> CastTask<TResult>(this HuaweiTask HuaweiTask) where TResult : Java.Lang.Object
        {
            var tcs = new TaskCompletionSource<TResult>();

            HuaweiTask.AddOnCompleteListener(new HuaweiTaskCompleteListener(
                t =>
                {
                    if (t.Exception == null)
                        tcs.TrySetResult(t.Result.JavaCast<TResult>());
                    else
                        tcs.TrySetException(t.Exception);
                }));

            return tcs.Task;
        }


        /// <summary>
        /// Modified OnCompleteListener (from Huawei.Hmf.Tasks.Task)
        /// Invoke the given action
        /// </summary>
        class HuaweiTaskCompleteListener : Java.Lang.Object, Huawei.Hmf.Tasks.IOnCompleteListener
        {
            public HuaweiTaskCompleteListener(Action<HuaweiTask> onComplete)
                => OnCompleteHandler = onComplete;

            public Action<HuaweiTask> OnCompleteHandler { get; }

            public void OnComplete(HuaweiTask task)
                => OnCompleteHandler?.Invoke(task);
        }
    }
    #endregion
}

