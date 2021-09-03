using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/HttpsKit", DoNotGenerateAcw=true)]
	public partial class HttpsKit : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit.Builder']"
		[global::Android.Runtime.Register ("com/huawei/agconnect/https/HttpsKit$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/HttpsKit$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit.Builder']/constructor[@name='HttpsKit.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/huawei/agconnect/https/HttpsKit;", "")]
			public unsafe global::Huawei.Agconnect.Https.HttpsKit Build ()
			{
				const string __id = "build.()Lcom/huawei/agconnect/https/HttpsKit;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit.Builder']/method[@name='client' and count(parameter)=1 and parameter[1][@type='okhttp3.OkHttpClient']]"
			[Register ("client", "(Lokhttp3/OkHttpClient;)Lcom/huawei/agconnect/https/HttpsKit$Builder;", "")]
			public unsafe global::Huawei.Agconnect.Https.HttpsKit.Builder Client (global::Square.OkHttp3.OkHttpClient p0)
			{
				const string __id = "client.(Lokhttp3/OkHttpClient;)Lcom/huawei/agconnect/https/HttpsKit$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit.Builder']/method[@name='executor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
			[Register ("executor", "(Ljava/util/concurrent/Executor;)Lcom/huawei/agconnect/https/HttpsKit$Builder;", "")]
			public unsafe global::Huawei.Agconnect.Https.HttpsKit.Builder Executor (global::Java.Util.Concurrent.IExecutor p0)
			{
				const string __id = "executor.(Ljava/util/concurrent/Executor;)Lcom/huawei/agconnect/https/HttpsKit$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/HttpsKit", typeof (HttpsKit));
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

		protected HttpsKit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_client;
#pragma warning disable 0169
		static Delegate GetClientHandler ()
		{
			if (cb_client == null)
				cb_client = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Client);
			return cb_client;
		}

		static IntPtr n_Client (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit']/method[@name='client' and count(parameter)=0]"
		[Register ("client", "()Lokhttp3/OkHttpClient;", "GetClientHandler")]
		public virtual unsafe global::Square.OkHttp3.OkHttpClient Client ()
		{
			const string __id = "client.()Lokhttp3/OkHttpClient;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_create_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreate_Landroid_content_Context_Handler ()
		{
			if (cb_create_Landroid_content_Context_ == null)
				cb_create_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Create_Landroid_content_Context_);
			return cb_create_Landroid_content_Context_;
		}

		static IntPtr n_Create_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("create", "(Landroid/content/Context;)Lcom/huawei/agconnect/https/Service;", "GetCreate_Landroid_content_Context_Handler")]
		public virtual unsafe global::Huawei.Agconnect.Https.IService Create (global::Android.Content.Context p0)
		{
			const string __id = "create.(Landroid/content/Context;)Lcom/huawei/agconnect/https/Service;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.IService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_executor;
#pragma warning disable 0169
		static Delegate GetExecutorHandler ()
		{
			if (cb_executor == null)
				cb_executor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Executor);
			return cb_executor;
		}

		static IntPtr n_Executor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Executor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsKit']/method[@name='executor' and count(parameter)=0]"
		[Register ("executor", "()Ljava/util/concurrent/Executor;", "GetExecutorHandler")]
		public virtual unsafe global::Java.Util.Concurrent.IExecutor Executor ()
		{
			const string __id = "executor.()Ljava/util/concurrent/Executor;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
