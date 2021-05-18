using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendeviceApiImpl']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApiImpl", DoNotGenerateAcw=true)]
	public partial class HuaweiOpendeviceApiImpl : global::Java.Lang.Object, global::Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendeviceApiImpl']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "OpenIdentifierApiImpl";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApiImpl", typeof (HuaweiOpendeviceApiImpl));
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

		protected HuaweiOpendeviceApiImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendeviceApiImpl']/constructor[@name='HuaweiOpendeviceApiImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiOpendeviceApiImpl ()
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

		static Delegate cb_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_;
#pragma warning disable 0169
		static Delegate GetGetOdid_Lcom_huawei_hms_api_HuaweiApiClient_Handler ()
		{
			if (cb_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_ == null)
				cb_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOdid_Lcom_huawei_hms_api_HuaweiApiClient_);
			return cb_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_;
		}

		static IntPtr n_GetOdid_Lcom_huawei_hms_api_HuaweiApiClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Opendevice.HuaweiOpendeviceApiImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOdid (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendeviceApiImpl']/method[@name='getOdid' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient']]"
		[Register ("getOdid", "(Lcom/huawei/hms/api/HuaweiApiClient;)Lcom/huawei/hms/support/api/client/PendingResult;", "GetGetOdid_Lcom_huawei_hms_api_HuaweiApiClient_Handler")]
		public virtual unsafe global::Huawei.Hms.Support.Api.Client.PendingResult GetOdid (global::Huawei.Hms.Api.HuaweiApiClient p0)
		{
			const string __id = "getOdid.(Lcom/huawei/hms/api/HuaweiApiClient;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
