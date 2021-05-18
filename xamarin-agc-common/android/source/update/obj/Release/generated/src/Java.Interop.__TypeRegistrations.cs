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
						"com/huawei/updatesdk/fileprovider",
						"com/huawei/updatesdk/service/otaupdate",
						"com/huawei/updatesdk/support/pm",
						"com/huawei/updatesdk",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_updatesdk_fileprovider_package,
						lookup_com_huawei_updatesdk_service_otaupdate_package,
						lookup_com_huawei_updatesdk_support_pm_package,
						lookup_com_huawei_updatesdk_package,
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

		static string[] package_com_huawei_updatesdk_fileprovider_mappings;
		static Type lookup_com_huawei_updatesdk_fileprovider_package (string klass)
		{
			if (package_com_huawei_updatesdk_fileprovider_mappings == null) {
				package_com_huawei_updatesdk_fileprovider_mappings = new string[]{
					"com/huawei/updatesdk/fileprovider/UpdateSdkFileProvider:Huawei.Updatesdk.Fileprovider.UpdateSdkFileProvider",
				};
			}

			return Lookup (package_com_huawei_updatesdk_fileprovider_mappings, klass);
		}

		static string[] package_com_huawei_updatesdk_service_otaupdate_mappings;
		static Type lookup_com_huawei_updatesdk_service_otaupdate_package (string klass)
		{
			if (package_com_huawei_updatesdk_service_otaupdate_mappings == null) {
				package_com_huawei_updatesdk_service_otaupdate_mappings = new string[]{
					"com/huawei/updatesdk/service/otaupdate/AppUpdateActivity:Huawei.Updatesdk.Service.Otaupdate.AppUpdateActivity",
					"com/huawei/updatesdk/service/otaupdate/UpdateParams:Huawei.Updatesdk.Service.Otaupdate.UpdateParams",
					"com/huawei/updatesdk/service/otaupdate/UpdateParams$Builder:Huawei.Updatesdk.Service.Otaupdate.UpdateParams/Builder",
				};
			}

			return Lookup (package_com_huawei_updatesdk_service_otaupdate_mappings, klass);
		}

		static string[] package_com_huawei_updatesdk_support_pm_mappings;
		static Type lookup_com_huawei_updatesdk_support_pm_package (string klass)
		{
			if (package_com_huawei_updatesdk_support_pm_mappings == null) {
				package_com_huawei_updatesdk_support_pm_mappings = new string[]{
					"com/huawei/updatesdk/support/pm/PackageInstallerActivity:Huawei.Updatesdk.Support.Pm.PackageInstallerActivity",
				};
			}

			return Lookup (package_com_huawei_updatesdk_support_pm_mappings, klass);
		}

		static string[] package_com_huawei_updatesdk_mappings;
		static Type lookup_com_huawei_updatesdk_package (string klass)
		{
			if (package_com_huawei_updatesdk_mappings == null) {
				package_com_huawei_updatesdk_mappings = new string[]{
					"com/huawei/updatesdk/UpdateSdkAPI:Huawei.Updatesdk.UpdateSdkAPI",
				};
			}

			return Lookup (package_com_huawei_updatesdk_mappings, klass);
		}
	}
}
