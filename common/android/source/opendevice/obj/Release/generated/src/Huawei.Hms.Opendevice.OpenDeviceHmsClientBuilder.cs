using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceHmsClientBuilder']"
	[global::Android.Runtime.Register ("com/huawei/hms/opendevice/OpenDeviceHmsClientBuilder", DoNotGenerateAcw=true)]
	public partial class OpenDeviceHmsClientBuilder : global::Huawei.Hms.Common.Internal.AbstractClientBuilder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/opendevice/OpenDeviceHmsClientBuilder", typeof (OpenDeviceHmsClientBuilder));
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

		protected OpenDeviceHmsClientBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceHmsClientBuilder']/constructor[@name='OpenDeviceHmsClientBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenDeviceHmsClientBuilder ()
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

		static Delegate cb_buildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetBuildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_Handler ()
		{
			if (cb_buildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_ == null)
				cb_buildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_L) n_BuildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_);
			return cb_buildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_;
		}

		static IntPtr n_BuildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceHmsClientBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildClient (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceHmsClientBuilder']/method[@name='buildClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.common.internal.ClientSettings'] and parameter[3][@type='com.huawei.hms.common.internal.BaseHmsClient.OnConnectionFailedListener'] and parameter[4][@type='com.huawei.hms.common.internal.BaseHmsClient.ConnectionCallbacks']]"
		[Register ("buildClient", "(Landroid/content/Context;Lcom/huawei/hms/common/internal/ClientSettings;Lcom/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener;Lcom/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks;)Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;", "GetBuildClient_Landroid_content_Context_Lcom_huawei_hms_common_internal_ClientSettings_Lcom_huawei_hms_common_internal_BaseHmsClient_OnConnectionFailedListener_Lcom_huawei_hms_common_internal_BaseHmsClient_ConnectionCallbacks_Handler")]
		public virtual unsafe global::Java.Lang.Object BuildClient (global::Android.Content.Context p0, global::Huawei.Hms.Common.Internal.ClientSettings p1, global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener p2, global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks p3)
		{
			const string __id = "buildClient.(Landroid/content/Context;Lcom/huawei/hms/common/internal/ClientSettings;Lcom/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener;Lcom/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks;)Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
