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
						"com/huawei/hms/framework/network/grs",
						"com/huawei/hms/framework/network/grs/local/model",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_framework_network_grs_package,
						lookup_com_huawei_hms_framework_network_grs_local_model_package,
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

		static string[] package_com_huawei_hms_framework_network_grs_mappings;
		static Type lookup_com_huawei_hms_framework_network_grs_package (string klass)
		{
			if (package_com_huawei_hms_framework_network_grs_mappings == null) {
				package_com_huawei_hms_framework_network_grs_mappings = new string[]{
					"com/huawei/hms/framework/network/grs/GrsApi:Huawei.Hms.Framework.Network.Grs.GrsApi",
					"com/huawei/hms/framework/network/grs/GrsApp:Huawei.Hms.Framework.Network.Grs.GrsApp",
					"com/huawei/hms/framework/network/grs/GrsBaseInfo:Huawei.Hms.Framework.Network.Grs.GrsBaseInfo",
					"com/huawei/hms/framework/network/grs/GrsClient:Huawei.Hms.Framework.Network.Grs.GrsClient",
					"com/huawei/hms/framework/network/grs/GrsConfig:Huawei.Hms.Framework.Network.Grs.GrsConfig",
				};
			}

			return Lookup (package_com_huawei_hms_framework_network_grs_mappings, klass);
		}

		static string[] package_com_huawei_hms_framework_network_grs_local_model_mappings;
		static Type lookup_com_huawei_hms_framework_network_grs_local_model_package (string klass)
		{
			if (package_com_huawei_hms_framework_network_grs_local_model_mappings == null) {
				package_com_huawei_hms_framework_network_grs_local_model_mappings = new string[]{
					"com/huawei/hms/framework/network/grs/local/model/CountryCodeBean:Huawei.Hms.Framework.Network.Grs.Local.Model.CountryCodeBean",
				};
			}

			return Lookup (package_com_huawei_hms_framework_network_grs_local_model_mappings, klass);
		}
	}
}
