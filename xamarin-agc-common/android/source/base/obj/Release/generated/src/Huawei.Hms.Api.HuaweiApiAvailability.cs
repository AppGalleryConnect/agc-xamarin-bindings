using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiAvailability", DoNotGenerateAcw=true)]
	public abstract partial class HuaweiApiAvailability : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='ACTIVITY_NAME']"
		[Register ("ACTIVITY_NAME")]
		public const string ActivityName = (string) "com.huawei.hms.core.activity.JumpActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='APPID_HMS']"
		[Register ("APPID_HMS")]
		public const string AppidHms = (string) "C10132067";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='APPID_HMS_TV']"
		[Register ("APPID_HMS_TV")]
		public const string AppidHmsTv = (string) "C100636709";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_GAME']"
		[Register ("HMS_API_NAME_GAME")]
		public const string HmsApiNameGame = (string) "HuaweiGame.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_IAP']"
		[Register ("HMS_API_NAME_IAP")]
		public const string HmsApiNameIap = (string) "HuaweiIap.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_ID']"
		[Register ("HMS_API_NAME_ID")]
		public const string HmsApiNameId = (string) "HuaweiID.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_OD']"
		[Register ("HMS_API_NAME_OD")]
		public const string HmsApiNameOd = (string) "HuaweiOpenDevice.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_PAY']"
		[Register ("HMS_API_NAME_PAY")]
		public const string HmsApiNamePay = (string) "HuaweiPay.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_PPS']"
		[Register ("HMS_API_NAME_PPS")]
		public const string HmsApiNamePps = (string) "HuaweiPPSkit.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_PUSH']"
		[Register ("HMS_API_NAME_PUSH")]
		public const string HmsApiNamePush = (string) "HuaweiPush.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_API_NAME_SNS']"
		[Register ("HMS_API_NAME_SNS")]
		public const string HmsApiNameSns = (string) "HuaweiSns.API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_JSON_VERSION_MIN']"
		[Register ("HMS_JSON_VERSION_MIN")]
		public const int HmsJsonVersionMin = (int) 30000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_SDK_VERSION_CODE']"
		[Register ("HMS_SDK_VERSION_CODE")]
		public const int HmsSdkVersionCode = (int) 50100300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_SDK_VERSION_NAME']"
		[Register ("HMS_SDK_VERSION_NAME")]
		public const string HmsSdkVersionName = (string) "5.1.0.300";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_GAME']"
		[Register ("HMS_VERSION_CODE_GAME")]
		public const int HmsVersionCodeGame = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_IAP']"
		[Register ("HMS_VERSION_CODE_IAP")]
		public const int HmsVersionCodeIap = (int) 20700300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_ID']"
		[Register ("HMS_VERSION_CODE_ID")]
		public const int HmsVersionCodeId = (int) 30000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_MIN']"
		[Register ("HMS_VERSION_CODE_MIN")]
		public const int HmsVersionCodeMin = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_OD']"
		[Register ("HMS_VERSION_CODE_OD")]
		public const int HmsVersionCodeOd = (int) 20601000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_PAY']"
		[Register ("HMS_VERSION_CODE_PAY")]
		public const int HmsVersionCodePay = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_PPS']"
		[Register ("HMS_VERSION_CODE_PPS")]
		public const int HmsVersionCodePps = (int) 20700300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_PUSH']"
		[Register ("HMS_VERSION_CODE_PUSH")]
		public const int HmsVersionCodePush = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_CODE_SNS']"
		[Register ("HMS_VERSION_CODE_SNS")]
		public const int HmsVersionCodeSns = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_MAX']"
		[Register ("HMS_VERSION_MAX")]
		public const int HmsVersionMax = (int) 20600000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='HMS_VERSION_MIN']"
		[Register ("HMS_VERSION_MIN")]
		public const int HmsVersionMin = (int) 20503000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='NOTICE_VERSION_CODE']"
		[Register ("NOTICE_VERSION_CODE")]
		public const int NoticeVersionCode = (int) 20600000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_ACTION']"
		[Register ("SERVICES_ACTION")]
		public const string ServicesAction = (string) "com.huawei.hms.core.aidlservice";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_PACKAGE']"
		[Register ("SERVICES_PACKAGE")]
		public const string ServicesPackage = (string) "com.huawei.hwid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_PACKAGE_TV']"
		[Register ("SERVICES_PACKAGE_TV")]
		public const string ServicesPackageTv = (string) "com.huawei.hwid.tv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_SIGNATURE']"
		[Register ("SERVICES_SIGNATURE")]
		public const string ServicesSignature = (string) "B92825C2BD5D6D6D1E7F39EECD17843B7D9016F611136B75441BC6F4D3F00F05";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_SIGNATURE_CAR']"
		[Register ("SERVICES_SIGNATURE_CAR")]
		public const string ServicesSignatureCar = (string) "3517262215D8D3008CBF888750B6418EDC4D562AC33ED6874E0D73ABA667BC3C";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/field[@name='SERVICES_SIGNATURE_TV']"
		[Register ("SERVICES_SIGNATURE_TV")]
		public const string ServicesSignatureTv = (string) "3517262215D8D3008CBF888750B6418EDC4D562AC33ED6874E0D73ABA667BC3C";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiAvailability", typeof (HuaweiApiAvailability));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected HuaweiApiAvailability (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/constructor[@name='HuaweiApiAvailability' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiApiAvailability ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> ApiMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getApiMap' and count(parameter)=0]"
			[Register ("getApiMap", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getApiMap.()Ljava/util/Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Huawei.Hms.Api.HuaweiApiAvailability Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/api/HuaweiApiAvailability;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/api/HuaweiApiAvailability;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int ServicesVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getServicesVersionCode' and count(parameter)=0]"
			[Register ("getServicesVersionCode", "()I", "")]
			get {
				const string __id = "getServicesVersionCode.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='setServicesVersionCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServicesVersionCode", "(I)V", "")]
			set {
				const string __id = "setServicesVersionCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_;
#pragma warning disable 0169
		static Delegate GetCheckApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_Handler ()
		{
			if (cb_checkApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_ == null)
				cb_checkApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CheckApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_);
			return cb_checkApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_;
		}

		static IntPtr n_CheckApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Common.Api.IHuaweiApiCallable)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.IHuaweiApiCallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Common.Api.IHuaweiApiCallable[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Huawei.Hms.Common.Api.IHuaweiApiCallable));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckApiAccessible (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='checkApiAccessible' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.api.HuaweiApiCallable'] and parameter[2][@type='com.huawei.hms.common.api.HuaweiApiCallable...']]"
		[Register ("checkApiAccessible", "(Lcom/huawei/hms/common/api/HuaweiApiCallable;[Lcom/huawei/hms/common/api/HuaweiApiCallable;)Lcom/huawei/hmf/tasks/Task;", "GetCheckApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task CheckApiAccessible (global::Huawei.Hms.Common.Api.IHuaweiApiCallable p0, params global::Huawei.Hms.Common.Api.IHuaweiApiCallable[] p1);

		static Delegate cb_checkApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_;
#pragma warning disable 0169
		static Delegate GetCheckApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_Handler ()
		{
			if (cb_checkApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_ == null)
				cb_checkApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CheckApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_);
			return cb_checkApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_;
		}

		static IntPtr n_CheckApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Common.HuaweiApi[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Huawei.Hms.Common.HuaweiApi));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckApiAccessible (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='checkApiAccessible' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.HuaweiApi&lt;?&gt;'] and parameter[2][@type='com.huawei.hms.common.HuaweiApi&lt;?&gt;...']]"
		[Register ("checkApiAccessible", "(Lcom/huawei/hms/common/HuaweiApi;[Lcom/huawei/hms/common/HuaweiApi;)Lcom/huawei/hmf/tasks/Task;", "GetCheckApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task CheckApiAccessible (global::Huawei.Hms.Common.HuaweiApi p0, params global::Huawei.Hms.Common.HuaweiApi[] p1);

		static Delegate cb_getErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_;
#pragma warning disable 0169
		static Delegate GetGetErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler ()
		{
			if (cb_getErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ == null)
				cb_getErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_);
			return cb_getErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_;
		}

		static IntPtr n_GetErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetErrPendingIntent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrPendingIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.ConnectionResult']]"
		[Register ("getErrPendingIntent", "(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)Landroid/app/PendingIntent;", "GetGetErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler")]
		public abstract global::Android.App.PendingIntent GetErrPendingIntent (global::Android.Content.Context p0, global::Huawei.Hms.Api.ConnectionResult p1);

		static Delegate cb_getErrPendingIntent_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetGetErrPendingIntent_Landroid_content_Context_IIHandler ()
		{
			if (cb_getErrPendingIntent_Landroid_content_Context_II == null)
				cb_getErrPendingIntent_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_GetErrPendingIntent_Landroid_content_Context_II);
			return cb_getErrPendingIntent_Landroid_content_Context_II;
		}

		static IntPtr n_GetErrPendingIntent_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetErrPendingIntent (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrPendingIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getErrPendingIntent", "(Landroid/content/Context;II)Landroid/app/PendingIntent;", "GetGetErrPendingIntent_Landroid_content_Context_IIHandler")]
		public abstract global::Android.App.PendingIntent GetErrPendingIntent (global::Android.Content.Context p0, int p1, int p2);

		static Delegate cb_getErrorDialog_Landroid_app_Activity_II;
#pragma warning disable 0169
		static Delegate GetGetErrorDialog_Landroid_app_Activity_IIHandler ()
		{
			if (cb_getErrorDialog_Landroid_app_Activity_II == null)
				cb_getErrorDialog_Landroid_app_Activity_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_GetErrorDialog_Landroid_app_Activity_II);
			return cb_getErrorDialog_Landroid_app_Activity_II;
		}

		static IntPtr n_GetErrorDialog_Landroid_app_Activity_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetErrorDialog (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;II)Landroid/app/Dialog;", "GetGetErrorDialog_Landroid_app_Activity_IIHandler")]
		public abstract global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1, int p2);

		static Delegate cb_getErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_;
#pragma warning disable 0169
		static Delegate GetGetErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler ()
		{
			if (cb_getErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ == null)
				cb_getErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_L) n_GetErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_);
			return cb_getErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_;
		}

		static IntPtr n_GetErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Android.Content.IDialogInterfaceOnCancelListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnCancelListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetErrorDialog (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorDialog' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;", "GetGetErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public abstract global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3);

		static Delegate cb_getErrorString_I;
#pragma warning disable 0169
		static Delegate GetGetErrorString_IHandler ()
		{
			if (cb_getErrorString_I == null)
				cb_getErrorString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetErrorString_I);
			return cb_getErrorString_I;
		}

		static IntPtr n_GetErrorString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetErrorString (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorString", "(I)Ljava/lang/String;", "GetGetErrorString_IHandler")]
		public abstract string GetErrorString (int p0);

		static Delegate cb_getHuaweiServicesReady_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetGetHuaweiServicesReady_Landroid_app_Activity_Handler ()
		{
			if (cb_getHuaweiServicesReady_Landroid_app_Activity_ == null)
				cb_getHuaweiServicesReady_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetHuaweiServicesReady_Landroid_app_Activity_);
			return cb_getHuaweiServicesReady_Landroid_app_Activity_;
		}

		static IntPtr n_GetHuaweiServicesReady_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHuaweiServicesReady (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getHuaweiServicesReady' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getHuaweiServicesReady", "(Landroid/app/Activity;)Lcom/huawei/hmf/tasks/Task;", "GetGetHuaweiServicesReady_Landroid_app_Activity_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task GetHuaweiServicesReady (global::Android.App.Activity p0);

		static Delegate cb_getResolveErrorIntent_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetGetResolveErrorIntent_Landroid_app_Activity_IHandler ()
		{
			if (cb_getResolveErrorIntent_Landroid_app_Activity_I == null)
				cb_getResolveErrorIntent_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_GetResolveErrorIntent_Landroid_app_Activity_I);
			return cb_getResolveErrorIntent_Landroid_app_Activity_I;
		}

		static IntPtr n_GetResolveErrorIntent_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResolveErrorIntent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getResolveErrorIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getResolveErrorIntent", "(Landroid/app/Activity;I)Landroid/content/Intent;", "GetGetResolveErrorIntent_Landroid_app_Activity_IHandler")]
		public abstract global::Android.Content.Intent GetResolveErrorIntent (global::Android.App.Activity p0, int p1);

		static Delegate cb_getResolveErrorPendingIntent_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetGetResolveErrorPendingIntent_Landroid_app_Activity_IHandler ()
		{
			if (cb_getResolveErrorPendingIntent_Landroid_app_Activity_I == null)
				cb_getResolveErrorPendingIntent_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_GetResolveErrorPendingIntent_Landroid_app_Activity_I);
			return cb_getResolveErrorPendingIntent_Landroid_app_Activity_I;
		}

		static IntPtr n_GetResolveErrorPendingIntent_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResolveErrorPendingIntent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getResolveErrorPendingIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getResolveErrorPendingIntent", "(Landroid/app/Activity;I)Landroid/app/PendingIntent;", "GetGetResolveErrorPendingIntent_Landroid_app_Activity_IHandler")]
		public abstract global::Android.App.PendingIntent GetResolveErrorPendingIntent (global::Android.App.Activity p0, int p1);

		static Delegate cb_isHuaweiMobileNoticeAvailable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsHuaweiMobileNoticeAvailable_Landroid_content_Context_Handler ()
		{
			if (cb_isHuaweiMobileNoticeAvailable_Landroid_content_Context_ == null)
				cb_isHuaweiMobileNoticeAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IsHuaweiMobileNoticeAvailable_Landroid_content_Context_);
			return cb_isHuaweiMobileNoticeAvailable_Landroid_content_Context_;
		}

		static int n_IsHuaweiMobileNoticeAvailable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsHuaweiMobileNoticeAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileNoticeAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileNoticeAvailable", "(Landroid/content/Context;)I", "GetIsHuaweiMobileNoticeAvailable_Landroid_content_Context_Handler")]
		public abstract int IsHuaweiMobileNoticeAvailable (global::Android.Content.Context p0);

		static Delegate cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_Handler ()
		{
			if (cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_ == null)
				cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_);
			return cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_;
		}

		static int n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsHuaweiMobileServicesAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;)I", "GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_Handler")]
		public abstract int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0);

		static Delegate cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_IHandler ()
		{
			if (cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_I == null)
				cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_I);
			return cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_I;
		}

		static int n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsHuaweiMobileServicesAvailable (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;I)I", "GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_IHandler")]
		public abstract int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0, int p1);

		static Delegate cb_isUserResolvableError_I;
#pragma warning disable 0169
		static Delegate GetIsUserResolvableError_IHandler ()
		{
			if (cb_isUserResolvableError_I == null)
				cb_isUserResolvableError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsUserResolvableError_I);
			return cb_isUserResolvableError_I;
		}

		static bool n_IsUserResolvableError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUserResolvableError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isUserResolvableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserResolvableError", "(I)Z", "GetIsUserResolvableError_IHandler")]
		public abstract bool IsUserResolvableError (int p0);

		static Delegate cb_isUserResolvableError_ILandroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetIsUserResolvableError_ILandroid_app_PendingIntent_Handler ()
		{
			if (cb_isUserResolvableError_ILandroid_app_PendingIntent_ == null)
				cb_isUserResolvableError_ILandroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_Z) n_IsUserResolvableError_ILandroid_app_PendingIntent_);
			return cb_isUserResolvableError_ILandroid_app_PendingIntent_;
		}

		static bool n_IsUserResolvableError_ILandroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUserResolvableError (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isUserResolvableError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("isUserResolvableError", "(ILandroid/app/PendingIntent;)Z", "GetIsUserResolvableError_ILandroid_app_PendingIntent_Handler")]
		public abstract bool IsUserResolvableError (int p0, global::Android.App.PendingIntent p1);

		static Delegate cb_popupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_;
#pragma warning disable 0169
		static Delegate GetPopupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler ()
		{
			if (cb_popupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ == null)
				cb_popupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PopupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_);
			return cb_popupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_;
		}

		static void n_PopupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PopupErrNotification (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='popupErrNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.ConnectionResult']]"
		[Register ("popupErrNotification", "(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)V", "GetPopupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler")]
		public abstract void PopupErrNotification (global::Android.Content.Context p0, global::Huawei.Hms.Api.ConnectionResult p1);

		static Delegate cb_resolveError_Landroid_app_Activity_II;
#pragma warning disable 0169
		static Delegate GetResolveError_Landroid_app_Activity_IIHandler ()
		{
			if (cb_resolveError_Landroid_app_Activity_II == null)
				cb_resolveError_Landroid_app_Activity_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_ResolveError_Landroid_app_Activity_II);
			return cb_resolveError_Landroid_app_Activity_II;
		}

		static void n_ResolveError_Landroid_app_Activity_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResolveError (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='resolveError' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("resolveError", "(Landroid/app/Activity;II)V", "GetResolveError_Landroid_app_Activity_IIHandler")]
		public abstract void ResolveError (global::Android.App.Activity p0, int p1, int p2);

		static Delegate cb_resolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetResolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_Handler ()
		{
			if (cb_resolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_ == null)
				cb_resolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_ResolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_);
			return cb_resolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_;
		}

		static void n_ResolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ResolveError (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='resolveError' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.app.PendingIntent']]"
		[Register ("resolveError", "(Landroid/app/Activity;IILandroid/app/PendingIntent;)V", "GetResolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_Handler")]
		public abstract void ResolveError (global::Android.App.Activity p0, int p1, int p2, global::Android.App.PendingIntent p3);

		static Delegate cb_showErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_;
#pragma warning disable 0169
		static Delegate GetShowErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_Handler ()
		{
			if (cb_showErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_ == null)
				cb_showErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILIL_Z) n_ShowErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_);
			return cb_showErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_;
		}

		static bool n_ShowErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Android.Content.IDialogInterfaceOnCancelListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnCancelListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowErrorDialogFragment (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Fragment'] and parameter[4][@type='int'] and parameter[5][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;ILandroid/app/Fragment;ILandroid/content/DialogInterface$OnCancelListener;)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public abstract bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, global::Android.App.Fragment p2, int p3, global::Android.Content.IDialogInterfaceOnCancelListener p4);

		static Delegate cb_showErrorDialogFragment_Landroid_app_Activity_II;
#pragma warning disable 0169
		static Delegate GetShowErrorDialogFragment_Landroid_app_Activity_IIHandler ()
		{
			if (cb_showErrorDialogFragment_Landroid_app_Activity_II == null)
				cb_showErrorDialogFragment_Landroid_app_Activity_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_Z) n_ShowErrorDialogFragment_Landroid_app_Activity_II);
			return cb_showErrorDialogFragment_Landroid_app_Activity_II;
		}

		static bool n_ShowErrorDialogFragment_Landroid_app_Activity_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowErrorDialogFragment (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;II)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_IIHandler")]
		public abstract bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, int p2);

		static Delegate cb_showErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_;
#pragma warning disable 0169
		static Delegate GetShowErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler ()
		{
			if (cb_showErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ == null)
				cb_showErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_Z) n_ShowErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_);
			return cb_showErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_;
		}

		static bool n_ShowErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Android.Content.IDialogInterfaceOnCancelListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnCancelListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowErrorDialogFragment (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public abstract bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3);

		static Delegate cb_showErrorNotification_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetShowErrorNotification_Landroid_content_Context_IHandler ()
		{
			if (cb_showErrorNotification_Landroid_content_Context_I == null)
				cb_showErrorNotification_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_ShowErrorNotification_Landroid_content_Context_I);
			return cb_showErrorNotification_Landroid_content_Context_I;
		}

		static void n_ShowErrorNotification_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiAvailability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowErrorNotification (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("showErrorNotification", "(Landroid/content/Context;I)V", "GetShowErrorNotification_Landroid_content_Context_IHandler")]
		public abstract void ShowErrorNotification (global::Android.Content.Context p0, int p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiAvailability", DoNotGenerateAcw=true)]
	internal partial class HuaweiApiAvailabilityInvoker : HuaweiApiAvailability {

		public HuaweiApiAvailabilityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiAvailability", typeof (HuaweiApiAvailabilityInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='checkApiAccessible' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.api.HuaweiApiCallable'] and parameter[2][@type='com.huawei.hms.common.api.HuaweiApiCallable...']]"
		[Register ("checkApiAccessible", "(Lcom/huawei/hms/common/api/HuaweiApiCallable;[Lcom/huawei/hms/common/api/HuaweiApiCallable;)Lcom/huawei/hmf/tasks/Task;", "GetCheckApiAccessible_Lcom_huawei_hms_common_api_HuaweiApiCallable_arrayLcom_huawei_hms_common_api_HuaweiApiCallable_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task CheckApiAccessible (global::Huawei.Hms.Common.Api.IHuaweiApiCallable p0, params global::Huawei.Hms.Common.Api.IHuaweiApiCallable[] p1)
		{
			const string __id = "checkApiAccessible.(Lcom/huawei/hms/common/api/HuaweiApiCallable;[Lcom/huawei/hms/common/api/HuaweiApiCallable;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='checkApiAccessible' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.HuaweiApi&lt;?&gt;'] and parameter[2][@type='com.huawei.hms.common.HuaweiApi&lt;?&gt;...']]"
		[Register ("checkApiAccessible", "(Lcom/huawei/hms/common/HuaweiApi;[Lcom/huawei/hms/common/HuaweiApi;)Lcom/huawei/hmf/tasks/Task;", "GetCheckApiAccessible_Lcom_huawei_hms_common_HuaweiApi_arrayLcom_huawei_hms_common_HuaweiApi_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task CheckApiAccessible (global::Huawei.Hms.Common.HuaweiApi p0, params global::Huawei.Hms.Common.HuaweiApi[] p1)
		{
			const string __id = "checkApiAccessible.(Lcom/huawei/hms/common/HuaweiApi;[Lcom/huawei/hms/common/HuaweiApi;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrPendingIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.ConnectionResult']]"
		[Register ("getErrPendingIntent", "(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)Landroid/app/PendingIntent;", "GetGetErrPendingIntent_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler")]
		public override unsafe global::Android.App.PendingIntent GetErrPendingIntent (global::Android.Content.Context p0, global::Huawei.Hms.Api.ConnectionResult p1)
		{
			const string __id = "getErrPendingIntent.(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)Landroid/app/PendingIntent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrPendingIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getErrPendingIntent", "(Landroid/content/Context;II)Landroid/app/PendingIntent;", "GetGetErrPendingIntent_Landroid_content_Context_IIHandler")]
		public override unsafe global::Android.App.PendingIntent GetErrPendingIntent (global::Android.Content.Context p0, int p1, int p2)
		{
			const string __id = "getErrPendingIntent.(Landroid/content/Context;II)Landroid/app/PendingIntent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;II)Landroid/app/Dialog;", "GetGetErrorDialog_Landroid_app_Activity_IIHandler")]
		public override unsafe global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1, int p2)
		{
			const string __id = "getErrorDialog.(Landroid/app/Activity;II)Landroid/app/Dialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorDialog' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("getErrorDialog", "(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;", "GetGetErrorDialog_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public override unsafe global::Android.App.Dialog GetErrorDialog (global::Android.App.Activity p0, int p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3)
		{
			const string __id = "getErrorDialog.(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorString", "(I)Ljava/lang/String;", "GetGetErrorString_IHandler")]
		public override unsafe string GetErrorString (int p0)
		{
			const string __id = "getErrorString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getHuaweiServicesReady' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getHuaweiServicesReady", "(Landroid/app/Activity;)Lcom/huawei/hmf/tasks/Task;", "GetGetHuaweiServicesReady_Landroid_app_Activity_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task GetHuaweiServicesReady (global::Android.App.Activity p0)
		{
			const string __id = "getHuaweiServicesReady.(Landroid/app/Activity;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getResolveErrorIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getResolveErrorIntent", "(Landroid/app/Activity;I)Landroid/content/Intent;", "GetGetResolveErrorIntent_Landroid_app_Activity_IHandler")]
		public override unsafe global::Android.Content.Intent GetResolveErrorIntent (global::Android.App.Activity p0, int p1)
		{
			const string __id = "getResolveErrorIntent.(Landroid/app/Activity;I)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='getResolveErrorPendingIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getResolveErrorPendingIntent", "(Landroid/app/Activity;I)Landroid/app/PendingIntent;", "GetGetResolveErrorPendingIntent_Landroid_app_Activity_IHandler")]
		public override unsafe global::Android.App.PendingIntent GetResolveErrorPendingIntent (global::Android.App.Activity p0, int p1)
		{
			const string __id = "getResolveErrorPendingIntent.(Landroid/app/Activity;I)Landroid/app/PendingIntent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileNoticeAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileNoticeAvailable", "(Landroid/content/Context;)I", "GetIsHuaweiMobileNoticeAvailable_Landroid_content_Context_Handler")]
		public override unsafe int IsHuaweiMobileNoticeAvailable (global::Android.Content.Context p0)
		{
			const string __id = "isHuaweiMobileNoticeAvailable.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;)I", "GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_Handler")]
		public override unsafe int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0)
		{
			const string __id = "isHuaweiMobileServicesAvailable.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;I)I", "GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_IHandler")]
		public override unsafe int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0, int p1)
		{
			const string __id = "isHuaweiMobileServicesAvailable.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isUserResolvableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserResolvableError", "(I)Z", "GetIsUserResolvableError_IHandler")]
		public override unsafe bool IsUserResolvableError (int p0)
		{
			const string __id = "isUserResolvableError.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='isUserResolvableError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("isUserResolvableError", "(ILandroid/app/PendingIntent;)Z", "GetIsUserResolvableError_ILandroid_app_PendingIntent_Handler")]
		public override unsafe bool IsUserResolvableError (int p0, global::Android.App.PendingIntent p1)
		{
			const string __id = "isUserResolvableError.(ILandroid/app/PendingIntent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='popupErrNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.ConnectionResult']]"
		[Register ("popupErrNotification", "(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)V", "GetPopupErrNotification_Landroid_content_Context_Lcom_huawei_hms_api_ConnectionResult_Handler")]
		public override unsafe void PopupErrNotification (global::Android.Content.Context p0, global::Huawei.Hms.Api.ConnectionResult p1)
		{
			const string __id = "popupErrNotification.(Landroid/content/Context;Lcom/huawei/hms/api/ConnectionResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='resolveError' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("resolveError", "(Landroid/app/Activity;II)V", "GetResolveError_Landroid_app_Activity_IIHandler")]
		public override unsafe void ResolveError (global::Android.App.Activity p0, int p1, int p2)
		{
			const string __id = "resolveError.(Landroid/app/Activity;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='resolveError' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.app.PendingIntent']]"
		[Register ("resolveError", "(Landroid/app/Activity;IILandroid/app/PendingIntent;)V", "GetResolveError_Landroid_app_Activity_IILandroid_app_PendingIntent_Handler")]
		public override unsafe void ResolveError (global::Android.App.Activity p0, int p1, int p2, global::Android.App.PendingIntent p3)
		{
			const string __id = "resolveError.(Landroid/app/Activity;IILandroid/app/PendingIntent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Fragment'] and parameter[4][@type='int'] and parameter[5][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;ILandroid/app/Fragment;ILandroid/content/DialogInterface$OnCancelListener;)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_ILandroid_app_Fragment_ILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public override unsafe bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, global::Android.App.Fragment p2, int p3, global::Android.Content.IDialogInterfaceOnCancelListener p4)
		{
			const string __id = "showErrorDialogFragment.(Landroid/app/Activity;ILandroid/app/Fragment;ILandroid/content/DialogInterface$OnCancelListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;II)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_IIHandler")]
		public override unsafe bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, int p2)
		{
			const string __id = "showErrorDialogFragment.(Landroid/app/Activity;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorDialogFragment' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("showErrorDialogFragment", "(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Z", "GetShowErrorDialogFragment_Landroid_app_Activity_IILandroid_content_DialogInterface_OnCancelListener_Handler")]
		public override unsafe bool ShowErrorDialogFragment (global::Android.App.Activity p0, int p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3)
		{
			const string __id = "showErrorDialogFragment.(Landroid/app/Activity;IILandroid/content/DialogInterface$OnCancelListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiAvailability']/method[@name='showErrorNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("showErrorNotification", "(Landroid/content/Context;I)V", "GetShowErrorNotification_Landroid_content_Context_IHandler")]
		public override unsafe void ShowErrorNotification (global::Android.Content.Context p0, int p1)
		{
			const string __id = "showErrorNotification.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
