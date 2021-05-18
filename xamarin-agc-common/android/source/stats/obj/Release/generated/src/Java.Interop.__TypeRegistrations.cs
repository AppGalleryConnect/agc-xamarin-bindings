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
						"com/huawei/hms/support/hianalytics",
						"com/huawei/hms/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_support_hianalytics_package,
						lookup_com_huawei_hms_utils_package,
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

		static string[] package_com_huawei_hms_support_hianalytics_mappings;
		static Type lookup_com_huawei_hms_support_hianalytics_package (string klass)
		{
			if (package_com_huawei_hms_support_hianalytics_mappings == null) {
				package_com_huawei_hms_support_hianalytics_mappings = new string[]{
					"com/huawei/hms/support/hianalytics/HiAnalyticsConstant:Huawei.Hms.Support.Hianalytics.HiAnalyticsConstant",
					"com/huawei/hms/support/hianalytics/HiAnalyticsUtils:Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils",
				};
			}

			return Lookup (package_com_huawei_hms_support_hianalytics_mappings, klass);
		}

		static string[] package_com_huawei_hms_utils_mappings;
		static Type lookup_com_huawei_hms_utils_package (string klass)
		{
			if (package_com_huawei_hms_utils_mappings == null) {
				package_com_huawei_hms_utils_mappings = new string[]{
					"com/huawei/hms/utils/HMSBIInitializer:Huawei.Hms.Utils.HMSBIInitializer",
				};
			}

			return Lookup (package_com_huawei_hms_utils_mappings, klass);
		}
	}
}
