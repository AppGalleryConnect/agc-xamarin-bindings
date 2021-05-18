using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/HttpsException", DoNotGenerateAcw=true)]
	public partial class HttpsException : global::Java.Lang.Exception {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/HttpsException", typeof (HttpsException));
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

		protected HttpsException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']/constructor[@name='HttpsException' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.io.IOException']]"
		[Register (".ctor", "(ZLjava/io/IOException;)V", "")]
		public unsafe HttpsException (bool p0, global::Java.IO.IOException p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/io/IOException;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']/constructor[@name='HttpsException' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ZLjava/lang/String;)V", "")]
		public unsafe HttpsException (bool p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.IOException Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/io/IOException;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Ljava/io/IOException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasRequest;
#pragma warning disable 0169
		static Delegate GetHasRequestHandler ()
		{
			if (cb_hasRequest == null)
				cb_hasRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasRequest);
			return cb_hasRequest;
		}

		static bool n_HasRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRequest;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']/method[@name='hasRequest' and count(parameter)=0]"
			[Register ("hasRequest", "()Z", "GetHasRequestHandler")]
			get {
				const string __id = "hasRequest.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_message;
#pragma warning disable 0169
		static Delegate GetInvokeMessageHandler ()
		{
			if (cb_message == null)
				cb_message = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InvokeMessage);
			return cb_message;
		}

		static IntPtr n_InvokeMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvokeMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsException']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetInvokeMessageHandler")]
		public virtual unsafe string InvokeMessage ()
		{
			const string __id = "message.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
