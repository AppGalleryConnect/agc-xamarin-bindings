using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Core.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='AbstractMessageEntity']"
	[global::Android.Runtime.Register ("com/huawei/hms/core/aidl/AbstractMessageEntity", DoNotGenerateAcw=true)]
	public partial class AbstractMessageEntity : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/core/aidl/AbstractMessageEntity", typeof (AbstractMessageEntity));
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

		protected AbstractMessageEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='AbstractMessageEntity']/constructor[@name='AbstractMessageEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractMessageEntity ()
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

		static Delegate cb_getCommonStatus;
#pragma warning disable 0169
		static Delegate GetGetCommonStatusHandler ()
		{
			if (cb_getCommonStatus == null)
				cb_getCommonStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommonStatus);
			return cb_getCommonStatus;
		}

		static IntPtr n_GetCommonStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.AbstractMessageEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CommonStatus);
		}
#pragma warning restore 0169

		static Delegate cb_setCommonStatus_Lcom_huawei_hms_support_api_client_Status_;
#pragma warning disable 0169
		static Delegate GetSetCommonStatus_Lcom_huawei_hms_support_api_client_Status_Handler ()
		{
			if (cb_setCommonStatus_Lcom_huawei_hms_support_api_client_Status_ == null)
				cb_setCommonStatus_Lcom_huawei_hms_support_api_client_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCommonStatus_Lcom_huawei_hms_support_api_client_Status_);
			return cb_setCommonStatus_Lcom_huawei_hms_support_api_client_Status_;
		}

		static void n_SetCommonStatus_Lcom_huawei_hms_support_api_client_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.AbstractMessageEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CommonStatus = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Support.Api.Client.Status CommonStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='AbstractMessageEntity']/method[@name='getCommonStatus' and count(parameter)=0]"
			[Register ("getCommonStatus", "()Lcom/huawei/hms/support/api/client/Status;", "GetGetCommonStatusHandler")]
			get {
				const string __id = "getCommonStatus.()Lcom/huawei/hms/support/api/client/Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='AbstractMessageEntity']/method[@name='setCommonStatus' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
			[Register ("setCommonStatus", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetSetCommonStatus_Lcom_huawei_hms_support_api_client_Status_Handler")]
			set {
				const string __id = "setCommonStatus.(Lcom/huawei/hms/support/api/client/Status;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
