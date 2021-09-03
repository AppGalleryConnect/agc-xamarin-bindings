using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultCallbacks", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class ResultCallbacks : global::Java.Lang.Object, global::Huawei.Hms.Support.Api.Client.IResultCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultCallbacks", typeof (ResultCallbacks));
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

		protected ResultCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/constructor[@name='ResultCallbacks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultCallbacks ()
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

		static Delegate cb_onFailure_Lcom_huawei_hms_support_api_client_Status_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_huawei_hms_support_api_client_Status_Handler ()
		{
			if (cb_onFailure_Lcom_huawei_hms_support_api_client_Status_ == null)
				cb_onFailure_Lcom_huawei_hms_support_api_client_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Lcom_huawei_hms_support_api_client_Status_);
			return cb_onFailure_Lcom_huawei_hms_support_api_client_Status_;
		}

		static void n_OnFailure_Lcom_huawei_hms_support_api_client_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onFailure", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetOnFailure_Lcom_huawei_hms_support_api_client_Status_Handler")]
		public abstract void OnFailure (global::Huawei.Hms.Support.Api.Client.Status p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onResult", "(Lcom/huawei/hms/support/api/client/Result;)V", "")]
		public unsafe void OnResult (global::Java.Lang.Object p0)
		{
			const string __id = "onResult.(Lcom/huawei/hms/support/api/client/Result;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler ()
		{
			if (cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_ == null)
				cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Lcom_huawei_hms_support_api_client_Result_);
			return cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_;
		}

		static void n_OnSuccess_Lcom_huawei_hms_support_api_client_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onSuccess", "(Lcom/huawei/hms/support/api/client/Result;)V", "GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler")]
		public abstract void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultCallbacks", DoNotGenerateAcw=true)]
	internal partial class ResultCallbacksInvoker : ResultCallbacks, global::Huawei.Hms.Support.Api.Client.IResultCallback {

		public ResultCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultCallbacks", typeof (ResultCallbacksInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onFailure", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetOnFailure_Lcom_huawei_hms_support_api_client_Status_Handler")]
		public override unsafe void OnFailure (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "onFailure.(Lcom/huawei/hms/support/api/client/Status;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultCallbacks']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onSuccess", "(Lcom/huawei/hms/support/api/client/Result;)V", "GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler")]
		public override unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			const string __id = "onSuccess.(Lcom/huawei/hms/support/api/client/Result;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
