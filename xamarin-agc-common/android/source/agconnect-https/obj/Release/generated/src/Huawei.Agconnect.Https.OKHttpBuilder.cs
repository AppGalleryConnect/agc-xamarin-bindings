using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/OKHttpBuilder", DoNotGenerateAcw=true)]
	public partial class OKHttpBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/OKHttpBuilder", typeof (OKHttpBuilder));
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

		protected OKHttpBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/constructor[@name='OKHttpBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OKHttpBuilder ()
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

		static Delegate cb_addInterceptor_Lokhttp3_Interceptor_;
#pragma warning disable 0169
		static Delegate GetAddInterceptor_Lokhttp3_Interceptor_Handler ()
		{
			if (cb_addInterceptor_Lokhttp3_Interceptor_ == null)
				cb_addInterceptor_Lokhttp3_Interceptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddInterceptor_Lokhttp3_Interceptor_);
			return cb_addInterceptor_Lokhttp3_Interceptor_;
		}

		static IntPtr n_AddInterceptor_Lokhttp3_Interceptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Square.OkHttp3.IInterceptor)global::Java.Lang.Object.GetObject<global::Square.OkHttp3.IInterceptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddInterceptor (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='addInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor']]"
		[Register ("addInterceptor", "(Lokhttp3/Interceptor;)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetAddInterceptor_Lokhttp3_Interceptor_Handler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder AddInterceptor (global::Square.OkHttp3.IInterceptor p0)
		{
			const string __id = "addInterceptor.(Lokhttp3/Interceptor;)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lokhttp3/OkHttpClient;", "GetBuildHandler")]
		public virtual unsafe global::Square.OkHttp3.OkHttpClient Build ()
		{
			const string __id = "build.()Lokhttp3/OkHttpClient;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.OkHttpClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connectTimeout_J;
#pragma warning disable 0169
		static Delegate GetConnectTimeout_JHandler ()
		{
			if (cb_connectTimeout_J == null)
				cb_connectTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ConnectTimeout_J);
			return cb_connectTimeout_J;
		}

		static IntPtr n_ConnectTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectTimeout (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='connectTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("connectTimeout", "(J)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetConnectTimeout_JHandler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder ConnectTimeout (long p0)
		{
			const string __id = "connectTimeout.(J)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableGzip;
#pragma warning disable 0169
		static Delegate GetEnableGzipHandler ()
		{
			if (cb_enableGzip == null)
				cb_enableGzip = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EnableGzip);
			return cb_enableGzip;
		}

		static IntPtr n_EnableGzip (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableGzip ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='enableGzip' and count(parameter)=0]"
		[Register ("enableGzip", "()Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetEnableGzipHandler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder EnableGzip ()
		{
			const string __id = "enableGzip.()Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readTimeout_J;
#pragma warning disable 0169
		static Delegate GetReadTimeout_JHandler ()
		{
			if (cb_readTimeout_J == null)
				cb_readTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_ReadTimeout_J);
			return cb_readTimeout_J;
		}

		static IntPtr n_ReadTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadTimeout (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='readTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("readTimeout", "(J)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetReadTimeout_JHandler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder ReadTimeout (long p0)
		{
			const string __id = "readTimeout.(J)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRetryTimes_I;
#pragma warning disable 0169
		static Delegate GetSetRetryTimes_IHandler ()
		{
			if (cb_setRetryTimes_I == null)
				cb_setRetryTimes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetRetryTimes_I);
			return cb_setRetryTimes_I;
		}

		static IntPtr n_SetRetryTimes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRetryTimes (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='setRetryTimes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRetryTimes", "(I)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetSetRetryTimes_IHandler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder SetRetryTimes (int p0)
		{
			const string __id = "setRetryTimes.(I)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_;
#pragma warning disable 0169
		static Delegate GetSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_Handler ()
		{
			if (cb_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_ == null)
				cb_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_);
			return cb_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_;
		}

		static IntPtr n_SslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Javax.Net.Ssl.IX509TrustManager)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SslSocketFactory (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='sslSocketFactory' and count(parameter)=2 and parameter[1][@type='javax.net.ssl.SSLSocketFactory'] and parameter[2][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/X509TrustManager;)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_Handler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder SslSocketFactory (global::Javax.Net.Ssl.SSLSocketFactory p0, global::Javax.Net.Ssl.IX509TrustManager p1)
		{
			const string __id = "sslSocketFactory.(Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/X509TrustManager;)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_writeTimeout_J;
#pragma warning disable 0169
		static Delegate GetWriteTimeout_JHandler ()
		{
			if (cb_writeTimeout_J == null)
				cb_writeTimeout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_WriteTimeout_J);
			return cb_writeTimeout_J;
		}

		static IntPtr n_WriteTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteTimeout (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='OKHttpBuilder']/method[@name='writeTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeTimeout", "(J)Lcom/huawei/agconnect/https/OKHttpBuilder;", "GetWriteTimeout_JHandler")]
		public virtual unsafe global::Huawei.Agconnect.Https.OKHttpBuilder WriteTimeout (long p0)
		{
			const string __id = "writeTimeout.(J)Lcom/huawei/agconnect/https/OKHttpBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.OKHttpBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
