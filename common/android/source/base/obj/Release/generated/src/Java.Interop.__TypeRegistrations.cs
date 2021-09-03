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
						"com/huawei/hms/actions",
						"com/huawei/hms/activity",
						"com/huawei/hms/activity/internal",
						"com/huawei/hms/adapter",
						"com/huawei/hms/api",
						"com/huawei/hms/common",
						"com/huawei/hms/common/api",
						"com/huawei/hms/common/api/internal",
						"com/huawei/hms/common/data",
						"com/huawei/hms/common/internal",
						"com/huawei/hms/common/internal/safeparcel",
						"com/huawei/hms/common/size",
						"com/huawei/hms/common/sqlite",
						"com/huawei/hms/common/util",
						"com/huawei/hms/common/webserverpic",
						"com/huawei/hms/core/aidl",
						"com/huawei/hms/security",
						"com/huawei/hms/support/api/client",
						"com/huawei/hms/support/api/core",
						"com/huawei/hms/support/api/entity/auth",
						"com/huawei/hms/support/api/entity/core",
						"com/huawei/hms/support/api",
						"com/huawei/hms/support/hianalytics",
						"com/huawei/hms/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_huawei_hms_actions_package,
						lookup_com_huawei_hms_activity_package,
						lookup_com_huawei_hms_activity_internal_package,
						lookup_com_huawei_hms_adapter_package,
						lookup_com_huawei_hms_api_package,
						lookup_com_huawei_hms_common_package,
						lookup_com_huawei_hms_common_api_package,
						lookup_com_huawei_hms_common_api_internal_package,
						lookup_com_huawei_hms_common_data_package,
						lookup_com_huawei_hms_common_internal_package,
						lookup_com_huawei_hms_common_internal_safeparcel_package,
						lookup_com_huawei_hms_common_size_package,
						lookup_com_huawei_hms_common_sqlite_package,
						lookup_com_huawei_hms_common_util_package,
						lookup_com_huawei_hms_common_webserverpic_package,
						lookup_com_huawei_hms_core_aidl_package,
						lookup_com_huawei_hms_security_package,
						lookup_com_huawei_hms_support_api_client_package,
						lookup_com_huawei_hms_support_api_core_package,
						lookup_com_huawei_hms_support_api_entity_auth_package,
						lookup_com_huawei_hms_support_api_entity_core_package,
						lookup_com_huawei_hms_support_api_package,
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

		static string[] package_com_huawei_hms_actions_mappings;
		static Type lookup_com_huawei_hms_actions_package (string klass)
		{
			if (package_com_huawei_hms_actions_mappings == null) {
				package_com_huawei_hms_actions_mappings = new string[]{
					"com/huawei/hms/actions/SearchIntents:Huawei.Hms.Actions.SearchIntents",
				};
			}

			return Lookup (package_com_huawei_hms_actions_mappings, klass);
		}

		static string[] package_com_huawei_hms_activity_mappings;
		static Type lookup_com_huawei_hms_activity_package (string klass)
		{
			if (package_com_huawei_hms_activity_mappings == null) {
				package_com_huawei_hms_activity_mappings = new string[]{
					"com/huawei/hms/activity/ForegroundBusDelegate:Huawei.Hms.Activity.ForegroundBusDelegate",
					"com/huawei/hms/activity/ForegroundIntentBuilder:Huawei.Hms.Activity.ForegroundIntentBuilder",
				};
			}

			return Lookup (package_com_huawei_hms_activity_mappings, klass);
		}

		static string[] package_com_huawei_hms_activity_internal_mappings;
		static Type lookup_com_huawei_hms_activity_internal_package (string klass)
		{
			if (package_com_huawei_hms_activity_internal_mappings == null) {
				package_com_huawei_hms_activity_internal_mappings = new string[]{
					"com/huawei/hms/activity/internal/BusResponseResult:Huawei.Hms.Activity.Internal.BusResponseResult",
					"com/huawei/hms/activity/internal/ForegroundBusResponseMgr:Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr",
					"com/huawei/hms/activity/internal/ForegroundInnerHeader:Huawei.Hms.Activity.Internal.ForegroundInnerHeader",
				};
			}

			return Lookup (package_com_huawei_hms_activity_internal_mappings, klass);
		}

		static string[] package_com_huawei_hms_adapter_mappings;
		static Type lookup_com_huawei_hms_adapter_package (string klass)
		{
			if (package_com_huawei_hms_adapter_mappings == null) {
				package_com_huawei_hms_adapter_mappings = new string[]{
					"com/huawei/hms/adapter/BaseAdapter:Huawei.Hms.Adapter.BaseAdapter",
					"com/huawei/hms/adapter/BaseAdapter$BaseRequestResultCallback:Huawei.Hms.Adapter.BaseAdapter/BaseRequestResultCallback",
					"com/huawei/hms/adapter/BinderAdapter:Huawei.Hms.Adapter.BinderAdapter",
					"com/huawei/hms/adapter/CoreBaseResponse:Huawei.Hms.Adapter.CoreBaseResponse",
				};
			}

			return Lookup (package_com_huawei_hms_adapter_mappings, klass);
		}

		static string[] package_com_huawei_hms_api_mappings;
		static Type lookup_com_huawei_hms_api_package (string klass)
		{
			if (package_com_huawei_hms_api_mappings == null) {
				package_com_huawei_hms_api_mappings = new string[]{
					"com/huawei/hms/api/Api:Huawei.Hms.Api.Api",
					"com/huawei/hms/api/Api$ApiOptions$NoOptions:Huawei.Hms.Api.Api/ApiOptionsNoOptions",
					"com/huawei/hms/api/Api$Options:Huawei.Hms.Api.Api/Options",
					"com/huawei/hms/api/BindingFailedResolution:Huawei.Hms.Api.BindingFailedResolution",
					"com/huawei/hms/api/ConnectionResult:Huawei.Hms.Api.ConnectionResult",
					"com/huawei/hms/api/HuaweiApiAvailability:Huawei.Hms.Api.HuaweiApiAvailability",
					"com/huawei/hms/api/HuaweiApiClient:Huawei.Hms.Api.HuaweiApiClient",
					"com/huawei/hms/api/HuaweiApiClient$Builder:Huawei.Hms.Api.HuaweiApiClient/Builder",
					"com/huawei/hms/api/HuaweiApiClientImpl:Huawei.Hms.Api.HuaweiApiClientImpl",
					"com/huawei/hms/api/HuaweiMobileServicesUtil:Huawei.Hms.Api.HuaweiMobileServicesUtil",
					"com/huawei/hms/api/HuaweiServicesNotAvailableException:Huawei.Hms.Api.HuaweiServicesNotAvailableException",
					"com/huawei/hms/api/HuaweiServicesRepairableException:Huawei.Hms.Api.HuaweiServicesRepairableException",
					"com/huawei/hms/api/IPCTransport:Huawei.Hms.Api.IPCTransport",
					"com/huawei/hms/api/ProtocolNegotiate:Huawei.Hms.Api.ProtocolNegotiate",
					"com/huawei/hms/api/ResolutionDelegate:Huawei.Hms.Api.ResolutionDelegate",
					"com/huawei/hms/api/UserRecoverableException:Huawei.Hms.Api.UserRecoverableException",
				};
			}

			return Lookup (package_com_huawei_hms_api_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_mappings;
		static Type lookup_com_huawei_hms_common_package (string klass)
		{
			if (package_com_huawei_hms_common_mappings == null) {
				package_com_huawei_hms_common_mappings = new string[]{
					"com/huawei/hms/common/AccountPicker:Huawei.Hms.Common.AccountPicker",
					"com/huawei/hms/common/ApiException:Huawei.Hms.Common.ApiException",
					"com/huawei/hms/common/ErrDlgFragmentForSupport:Huawei.Hms.Common.ErrDlgFragmentForSupport",
					"com/huawei/hms/common/ErrorDialogFragment:Huawei.Hms.Common.ErrorDialogFragment",
					"com/huawei/hms/common/Feature:Huawei.Hms.Common.Feature",
					"com/huawei/hms/common/FeatureCreator:Huawei.Hms.Common.FeatureCreator",
					"com/huawei/hms/common/HuaweiApi:Huawei.Hms.Common.HuaweiApi",
					"com/huawei/hms/common/ResolvableApiException:Huawei.Hms.Common.ResolvableApiException",
				};
			}

			return Lookup (package_com_huawei_hms_common_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_api_mappings;
		static Type lookup_com_huawei_hms_common_api_package (string klass)
		{
			if (package_com_huawei_hms_common_api_mappings == null) {
				package_com_huawei_hms_common_api_mappings = new string[]{
					"com/huawei/hms/common/api/AvailabilityException:Huawei.Hms.Common.Api.AvailabilityException",
					"com/huawei/hms/common/api/BooleanResult:Huawei.Hms.Common.Api.BooleanResult",
					"com/huawei/hms/common/api/CommonStatusCodes:Huawei.Hms.Common.Api.CommonStatusCodes",
					"com/huawei/hms/common/api/OptionalPendingResult:Huawei.Hms.Common.Api.OptionalPendingResult",
					"com/huawei/hms/common/api/Response:Huawei.Hms.Common.Api.Response",
					"com/huawei/hms/common/api/UnsupportedApiCallException:Huawei.Hms.Common.Api.UnsupportedApiCallException",
				};
			}

			return Lookup (package_com_huawei_hms_common_api_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_api_internal_mappings;
		static Type lookup_com_huawei_hms_common_api_internal_package (string klass)
		{
			if (package_com_huawei_hms_common_api_internal_mappings == null) {
				package_com_huawei_hms_common_api_internal_mappings = new string[]{
					"com/huawei/hms/common/api/internal/OptionalPendingResultImpl:Huawei.Hms.Common.Api.Internal.OptionalPendingResultImpl",
				};
			}

			return Lookup (package_com_huawei_hms_common_api_internal_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_data_mappings;
		static Type lookup_com_huawei_hms_common_data_package (string klass)
		{
			if (package_com_huawei_hms_common_data_mappings == null) {
				package_com_huawei_hms_common_data_mappings = new string[]{
					"com/huawei/hms/common/data/AbstractDataBuffer:Huawei.Hms.Common.Data.AbstractDataBuffer",
					"com/huawei/hms/common/data/DataBufferRef:Huawei.Hms.Common.Data.DataBufferRef",
					"com/huawei/hms/common/data/DataBufferUtils:Huawei.Hms.Common.Data.DataBufferUtils",
					"com/huawei/hms/common/data/DataHolder:Huawei.Hms.Common.Data.DataHolder",
					"com/huawei/hms/common/data/DataHolder$Builder:Huawei.Hms.Common.Data.DataHolder/Builder",
					"com/huawei/hms/common/data/DataHolder$DataHolderException:Huawei.Hms.Common.Data.DataHolder/DataHolderException",
					"com/huawei/hms/common/data/DataHolderCreator:Huawei.Hms.Common.Data.DataHolderCreator",
					"com/huawei/hms/common/data/DBInnerIter:Huawei.Hms.Common.Data.DBInnerIter",
					"com/huawei/hms/common/data/FreezableUtils:Huawei.Hms.Common.Data.FreezableUtils",
					"com/huawei/hms/common/data/SingleRefDBInnerIter:Huawei.Hms.Common.Data.SingleRefDBInnerIter",
				};
			}

			return Lookup (package_com_huawei_hms_common_data_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_internal_mappings;
		static Type lookup_com_huawei_hms_common_internal_package (string klass)
		{
			if (package_com_huawei_hms_common_internal_mappings == null) {
				package_com_huawei_hms_common_internal_mappings = new string[]{
					"com/huawei/hms/common/internal/AbstractClientBuilder:Huawei.Hms.Common.Internal.AbstractClientBuilder",
					"com/huawei/hms/common/internal/Asserter:Huawei.Hms.Common.Internal.Asserter",
					"com/huawei/hms/common/internal/AutoLifecycleFragment:Huawei.Hms.Common.Internal.AutoLifecycleFragment",
					"com/huawei/hms/common/internal/BaseHmsClient:Huawei.Hms.Common.Internal.BaseHmsClient",
					"com/huawei/hms/common/internal/BindResolveClients:Huawei.Hms.Common.Internal.BindResolveClients",
					"com/huawei/hms/common/internal/ClientSettings:Huawei.Hms.Common.Internal.ClientSettings",
					"com/huawei/hms/common/internal/ConnectionErrorMessages:Huawei.Hms.Common.Internal.ConnectionErrorMessages",
					"com/huawei/hms/common/internal/ConnectionManagerKey:Huawei.Hms.Common.Internal.ConnectionManagerKey",
					"com/huawei/hms/common/internal/DialogRedirect:Huawei.Hms.Common.Internal.DialogRedirect",
					"com/huawei/hms/common/internal/DialogRedirectImpl:Huawei.Hms.Common.Internal.DialogRedirectImpl",
					"com/huawei/hms/common/internal/HmsClient:Huawei.Hms.Common.Internal.HmsClient",
					"com/huawei/hms/common/internal/HuaweiApiManager:Huawei.Hms.Common.Internal.HuaweiApiManager",
					"com/huawei/hms/common/internal/HuaweiApiManager$ConnectionManager:Huawei.Hms.Common.Internal.HuaweiApiManager/ConnectionManager",
					"com/huawei/hms/common/internal/RequestHeader:Huawei.Hms.Common.Internal.RequestHeader",
					"com/huawei/hms/common/internal/ResolveClientBean:Huawei.Hms.Common.Internal.ResolveClientBean",
					"com/huawei/hms/common/internal/ResponseHeader:Huawei.Hms.Common.Internal.ResponseHeader",
					"com/huawei/hms/common/internal/ResponseWrap:Huawei.Hms.Common.Internal.ResponseWrap",
					"com/huawei/hms/common/internal/TaskApiCall:Huawei.Hms.Common.Internal.TaskApiCall",
					"com/huawei/hms/common/internal/TaskApiCallWrapper:Huawei.Hms.Common.Internal.TaskApiCallWrapper",
					"com/huawei/hms/common/internal/TransactionIdCreater:Huawei.Hms.Common.Internal.TransactionIdCreater",
				};
			}

			return Lookup (package_com_huawei_hms_common_internal_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_internal_safeparcel_mappings;
		static Type lookup_com_huawei_hms_common_internal_safeparcel_package (string klass)
		{
			if (package_com_huawei_hms_common_internal_safeparcel_mappings == null) {
				package_com_huawei_hms_common_internal_safeparcel_mappings = new string[]{
					"com/huawei/hms/common/internal/safeparcel/AbstractSafeParcelable:Huawei.Hms.Common.Internal.Safeparcel.AbstractSafeParcelable",
					"com/huawei/hms/common/internal/safeparcel/SafeParcelableSerializer:Huawei.Hms.Common.Internal.Safeparcel.SafeParcelableSerializer",
					"com/huawei/hms/common/internal/safeparcel/SafeParcelReader:Huawei.Hms.Common.Internal.Safeparcel.SafeParcelReader",
					"com/huawei/hms/common/internal/safeparcel/SafeParcelReader$ParseException:Huawei.Hms.Common.Internal.Safeparcel.SafeParcelReader/ParseException",
					"com/huawei/hms/common/internal/safeparcel/SafeParcelWriter:Huawei.Hms.Common.Internal.Safeparcel.SafeParcelWriter",
				};
			}

			return Lookup (package_com_huawei_hms_common_internal_safeparcel_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_size_mappings;
		static Type lookup_com_huawei_hms_common_size_package (string klass)
		{
			if (package_com_huawei_hms_common_size_mappings == null) {
				package_com_huawei_hms_common_size_mappings = new string[]{
					"com/huawei/hms/common/size/Size:Huawei.Hms.Common.Size.Size",
				};
			}

			return Lookup (package_com_huawei_hms_common_size_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_sqlite_mappings;
		static Type lookup_com_huawei_hms_common_sqlite_package (string klass)
		{
			if (package_com_huawei_hms_common_sqlite_mappings == null) {
				package_com_huawei_hms_common_sqlite_mappings = new string[]{
					"com/huawei/hms/common/sqlite/HMSCursorWrapper:Huawei.Hms.Common.Sqlite.HMSCursorWrapper",
				};
			}

			return Lookup (package_com_huawei_hms_common_sqlite_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_util_mappings;
		static Type lookup_com_huawei_hms_common_util_package (string klass)
		{
			if (package_com_huawei_hms_common_util_mappings == null) {
				package_com_huawei_hms_common_util_mappings = new string[]{
					"com/huawei/hms/common/util/Base64Utils:Huawei.Hms.Common.Util.Base64Utils",
				};
			}

			return Lookup (package_com_huawei_hms_common_util_mappings, klass);
		}

		static string[] package_com_huawei_hms_common_webserverpic_mappings;
		static Type lookup_com_huawei_hms_common_webserverpic_package (string klass)
		{
			if (package_com_huawei_hms_common_webserverpic_mappings == null) {
				package_com_huawei_hms_common_webserverpic_mappings = new string[]{
					"com/huawei/hms/common/webserverpic/WebServerPic:Huawei.Hms.Common.Webserverpic.WebServerPic",
					"com/huawei/hms/common/webserverpic/WebServerPicCreator:Huawei.Hms.Common.Webserverpic.WebServerPicCreator",
				};
			}

			return Lookup (package_com_huawei_hms_common_webserverpic_mappings, klass);
		}

		static string[] package_com_huawei_hms_core_aidl_mappings;
		static Type lookup_com_huawei_hms_core_aidl_package (string klass)
		{
			if (package_com_huawei_hms_core_aidl_mappings == null) {
				package_com_huawei_hms_core_aidl_mappings = new string[]{
					"com/huawei/hms/core/aidl/AbstractMessageEntity:Huawei.Hms.Core.Aidl.AbstractMessageEntity",
					"com/huawei/hms/core/aidl/RequestHeader:Huawei.Hms.Core.Aidl.RequestHeader",
					"com/huawei/hms/core/aidl/ResponseHeader:Huawei.Hms.Core.Aidl.ResponseHeader",
				};
			}

			return Lookup (package_com_huawei_hms_core_aidl_mappings, klass);
		}

		static string[] package_com_huawei_hms_security_mappings;
		static Type lookup_com_huawei_hms_security_package (string klass)
		{
			if (package_com_huawei_hms_security_mappings == null) {
				package_com_huawei_hms_security_mappings = new string[]{
					"com/huawei/hms/security/SecComponentInstallWizard:Huawei.Hms.Security.SecComponentInstallWizard",
				};
			}

			return Lookup (package_com_huawei_hms_security_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_client_mappings;
		static Type lookup_com_huawei_hms_support_api_client_package (string klass)
		{
			if (package_com_huawei_hms_support_api_client_mappings == null) {
				package_com_huawei_hms_support_api_client_mappings = new string[]{
					"com/huawei/hms/support/api/client/BundleResult:Huawei.Hms.Support.Api.Client.BundleResult",
					"com/huawei/hms/support/api/client/ConvertedResult:Huawei.Hms.Support.Api.Client.ConvertedResult",
					"com/huawei/hms/support/api/client/EmptyPendingResult:Huawei.Hms.Support.Api.Client.EmptyPendingResult",
					"com/huawei/hms/support/api/client/InnerPendingResult:Huawei.Hms.Support.Api.Client.InnerPendingResult",
					"com/huawei/hms/support/api/client/PendingResult:Huawei.Hms.Support.Api.Client.PendingResult",
					"com/huawei/hms/support/api/client/PendingResultsCreator:Huawei.Hms.Support.Api.Client.PendingResultsCreator",
					"com/huawei/hms/support/api/client/PendingResultsCreator$DiscardedPendingResult:Huawei.Hms.Support.Api.Client.PendingResultsCreator/DiscardedPendingResult",
					"com/huawei/hms/support/api/client/PendingResultsCreator$InstantPendingResult:Huawei.Hms.Support.Api.Client.PendingResultsCreator/InstantPendingResult",
					"com/huawei/hms/support/api/client/ResolvingResultCallbacks:Huawei.Hms.Support.Api.Client.ResolvingResultCallbacks",
					"com/huawei/hms/support/api/client/Result:Huawei.Hms.Support.Api.Client.Result",
					"com/huawei/hms/support/api/client/ResultCallbacks:Huawei.Hms.Support.Api.Client.ResultCallbacks",
					"com/huawei/hms/support/api/client/ResultConvert:Huawei.Hms.Support.Api.Client.ResultConvert",
					"com/huawei/hms/support/api/client/ResultConvert$FailPendingResult:Huawei.Hms.Support.Api.Client.ResultConvert/FailPendingResult",
					"com/huawei/hms/support/api/client/Status:Huawei.Hms.Support.Api.Client.Status",
					"com/huawei/hms/support/api/client/SubAppInfo:Huawei.Hms.Support.Api.Client.SubAppInfo",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_client_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_core_mappings;
		static Type lookup_com_huawei_hms_support_api_core_package (string klass)
		{
			if (package_com_huawei_hms_support_api_core_mappings == null) {
				package_com_huawei_hms_support_api_core_mappings = new string[]{
					"com/huawei/hms/support/api/core/ConnectService:Huawei.Hms.Support.Api.Core.ConnectService",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_core_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_entity_auth_mappings;
		static Type lookup_com_huawei_hms_support_api_entity_auth_package (string klass)
		{
			if (package_com_huawei_hms_support_api_entity_auth_mappings == null) {
				package_com_huawei_hms_support_api_entity_auth_mappings = new string[]{
					"com/huawei/hms/support/api/entity/auth/AbstractResp:Huawei.Hms.Support.Api.Entity.Auth.AbstractResp",
					"com/huawei/hms/support/api/entity/auth/PermissionInfo:Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo",
					"com/huawei/hms/support/api/entity/auth/Scope:Huawei.Hms.Support.Api.Entity.Auth.Scope",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_entity_auth_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_entity_core_mappings;
		static Type lookup_com_huawei_hms_support_api_entity_core_package (string klass)
		{
			if (package_com_huawei_hms_support_api_entity_core_mappings == null) {
				package_com_huawei_hms_support_api_entity_core_mappings = new string[]{
					"com/huawei/hms/support/api/entity/core/CheckConnectInfo:Huawei.Hms.Support.Api.Entity.Core.CheckConnectInfo",
					"com/huawei/hms/support/api/entity/core/CheckConnectResp:Huawei.Hms.Support.Api.Entity.Core.CheckConnectResp",
					"com/huawei/hms/support/api/entity/core/ConnectInfo:Huawei.Hms.Support.Api.Entity.Core.ConnectInfo",
					"com/huawei/hms/support/api/entity/core/ConnectResp:Huawei.Hms.Support.Api.Entity.Core.ConnectResp",
					"com/huawei/hms/support/api/entity/core/DisconnectInfo:Huawei.Hms.Support.Api.Entity.Core.DisconnectInfo",
					"com/huawei/hms/support/api/entity/core/DisconnectResp:Huawei.Hms.Support.Api.Entity.Core.DisconnectResp",
					"com/huawei/hms/support/api/entity/core/JosBaseReq:Huawei.Hms.Support.Api.Entity.Core.JosBaseReq",
					"com/huawei/hms/support/api/entity/core/JosBaseResp:Huawei.Hms.Support.Api.Entity.Core.JosBaseResp",
					"com/huawei/hms/support/api/entity/core/JosGetNoticeReq:Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeReq",
					"com/huawei/hms/support/api/entity/core/JosGetNoticeResp:Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeResp",
					"com/huawei/hms/support/api/entity/core/JosNoticeResult:Huawei.Hms.Support.Api.Entity.Core.JosNoticeResult",
					"com/huawei/hms/support/api/entity/core/JosStatusCodes:Huawei.Hms.Support.Api.Entity.Core.JosStatusCodes",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_entity_core_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_api_mappings;
		static Type lookup_com_huawei_hms_support_api_package (string klass)
		{
			if (package_com_huawei_hms_support_api_mappings == null) {
				package_com_huawei_hms_support_api_mappings = new string[]{
					"com/huawei/hms/support/api/ErrorResultImpl:Huawei.Hms.Support.Api.ErrorResultImpl",
					"com/huawei/hms/support/api/PendingResultImpl:Huawei.Hms.Support.Api.PendingResultImpl",
					"com/huawei/hms/support/api/PendingResultImpl$CallbackHandler:Huawei.Hms.Support.Api.PendingResultImpl/CallbackHandler",
					"com/huawei/hms/support/api/ResolvePendingResult:Huawei.Hms.Support.Api.ResolvePendingResult",
					"com/huawei/hms/support/api/ResolveResult:Huawei.Hms.Support.Api.ResolveResult",
				};
			}

			return Lookup (package_com_huawei_hms_support_api_mappings, klass);
		}

		static string[] package_com_huawei_hms_support_hianalytics_mappings;
		static Type lookup_com_huawei_hms_support_hianalytics_package (string klass)
		{
			if (package_com_huawei_hms_support_hianalytics_mappings == null) {
				package_com_huawei_hms_support_hianalytics_mappings = new string[]{
					"com/huawei/hms/support/hianalytics/HiAnalyticsBase:Huawei.Hms.Support.Hianalytics.HiAnalyticsBase",
					"com/huawei/hms/support/hianalytics/HiAnalyticsClient:Huawei.Hms.Support.Hianalytics.HiAnalyticsClient",
					"com/huawei/hms/support/hianalytics/HiAnalyticsInnerClient:Huawei.Hms.Support.Hianalytics.HiAnalyticsInnerClient",
					"com/huawei/hms/support/hianalytics/HiAnalyticsUtil:Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil",
				};
			}

			return Lookup (package_com_huawei_hms_support_hianalytics_mappings, klass);
		}

		static string[] package_com_huawei_hms_utils_mappings;
		static Type lookup_com_huawei_hms_utils_package (string klass)
		{
			if (package_com_huawei_hms_utils_mappings == null) {
				package_com_huawei_hms_utils_mappings = new string[]{
					"com/huawei/hms/utils/JsonUtil:Huawei.Hms.Utils.JsonUtil",
					"com/huawei/hms/utils/Util:Huawei.Hms.Utils.Util",
				};
			}

			return Lookup (package_com_huawei_hms_utils_mappings, klass);
		}
	}
}
