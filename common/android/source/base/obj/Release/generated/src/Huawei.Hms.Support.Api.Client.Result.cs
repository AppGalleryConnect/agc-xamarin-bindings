using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/Result", DoNotGenerateAcw=true)]
	public abstract partial class Result : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/Result", typeof (Result));
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

		protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Result']/constructor[@name='Result' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Result ()
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

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Lcom_huawei_hms_support_api_client_Status_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_huawei_hms_support_api_client_Status_Handler ()
		{
			if (cb_setStatus_Lcom_huawei_hms_support_api_client_Status_ == null)
				cb_setStatus_Lcom_huawei_hms_support_api_client_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStatus_Lcom_huawei_hms_support_api_client_Status_);
			return cb_setStatus_Lcom_huawei_hms_support_api_client_Status_;
		}

		static void n_SetStatus_Lcom_huawei_hms_support_api_client_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Support.Api.Client.Status Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Result']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/huawei/hms/support/api/client/Status;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/huawei/hms/support/api/client/Status;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Result']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
			[Register ("setStatus", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetSetStatus_Lcom_huawei_hms_support_api_client_Status_Handler")]
			set {
				const string __id = "setStatus.(Lcom/huawei/hms/support/api/client/Status;)V";
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

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/Result", DoNotGenerateAcw=true)]
	internal partial class ResultInvoker : Result {

		public ResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/Result", typeof (ResultInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
