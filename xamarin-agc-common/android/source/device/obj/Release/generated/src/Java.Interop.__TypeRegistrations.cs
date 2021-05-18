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
						"com/huawei/hms/android",
						"com/huawei/hms/common/internal",
						"com/huawei/hms/common",
						"com/huawei/hms/common/util",
						"com/huawei/hms/support/gentyref",
						"com/huawei/hms/support/log/common",
						"com/huawei/hms/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_android_package,
						lookup_com_huawei_hms_common_internal_package,
						lookup_com_huawei_hms_common_package,
						lookup_com_huawei_hms_common_util_package,
						lookup_com_huawei_hms_support_gentyref_package,
						lookup_com_huawei_hms_support_log_common_package,
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

		static string[] package_com_huawei_hms_android_mappings;
		static Type lookup_com_huawei_hms_android_package (string klass)
		{
			if (package_com_huawei_hms_android_mappings == null) {
				package_com_huawei_hms_android_mappings = new string[]{
					"com/huawei/hms/android/HwBuildEx:Huawei.Hms.Android.HwBuildEx",
					"com/huawei/hms/android/HwBuildEx$VERSION:Huawei.Hms.Android.HwBuildEx/VERSION",
					"com/huawei/hms/android/HwBuildEx$VersionCodes:Huawei.Hms.Android.HwBuildEx/VersionCodes",
					"com/huawei/hms/android/SystemUtils:Huawei.Hms.Android.SystemUtils",
				};
			}

			return Lookup (package_com_huawei_hms_android_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_internal_mappings;
		static Type lookup_com_huawei_hms_common_internal_package (string klass)
		{
			if (package_com_huawei_hms_common_internal_mappings == null) {
				package_com_huawei_hms_common_internal_mappings = new string[]{
					"com/huawei/hms/common/internal/Objects:Huawei.Hms.Common.Internal.Objects",
					"com/huawei/hms/common/internal/Objects$ToStringHelper:Huawei.Hms.Common.Internal.Objects/ToStringHelper",
					"com/huawei/hms/common/internal/Preconditions:Huawei.Hms.Common.Internal.Preconditions",
				};
			}

			return Lookup (package_com_huawei_hms_common_internal_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_mappings;
		static Type lookup_com_huawei_hms_common_package (string klass)
		{
			if (package_com_huawei_hms_common_mappings == null) {
				package_com_huawei_hms_common_mappings = new string[]{
					"com/huawei/hms/common/PackageConstants:Huawei.Hms.Common.PackageConstants",
				};
			}

			return Lookup (package_com_huawei_hms_common_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_util_mappings;
		static Type lookup_com_huawei_hms_common_util_package (string klass)
		{
			if (package_com_huawei_hms_common_util_mappings == null) {
				package_com_huawei_hms_common_util_mappings = new string[]{
					"com/huawei/hms/common/util/AGCUtils:Huawei.Hms.Common.Util.AGCUtils",
				};
			}

			return Lookup (package_com_huawei_hms_common_util_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_gentyref_mappings;
		static Type lookup_com_huawei_hms_support_gentyref_package (string klass)
		{
			if (package_com_huawei_hms_support_gentyref_mappings == null) {
				package_com_huawei_hms_support_gentyref_mappings = new string[]{
					"com/huawei/hms/support/gentyref/GenericTypeReflector:Huawei.Hms.Support.Gentyref.GenericTypeReflector",
				};
			}

			return Lookup (package_com_huawei_hms_support_gentyref_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_log_common_mappings;
		static Type lookup_com_huawei_hms_support_log_common_package (string klass)
		{
			if (package_com_huawei_hms_support_log_common_mappings == null) {
				package_com_huawei_hms_support_log_common_mappings = new string[]{
					"com/huawei/hms/support/log/common/Base64:Huawei.Hms.Support.Log.Common.Base64",
				};
			}

			return Lookup (package_com_huawei_hms_support_log_common_mappings, klass);
		}

		static string[] package_com_huawei_hms_utils_mappings;
		static Type lookup_com_huawei_hms_utils_package (string klass)
		{
			if (package_com_huawei_hms_utils_mappings == null) {
				package_com_huawei_hms_utils_mappings = new string[]{
					"com/huawei/hms/utils/Checker:Huawei.Hms.Utils.Checker",
					"com/huawei/hms/utils/FileUtil:Huawei.Hms.Utils.FileUtil",
					"com/huawei/hms/utils/HEX:Huawei.Hms.Utils.HEX",
					"com/huawei/hms/utils/HMSPackageManager:Huawei.Hms.Utils.HMSPackageManager",
					"com/huawei/hms/utils/IOUtils:Huawei.Hms.Utils.IOUtils",
					"com/huawei/hms/utils/NetWorkUtil:Huawei.Hms.Utils.NetWorkUtil",
					"com/huawei/hms/utils/NetWorkUtil$NetType:Huawei.Hms.Utils.NetWorkUtil/NetType",
					"com/huawei/hms/utils/PackageManagerHelper:Huawei.Hms.Utils.PackageManagerHelper",
					"com/huawei/hms/utils/PackageManagerHelper$PackageStates:Huawei.Hms.Utils.PackageManagerHelper/PackageStates",
					"com/huawei/hms/utils/SHA256:Huawei.Hms.Utils.SHA256",
					"com/huawei/hms/utils/StringUtil:Huawei.Hms.Utils.StringUtil",
				};
			}

			return Lookup (package_com_huawei_hms_utils_mappings, klass);
		}
	}
}
