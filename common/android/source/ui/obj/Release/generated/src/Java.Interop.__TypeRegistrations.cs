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
						"com/huawei/hms/activity",
						"com/huawei/hms/support/common",
						"com/huawei/hms/ui",
						"com/huawei/hms/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_activity_package,
						lookup_com_huawei_hms_support_common_package,
						lookup_com_huawei_hms_ui_package,
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

		static string[] package_com_huawei_hms_activity_mappings;
		static Type lookup_com_huawei_hms_activity_package (string klass)
		{
			if (package_com_huawei_hms_activity_mappings == null) {
				package_com_huawei_hms_activity_mappings = new string[]{
					"com/huawei/hms/activity/BridgeActivity:Huawei.Hms.Activity.BridgeActivity",
					"com/huawei/hms/activity/EnableServiceActivity:Huawei.Hms.Activity.EnableServiceActivity",
				};
			}

			return Lookup (package_com_huawei_hms_activity_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_common_mappings;
		static Type lookup_com_huawei_hms_support_common_package (string klass)
		{
			if (package_com_huawei_hms_support_common_mappings == null) {
				package_com_huawei_hms_support_common_mappings = new string[]{
					"com/huawei/hms/support/common/ActivityMgr:Huawei.Hms.Support.Common.ActivityMgr",
				};
			}

			return Lookup (package_com_huawei_hms_support_common_mappings, klass);
		}

		static string[] package_com_huawei_hms_ui_mappings;
		static Type lookup_com_huawei_hms_ui_package (string klass)
		{
			if (package_com_huawei_hms_ui_mappings == null) {
				package_com_huawei_hms_ui_mappings = new string[]{
					"com/huawei/hms/ui/AbstractDialog:Huawei.Hms.Uı.AbstractDialog",
					"com/huawei/hms/ui/AbstractPromptDialog:Huawei.Hms.Uı.AbstractPromptDialog",
					"com/huawei/hms/ui/SafeBundle:Huawei.Hms.Uı.SafeBundle",
					"com/huawei/hms/ui/SafeIntent:Huawei.Hms.Uı.SafeIntent",
				};
			}

			return Lookup (package_com_huawei_hms_ui_mappings, klass);
		}

		static string[] package_com_huawei_hms_utils_mappings;
		static Type lookup_com_huawei_hms_utils_package (string klass)
		{
			if (package_com_huawei_hms_utils_mappings == null) {
				package_com_huawei_hms_utils_mappings = new string[]{
					"com/huawei/hms/utils/ResourceLoaderUtil:Huawei.Hms.Utils.ResourceLoaderUtil",
					"com/huawei/hms/utils/UIUtil:Huawei.Hms.Utils.UIUtil",
				};
			}

			return Lookup (package_com_huawei_hms_utils_mappings, klass);
		}
	}
}
