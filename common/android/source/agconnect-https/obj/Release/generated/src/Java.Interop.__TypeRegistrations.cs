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
						"com/huawei/agconnect/https",
						"com/huawei/agconnect/https/adapter",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_agconnect_https_package,
						lookup_com_huawei_agconnect_https_adapter_package,
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

		static string[] package_com_huawei_agconnect_https_mappings;
		static Type lookup_com_huawei_agconnect_https_package (string klass)
		{
			if (package_com_huawei_agconnect_https_mappings == null) {
				package_com_huawei_agconnect_https_mappings = new string[]{
					"com/huawei/agconnect/https/Adapter$Factory:Huawei.Agconnect.Https.AdapterFactory",
					"com/huawei/agconnect/https/HttpsException:Huawei.Agconnect.Https.HttpsException",
					"com/huawei/agconnect/https/HttpsKit:Huawei.Agconnect.Https.HttpsKit",
					"com/huawei/agconnect/https/HttpsKit$Builder:Huawei.Agconnect.Https.HttpsKit/Builder",
					"com/huawei/agconnect/https/HttpsResult:Huawei.Agconnect.Https.HttpsResult",
					"com/huawei/agconnect/https/Method:Huawei.Agconnect.Https.Method",
					"com/huawei/agconnect/https/Method$Get:Huawei.Agconnect.Https.Method/Get",
					"com/huawei/agconnect/https/Method$Post:Huawei.Agconnect.Https.Method/Post",
					"com/huawei/agconnect/https/Method$Put:Huawei.Agconnect.Https.Method/Put",
					"com/huawei/agconnect/https/OKHttpBuilder:Huawei.Agconnect.Https.OKHttpBuilder",
					"com/huawei/agconnect/https/Service$Factory:Huawei.Agconnect.Https.ServiceFactory",
				};
			}

			return Lookup (package_com_huawei_agconnect_https_mappings, klass);
		}

		static string[] package_com_huawei_agconnect_https_adapter_mappings;
		static Type lookup_com_huawei_agconnect_https_adapter_package (string klass)
		{
			if (package_com_huawei_agconnect_https_adapter_mappings == null) {
				package_com_huawei_agconnect_https_adapter_mappings = new string[]{
					"com/huawei/agconnect/https/adapter/JsonAdapterFactory:Huawei.Agconnect.Https.Adapter.JsonAdapterFactory",
					"com/huawei/agconnect/https/adapter/JsonBodyAdapterFactory:Huawei.Agconnect.Https.Adapter.JsonBodyAdapterFactory",
					"com/huawei/agconnect/https/adapter/StringAdapterFactory:Huawei.Agconnect.Https.Adapter.StringAdapterFactory",
				};
			}

			return Lookup (package_com_huawei_agconnect_https_adapter_mappings, klass);
		}
	}
}
