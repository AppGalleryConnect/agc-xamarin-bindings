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
						"com/huawei/hms/aaid/constant",
						"com/huawei/hms/aaid/encrypt",
						"com/huawei/hms/aaid/entity",
						"com/huawei/hms/aaid",
						"com/huawei/hms/aaid/init",
						"com/huawei/hms/aaid/plugin",
						"com/huawei/hms/opendevice",
						"com/huawei/hms/support/api/entity/opendevice",
						"com/huawei/hms/support/api/opendevice",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_aaid_constant_package,
						lookup_com_huawei_hms_aaid_encrypt_package,
						lookup_com_huawei_hms_aaid_entity_package,
						lookup_com_huawei_hms_aaid_package,
						lookup_com_huawei_hms_aaid_init_package,
						lookup_com_huawei_hms_aaid_plugin_package,
						lookup_com_huawei_hms_opendevice_package,
						lookup_com_huawei_hms_support_api_entity_opendevice_package,
						lookup_com_huawei_hms_support_api_opendevice_package,
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

		static string[] package_com_huawei_hms_aaid_constant_mappings;
		static Type lookup_com_huawei_hms_aaid_constant_package (string klass)
		{
			if (package_com_huawei_hms_aaid_constant_mappings == null) {
				package_com_huawei_hms_aaid_constant_mappings = new string[]{
					"com/huawei/hms/aaid/constant/ErrorEnum:Huawei.Hms.Aaid.Constant.ErrorEnum",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_constant_mappings, klass);
		}

		static string[] package_com_huawei_hms_aaid_encrypt_mappings;
		static Type lookup_com_huawei_hms_aaid_encrypt_package (string klass)
		{
			if (package_com_huawei_hms_aaid_encrypt_mappings == null) {
				package_com_huawei_hms_aaid_encrypt_mappings = new string[]{
					"com/huawei/hms/aaid/encrypt/PushEncrypter:Huawei.Hms.Aaid.Encrypt.PushEncrypter",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_encrypt_mappings, klass);
		}

		static string[] package_com_huawei_hms_aaid_entity_mappings;
		static Type lookup_com_huawei_hms_aaid_entity_package (string klass)
		{
			if (package_com_huawei_hms_aaid_entity_mappings == null) {
				package_com_huawei_hms_aaid_entity_mappings = new string[]{
					"com/huawei/hms/aaid/entity/AAIDResult:Huawei.Hms.Aaid.Entity.AAIDResult",
					"com/huawei/hms/aaid/entity/DeleteTokenReq:Huawei.Hms.Aaid.Entity.DeleteTokenReq",
					"com/huawei/hms/aaid/entity/DeleteTokenResp:Huawei.Hms.Aaid.Entity.DeleteTokenResp",
					"com/huawei/hms/aaid/entity/TokenReq:Huawei.Hms.Aaid.Entity.TokenReq",
					"com/huawei/hms/aaid/entity/TokenResp:Huawei.Hms.Aaid.Entity.TokenResp",
					"com/huawei/hms/aaid/entity/TokenResult:Huawei.Hms.Aaid.Entity.TokenResult",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_entity_mappings, klass);
		}

		static string[] package_com_huawei_hms_aaid_mappings;
		static Type lookup_com_huawei_hms_aaid_package (string klass)
		{
			if (package_com_huawei_hms_aaid_mappings == null) {
				package_com_huawei_hms_aaid_mappings = new string[]{
					"com/huawei/hms/aaid/HmsInstanceId:Huawei.Hms.Aaid.HmsInstanceId",
					"com/huawei/hms/aaid/HmsInstanceIdEx:Huawei.Hms.Aaid.HmsInstanceIdEx",
					"com/huawei/hms/aaid/InitProvider:Huawei.Hms.Aaid.InitProvider",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_mappings, klass);
		}

		static string[] package_com_huawei_hms_aaid_init_mappings;
		static Type lookup_com_huawei_hms_aaid_init_package (string klass)
		{
			if (package_com_huawei_hms_aaid_init_mappings == null) {
				package_com_huawei_hms_aaid_init_mappings = new string[]{
					"com/huawei/hms/aaid/init/AutoInitHelper:Huawei.Hms.Aaid.Init.AutoInitHelper",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_init_mappings, klass);
		}

		static string[] package_com_huawei_hms_aaid_plugin_mappings;
		static Type lookup_com_huawei_hms_aaid_plugin_package (string klass)
		{
			if (package_com_huawei_hms_aaid_plugin_mappings == null) {
				package_com_huawei_hms_aaid_plugin_mappings = new string[]{
					"com/huawei/hms/aaid/plugin/ProxyCenter:Huawei.Hms.Aaid.Plugin.ProxyCenter",
				};
			}

			return Lookup (package_com_huawei_hms_aaid_plugin_mappings, klass);
		}

		static string[] package_com_huawei_hms_opendevice_mappings;
		static Type lookup_com_huawei_hms_opendevice_package (string klass)
		{
			if (package_com_huawei_hms_opendevice_mappings == null) {
				package_com_huawei_hms_opendevice_mappings = new string[]{
					"com/huawei/hms/opendevice/OpenDevice:Huawei.Hms.Opendevice.OpenDevice",
					"com/huawei/hms/opendevice/OpenDeviceClientImpl:Huawei.Hms.Opendevice.OpenDeviceClientImpl",
					"com/huawei/hms/opendevice/OpenDeviceHmsClient:Huawei.Hms.Opendevice.OpenDeviceHmsClient",
					"com/huawei/hms/opendevice/OpenDeviceHmsClientBuilder:Huawei.Hms.Opendevice.OpenDeviceHmsClientBuilder",
					"com/huawei/hms/opendevice/OpenDeviceOptions:Huawei.Hms.Opendevice.OpenDeviceOptions",
					"com/huawei/hms/opendevice/OpenDeviceTaskApiCall:Huawei.Hms.Opendevice.OpenDeviceTaskApiCall",
				};
			}

			return Lookup (package_com_huawei_hms_opendevice_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_entity_opendevice_mappings;
		static Type lookup_com_huawei_hms_support_api_entity_opendevice_package (string klass)
		{
			if (package_com_huawei_hms_support_api_entity_opendevice_mappings == null) {
				package_com_huawei_hms_support_api_entity_opendevice_mappings = new string[]{
					"com/huawei/hms/support/api/entity/opendevice/HuaweiOpendeviceStatusCodes:Huawei.Hms.Support.Api.Entity.Opendevice.HuaweiOpendeviceStatusCodes",
					"com/huawei/hms/support/api/entity/opendevice/OaidReq:Huawei.Hms.Support.Api.Entity.Opendevice.OaidReq",
					"com/huawei/hms/support/api/entity/opendevice/OaidResp:Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp",
					"com/huawei/hms/support/api/entity/opendevice/OdidReq:Huawei.Hms.Support.Api.Entity.Opendevice.OdidReq",
					"com/huawei/hms/support/api/entity/opendevice/OdidResp:Huawei.Hms.Support.Api.Entity.Opendevice.OdidResp",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_entity_opendevice_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_opendevice_mappings;
		static Type lookup_com_huawei_hms_support_api_opendevice_package (string klass)
		{
			if (package_com_huawei_hms_support_api_opendevice_mappings == null) {
				package_com_huawei_hms_support_api_opendevice_mappings = new string[]{
					"com/huawei/hms/support/api/opendevice/HuaweiOpendevice:Huawei.Hms.Support.Api.Opendevice.HuaweiOpendevice",
					"com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApiImpl:Huawei.Hms.Support.Api.Opendevice.HuaweiOpendeviceApiImpl",
					"com/huawei/hms/support/api/opendevice/OdidResult:Huawei.Hms.Support.Api.Opendevice.OdidResult",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_opendevice_mappings, klass);
		}
	}
}
