using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/huawei/hmf/tasks",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hmf_tasks_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_huawei_hmf_tasks_mappings;
		static Type lookup_com_huawei_hmf_tasks_package (string klass)
		{
			if (package_com_huawei_hmf_tasks_mappings == null) {
				package_com_huawei_hmf_tasks_mappings = new string[]{
					"com/huawei/hmf/tasks/BuildConfig:Huawei.Hmf.Tasks.BuildConfig",
					"com/huawei/hmf/tasks/CancellationToken:Huawei.Hmf.Tasks.CancellationToken",
					"com/huawei/hmf/tasks/CancellationTokenSource:Huawei.Hmf.Tasks.CancellationTokenSource",
					"com/huawei/hmf/tasks/Task:Huawei.Hmf.Tasks.Task",
					"com/huawei/hmf/tasks/TaskCompletionSource:Huawei.Hmf.Tasks.TaskCompletionSource",
					"com/huawei/hmf/tasks/TaskExecutors:Huawei.Hmf.Tasks.TaskExecutors",
					"com/huawei/hmf/tasks/Tasks:Huawei.Hmf.Tasks.Tasks",
				};
			}

			return Lookup (package_com_huawei_hmf_tasks_mappings, klass);
		}
	}
}
