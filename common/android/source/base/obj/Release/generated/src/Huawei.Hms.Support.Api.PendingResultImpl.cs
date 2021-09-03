using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/PendingResultImpl", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result", "T extends com.huawei.hms.core.aidl.IMessageEntity"})]
	public abstract partial class PendingResultImpl : global::Huawei.Hms.Support.Api.Client.InnerPendingResult {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/field[@name='transport']"
		[Register ("transport")]
		protected global::Huawei.Hms.Support.Api.Transport.IDatagramTransport Transport {
			get {
				const string __id = "transport.Lcom/huawei/hms/support/api/transport/DatagramTransport;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transport.Lcom/huawei/hms/support/api/transport/DatagramTransport;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl.CallbackHandler']"
		[global::Android.Runtime.Register ("com/huawei/hms/support/api/PendingResultImpl$CallbackHandler", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
		protected internal partial class CallbackHandler : global::Android.OS.Handler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/PendingResultImpl$CallbackHandler", typeof (CallbackHandler));
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

			protected CallbackHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl.CallbackHandler']/constructor[@name='PendingResultImpl.CallbackHandler' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CallbackHandler ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl.CallbackHandler']/constructor[@name='PendingResultImpl.CallbackHandler' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
			[Register (".ctor", "(Landroid/os/Looper;)V", "")]
			public unsafe CallbackHandler (global::Android.OS.Looper p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/os/Looper;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate cb_post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_;
#pragma warning disable 0169
			static Delegate GetPost_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_Handler ()
			{
				if (cb_post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ == null)
					cb_post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_);
				return cb_post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_;
			}

			static void n_Post_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl.CallbackHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Post (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl.CallbackHandler']/method[@name='post' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;? super R&gt;'] and parameter[2][@type='R']]"
			[Register ("post", "(Lcom/huawei/hms/support/api/client/ResultCallback;Lcom/huawei/hms/support/api/client/Result;)V", "GetPost_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_Handler")]
			public virtual unsafe void Post (global::Huawei.Hms.Support.Api.Client.IResultCallback p0, global::Java.Lang.Object p1)
			{
				const string __id = "post.(Lcom/huawei/hms/support/api/client/ResultCallback;Lcom/huawei/hms/support/api/client/Result;)V";
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate cb_send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_;
#pragma warning disable 0169
			static Delegate GetSend_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_Handler ()
			{
				if (cb_send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ == null)
					cb_send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_);
				return cb_send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_;
			}

			static void n_Send_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl.CallbackHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Send (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl.CallbackHandler']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;? super R&gt;'] and parameter[2][@type='R']]"
			[Register ("send", "(Lcom/huawei/hms/support/api/client/ResultCallback;Lcom/huawei/hms/support/api/client/Result;)V", "GetSend_Lcom_huawei_hms_support_api_client_ResultCallback_Lcom_huawei_hms_support_api_client_Result_Handler")]
			protected virtual unsafe void Send (global::Huawei.Hms.Support.Api.Client.IResultCallback p0, global::Java.Lang.Object p1)
			{
				const string __id = "send.(Lcom/huawei/hms/support/api/client/ResultCallback;Lcom/huawei/hms/support/api/client/Result;)V";
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/PendingResultImpl", typeof (PendingResultImpl));
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

		protected PendingResultImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/constructor[@name='PendingResultImpl' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.core.aidl.IMessageEntity']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;)V", "")]
		public unsafe PendingResultImpl (global::Huawei.Hms.Support.Api.Client.IApiClient p0, string p1, global::Huawei.Hms.Core.Aidl.IMessageEntity p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/constructor[@name='PendingResultImpl' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;I)V", "")]
		public unsafe PendingResultImpl (global::Huawei.Hms.Support.Api.Client.IApiClient p0, string p1, global::Huawei.Hms.Core.Aidl.IMessageEntity p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/constructor[@name='PendingResultImpl' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[4][@type='java.lang.Class&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V", "")]
		public unsafe PendingResultImpl (global::Huawei.Hms.Support.Api.Client.IApiClient p0, string p1, global::Huawei.Hms.Core.Aidl.IMessageEntity p2, global::Java.Lang.Class p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public override unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseType);
			return cb_getResponseType;
		}

		static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseType);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Class ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='getResponseType' and count(parameter)=0]"
			[Register ("getResponseType", "()Ljava/lang/Class;", "GetGetResponseTypeHandler")]
			get {
				const string __id = "getResponseType.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lcom/huawei/hms/support/api/client/Result;", "")]
		public override sealed unsafe global::Java.Lang.Object Await ()
		{
			const string __id = "await.()Lcom/huawei/hms/support/api/client/Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_await_JLjava_util_concurrent_TimeUnit_ == null)
				cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Await_JLjava_util_concurrent_TimeUnit_);
			return cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Await_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Await (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::Java.Lang.Object Await (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "await.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='awaitOnAnyThread' and count(parameter)=0]"
		[Register ("awaitOnAnyThread", "()Lcom/huawei/hms/support/api/client/Result;", "")]
		public override sealed unsafe global::Java.Lang.Object AwaitOnAnyThread ()
		{
			const string __id = "awaitOnAnyThread.()Lcom/huawei/hms/support/api/client/Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='awaitOnAnyThread' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitOnAnyThread", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "")]
		public override sealed unsafe global::Java.Lang.Object AwaitOnAnyThread (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "awaitOnAnyThread.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_checkApiClient_Lcom_huawei_hms_support_api_client_ApiClient_;
#pragma warning disable 0169
		static Delegate GetCheckApiClient_Lcom_huawei_hms_support_api_client_ApiClient_Handler ()
		{
			if (cb_checkApiClient_Lcom_huawei_hms_support_api_client_ApiClient_ == null)
				cb_checkApiClient_Lcom_huawei_hms_support_api_client_ApiClient_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CheckApiClient_Lcom_huawei_hms_support_api_client_ApiClient_);
			return cb_checkApiClient_Lcom_huawei_hms_support_api_client_ApiClient_;
		}

		static bool n_CheckApiClient_Lcom_huawei_hms_support_api_client_ApiClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IApiClient)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckApiClient (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='checkApiClient' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient']]"
		[Register ("checkApiClient", "(Lcom/huawei/hms/support/api/client/ApiClient;)Z", "GetCheckApiClient_Lcom_huawei_hms_support_api_client_ApiClient_Handler")]
		protected virtual unsafe bool CheckApiClient (global::Huawei.Hms.Support.Api.Client.IApiClient p0)
		{
			const string __id = "checkApiClient.(Lcom/huawei/hms/support/api/client/ApiClient;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_OnError_I);
			return cb_onError_I;
		}

		static IntPtr n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnError (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)Lcom/huawei/hms/support/api/client/Result;", "GetOnError_IHandler")]
		protected virtual unsafe global::Java.Lang.Object OnError (int p0)
		{
			const string __id = "onError.(I)Lcom/huawei/hms/support/api/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='setResultCallback' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Landroid/os/Looper;Lcom/huawei/hms/support/api/client/ResultCallback;)V", "")]
		public override sealed unsafe void SetResultCallback (global::Android.OS.Looper p0, global::Huawei.Hms.Support.Api.Client.IResultCallback p1)
		{
			const string __id = "setResultCallback.(Landroid/os/Looper;Lcom/huawei/hms/support/api/client/ResultCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_Handler ()
		{
			if (cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ == null)
				cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_);
			return cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_;
		}

		static void n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='setResultCallback' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public override unsafe void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0)
		{
			const string __id = "setResultCallback.(Lcom/huawei/hms/support/api/client/ResultCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ == null)
				cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJL_V) n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_);
			return cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_;
		}

		static void n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.PendingResultImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='PendingResultImpl']/method[@name='setResultCallback' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			const string __id = "setResultCallback.(Lcom/huawei/hms/support/api/client/ResultCallback;JLjava/util/concurrent/TimeUnit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/PendingResultImpl", DoNotGenerateAcw=true)]
	internal partial class PendingResultImplInvoker : PendingResultImpl {

		public PendingResultImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/PendingResultImpl", typeof (PendingResultImplInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
