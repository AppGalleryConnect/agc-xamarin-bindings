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
						"com/huawei/agconnect/datastore",
						"com/huawei/agconnect/datastore/core",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_agconnect_datastore_package,
						lookup_com_huawei_agconnect_datastore_core_package,
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

		static string[] package_com_huawei_agconnect_datastore_mappings;
		static Type lookup_com_huawei_agconnect_datastore_package (string klass)
		{
			if (package_com_huawei_agconnect_datastore_mappings == null) {
				package_com_huawei_agconnect_datastore_mappings = new string[]{
					"com/huawei/agconnect/datastore/BuildConfig:Huawei.Agconnect.Datastore.BuildConfig",
				};
			}

			return Lookup (package_com_huawei_agconnect_datastore_mappings, klass);
		}

		static string[] package_com_huawei_agconnect_datastore_core_mappings;
		static Type lookup_com_huawei_agconnect_datastore_core_package (string klass)
		{
			if (package_com_huawei_agconnect_datastore_core_mappings == null) {
				package_com_huawei_agconnect_datastore_core_mappings = new string[]{
					"com/huawei/agconnect/datastore/core/CryptoUtil:Huawei.Agconnect.Datastore.Core.CryptoUtil",
					"com/huawei/agconnect/datastore/core/SharedPrefUtil:Huawei.Agconnect.Datastore.Core.SharedPrefUtil",
				};
			}

			return Lookup (package_com_huawei_agconnect_datastore_core_mappings, klass);
		}
	}
}
