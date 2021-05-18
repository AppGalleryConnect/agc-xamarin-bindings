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
						"com/huawei/hms/adapter",
						"com/huawei/hms/adapter/internal",
						"com/huawei/hms/adapter/sysobs",
						"com/huawei/hms/adapter/ui",
						"com/huawei/hms/base/availableupdate",
						"com/huawei/hms/update/kpms",
						"com/huawei/hms/update/manager",
						"com/huawei/hms/update/provider",
						"com/huawei/hms/update/ui",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_adapter_package,
						lookup_com_huawei_hms_adapter_internal_package,
						lookup_com_huawei_hms_adapter_sysobs_package,
						lookup_com_huawei_hms_adapter_ui_package,
						lookup_com_huawei_hms_base_availableupdate_package,
						lookup_com_huawei_hms_update_kpms_package,
						lookup_com_huawei_hms_update_manager_package,
						lookup_com_huawei_hms_update_provider_package,
						lookup_com_huawei_hms_update_ui_package,
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

		static string[] package_com_huawei_hms_adapter_mappings;
		static Type lookup_com_huawei_hms_adapter_package (string klass)
		{
			if (package_com_huawei_hms_adapter_mappings == null) {
				package_com_huawei_hms_adapter_mappings = new string[]{
					"com/huawei/hms/adapter/AvailableAdapter:Huawei.Hms.Adapter.AvailableAdapter",
				};
			}

			return Lookup (package_com_huawei_hms_adapter_mappings, klass);
		}

		static string[] package_com_huawei_hms_adapter_internal_mappings;
		static Type lookup_com_huawei_hms_adapter_internal_package (string klass)
		{
			if (package_com_huawei_hms_adapter_internal_mappings == null) {
				package_com_huawei_hms_adapter_internal_mappings = new string[]{
					"com/huawei/hms/adapter/internal/CommonCode:Huawei.Hms.Adapter.Internal.CommonCode",
				};
			}

			return Lookup (package_com_huawei_hms_adapter_internal_mappings, klass);
		}

		static string[] package_com_huawei_hms_adapter_sysobs_mappings;
		static Type lookup_com_huawei_hms_adapter_sysobs_package (string klass)
		{
			if (package_com_huawei_hms_adapter_sysobs_mappings == null) {
				package_com_huawei_hms_adapter_sysobs_mappings = new string[]{
					"com/huawei/hms/adapter/sysobs/SystemManager:Huawei.Hms.Adapter.Sysobs.SystemManager",
				};
			}

			return Lookup (package_com_huawei_hms_adapter_sysobs_mappings, klass);
		}

		static string[] package_com_huawei_hms_adapter_ui_mappings;
		static Type lookup_com_huawei_hms_adapter_ui_package (string klass)
		{
			if (package_com_huawei_hms_adapter_ui_mappings == null) {
				package_com_huawei_hms_adapter_ui_mappings = new string[]{
					"com/huawei/hms/adapter/ui/BaseResolutionAdapter:Huawei.Hms.Adapter.Ui.BaseResolutionAdapter",
					"com/huawei/hms/adapter/ui/UpdateAdapter:Huawei.Hms.Adapter.Ui.UpdateAdapter",
				};
			}

			return Lookup (package_com_huawei_hms_adapter_ui_mappings, klass);
		}

		static string[] package_com_huawei_hms_base_availableupdate_mappings;
		static Type lookup_com_huawei_hms_base_availableupdate_package (string klass)
		{
			if (package_com_huawei_hms_base_availableupdate_mappings == null) {
				package_com_huawei_hms_base_availableupdate_mappings = new string[]{
					"com/huawei/hms/base/availableupdate/BuildConfig:Huawei.Hms.Base.Availableupdate.BuildConfig",
				};
			}

			return Lookup (package_com_huawei_hms_base_availableupdate_mappings, klass);
		}

		static string[] package_com_huawei_hms_update_kpms_mappings;
		static Type lookup_com_huawei_hms_update_kpms_package (string klass)
		{
			if (package_com_huawei_hms_update_kpms_mappings == null) {
				package_com_huawei_hms_update_kpms_mappings = new string[]{
					"com/huawei/hms/update/kpms/KpmsConstant:Huawei.Hms.Update.Kpms.KpmsConstant",
				};
			}

			return Lookup (package_com_huawei_hms_update_kpms_mappings, klass);
		}

		static string[] package_com_huawei_hms_update_manager_mappings;
		static Type lookup_com_huawei_hms_update_manager_package (string klass)
		{
			if (package_com_huawei_hms_update_manager_mappings == null) {
				package_com_huawei_hms_update_manager_mappings = new string[]{
					"com/huawei/hms/update/manager/HMSPublishStateHolder:Huawei.Hms.Update.Manager.HMSPublishStateHolder",
					"com/huawei/hms/update/manager/PackageNameManager:Huawei.Hms.Update.Manager.PackageNameManager",
					"com/huawei/hms/update/manager/UpdateManager:Huawei.Hms.Update.Manager.UpdateManager",
				};
			}

			return Lookup (package_com_huawei_hms_update_manager_mappings, klass);
		}

		static string[] package_com_huawei_hms_update_provider_mappings;
		static Type lookup_com_huawei_hms_update_provider_package (string klass)
		{
			if (package_com_huawei_hms_update_provider_mappings == null) {
				package_com_huawei_hms_update_provider_mappings = new string[]{
					"com/huawei/hms/update/provider/UpdateProvider:Huawei.Hms.Update.Provider.UpdateProvider",
				};
			}

			return Lookup (package_com_huawei_hms_update_provider_mappings, klass);
		}

		static string[] package_com_huawei_hms_update_ui_mappings;
		static Type lookup_com_huawei_hms_update_ui_package (string klass)
		{
			if (package_com_huawei_hms_update_ui_mappings == null) {
				package_com_huawei_hms_update_ui_mappings = new string[]{
					"com/huawei/hms/update/ui/UpdateBean:Huawei.Hms.Update.Ui.UpdateBean",
				};
			}

			return Lookup (package_com_huawei_hms_update_ui_mappings, klass);
		}
	}
}
