using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResolvingResultCallbacks", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class ResolvingResultCallbacks : global::Huawei.Hms.Support.Api.Client.ResultCallbacks {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResolvingResultCallbacks", typeof (ResolvingResultCallbacks));
		internal static new IntPtr class_ref {
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

		protected ResolvingResultCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']/constructor[@name='ResolvingResultCallbacks' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/app/Activity;I)V", "")]
		protected unsafe ResolvingResultCallbacks (global::Android.App.Activity p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onFailure", "(Lcom/huawei/hms/support/api/client/Status;)V", "")]
		public override sealed unsafe void OnFailure (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "onFailure.(Lcom/huawei/hms/support/api/client/Status;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_;
#pragma warning disable 0169
		static Delegate GetOnUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_Handler ()
		{
			if (cb_onUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_ == null)
				cb_onUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_);
			return cb_onUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_;
		}

		static void n_OnUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResolvingResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnresolvableFailure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']/method[@name='onUnresolvableFailure' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onUnresolvableFailure", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetOnUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_Handler")]
		public abstract void OnUnresolvableFailure (global::Huawei.Hms.Support.Api.Client.Status p0);

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResolvingResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler")]
		public override unsafe void OnSuccess (global::Java.Lang.Object context)
		{
			const string __id = "onSuccess.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResolvingResultCallbacks", DoNotGenerateAcw=true)]
	internal partial class ResolvingResultCallbacksInvoker : ResolvingResultCallbacks {

		public ResolvingResultCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResolvingResultCallbacks", typeof (ResolvingResultCallbacksInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResolvingResultCallbacks']/method[@name='onUnresolvableFailure' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onUnresolvableFailure", "(Lcom/huawei/hms/support/api/client/Status;)V", "GetOnUnresolvableFailure_Lcom_huawei_hms_support_api_client_Status_Handler")]
		public override unsafe void OnUnresolvableFailure (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "onUnresolvableFailure.(Lcom/huawei/hms/support/api/client/Status;)V";
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
