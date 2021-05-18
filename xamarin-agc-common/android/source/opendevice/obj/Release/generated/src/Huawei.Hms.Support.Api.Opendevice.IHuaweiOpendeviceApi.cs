using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Opendevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/interface[@name='HuaweiOpendeviceApi']"
	[Register ("com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApi", "", "Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApiInvoker")]
	public partial interface IHuaweiOpendeviceApi : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/interface[@name='HuaweiOpendeviceApi']/method[@name='getOdid' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient']]"
		[Register ("getOdid", "(Lcom/huawei/hms/api/HuaweiApiClient;)Lcom/huawei/hms/support/api/client/PendingResult;", "GetGetOdid_Lcom_huawei_hms_api_HuaweiApiClient_Handler:Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApiInvoker, Huawei.Hms.Opendevice")]
		global::Huawei.Hms.Support.Api.Client.PendingResult GetOdid (global::Huawei.Hms.Api.HuaweiApiClient p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApi", DoNotGenerateAcw=true)]
	internal partial class IHuaweiOpendeviceApiInvoker : global::Java.Lang.Object, IHuaweiOpendeviceApi {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/opendevice/HuaweiOpendeviceApi", typeof (IHuaweiOpendeviceApiInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IHuaweiOpendeviceApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHuaweiOpendeviceApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.opendevice.HuaweiOpendeviceApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHuaweiOpendeviceApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOdid (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_;
		public unsafe global::Huawei.Hms.Support.Api.Client.PendingResult GetOdid (global::Huawei.Hms.Api.HuaweiApiClient p0)
		{
			if (id_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_ == IntPtr.Zero)
				id_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_ = JNIEnv.GetMethodID (class_ref, "getOdid", "(Lcom/huawei/hms/api/HuaweiApiClient;)Lcom/huawei/hms/support/api/client/PendingResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOdid_Lcom_huawei_hms_api_HuaweiApiClient_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
