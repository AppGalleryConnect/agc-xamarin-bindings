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
						"com/huawei/hms/support/log",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_support_log_package,
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

		static string[] package_com_huawei_hms_support_log_mappings;
		static Type lookup_com_huawei_hms_support_log_package (string klass)
		{
			if (package_com_huawei_hms_support_log_mappings == null) {
				package_com_huawei_hms_support_log_mappings = new string[]{
					"com/huawei/hms/support/log/HMSDebugger:Huawei.Hms.Support.Log.HMSDebugger",
					"com/huawei/hms/support/log/HMSLog:Huawei.Hms.Support.Log.HMSLog",
				};
			}

			return Lookup (package_com_huawei_hms_support_log_mappings, klass);
		}
	}
}
