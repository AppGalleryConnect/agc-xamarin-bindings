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
						"com/huawei/hms/framework/common",
						"com/huawei/hms/framework/common/hianalytics",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_framework_common_package,
						lookup_com_huawei_hms_framework_common_hianalytics_package,
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

		static string[] package_com_huawei_hms_framework_common_mappings;
		static Type lookup_com_huawei_hms_framework_common_package (string klass)
		{
			if (package_com_huawei_hms_framework_common_mappings == null) {
				package_com_huawei_hms_framework_common_mappings = new string[]{
					"com/huawei/hms/framework/common/BuildConfig:Huawei.Hms.Framework.Common.BuildConfig",
					"com/huawei/hms/framework/common/CheckParamUtils:Huawei.Hms.Framework.Common.CheckParamUtils",
					"com/huawei/hms/framework/common/ContainerUtils:Huawei.Hms.Framework.Common.ContainerUtils",
					"com/huawei/hms/framework/common/ExceptionCode:Huawei.Hms.Framework.Common.ExceptionCode",
					"com/huawei/hms/framework/common/ExecutorsEnhance:Huawei.Hms.Framework.Common.ExecutorsEnhance",
					"com/huawei/hms/framework/common/ExecutorsUtils:Huawei.Hms.Framework.Common.ExecutorsUtils",
					"com/huawei/hms/framework/common/ExtLogger:Huawei.Hms.Framework.Common.ExtLogger",
					"com/huawei/hms/framework/common/IoUtils:Huawei.Hms.Framework.Common.IoUtils",
					"com/huawei/hms/framework/common/LimitQueue:Huawei.Hms.Framework.Common.LimitQueue",
					"com/huawei/hms/framework/common/Logger:Huawei.Hms.Framework.Common.Logger",
					"com/huawei/hms/framework/common/PackageUtils:Huawei.Hms.Framework.Common.PackageUtils",
					"com/huawei/hms/framework/common/PLSharedPreferences:Huawei.Hms.Framework.Common.PLSharedPreferences",
					"com/huawei/hms/framework/common/ReflectionUtils:Huawei.Hms.Framework.Common.ReflectionUtils",
					"com/huawei/hms/framework/common/RunnableEnhance:Huawei.Hms.Framework.Common.RunnableEnhance",
					"com/huawei/hms/framework/common/RunnableScheduledFutureEnhance:Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance",
					"com/huawei/hms/framework/common/ScheduledThreadPoolExecutorEnhance:Huawei.Hms.Framework.Common.ScheduledThreadPoolExecutorEnhance",
					"com/huawei/hms/framework/common/SecurityBase64Utils:Huawei.Hms.Framework.Common.SecurityBase64Utils",
					"com/huawei/hms/framework/common/StringUtils:Huawei.Hms.Framework.Common.StringUtils",
					"com/huawei/hms/framework/common/SystemPropUtils:Huawei.Hms.Framework.Common.SystemPropUtils",
					"com/huawei/hms/framework/common/ThreadPoolExcutorEnhance:Huawei.Hms.Framework.Common.ThreadPoolExcutorEnhance",
					"com/huawei/hms/framework/common/Utils:Huawei.Hms.Framework.Common.Utils",
				};
			}

			return Lookup (package_com_huawei_hms_framework_common_mappings, klass);
		}

		static string[] package_com_huawei_hms_framework_common_hianalytics_mappings;
		static Type lookup_com_huawei_hms_framework_common_hianalytics_package (string klass)
		{
			if (package_com_huawei_hms_framework_common_hianalytics_mappings == null) {
				package_com_huawei_hms_framework_common_hianalytics_mappings = new string[]{
					"com/huawei/hms/framework/common/hianalytics/CrashHianalyticsData:Huawei.Hms.Framework.Common.Hianalytics.CrashHianalyticsData",
					"com/huawei/hms/framework/common/hianalytics/HianalyticsBaseData:Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData",
					"com/huawei/hms/framework/common/hianalytics/HianalyticsHelper:Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper",
					"com/huawei/hms/framework/common/hianalytics/LinkedHashMapPack:Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack",
				};
			}

			return Lookup (package_com_huawei_hms_framework_common_hianalytics_mappings, klass);
		}
	}
}
