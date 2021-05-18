using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/HttpsResult", DoNotGenerateAcw=true)]
	public partial class HttpsResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/HttpsResult", typeof (HttpsResult));
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

		protected HttpsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getErrorMsg;
#pragma warning disable 0169
		static Delegate GetGetErrorMsgHandler ()
		{
			if (cb_getErrorMsg == null)
				cb_getErrorMsg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorMsg);
			return cb_getErrorMsg;
		}

		static IntPtr n_GetErrorMsg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMsg);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']/method[@name='getErrorMsg' and count(parameter)=0]"
			[Register ("getErrorMsg", "()Ljava/lang/String;", "GetGetErrorMsgHandler")]
			get {
				const string __id = "getErrorMsg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
			get {
				const string __id = "getResponse.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_code;
#pragma warning disable 0169
		static Delegate GetCodeHandler ()
		{
			if (cb_code == null)
				cb_code = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Code);
			return cb_code;
		}

		static int n_Code (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler")]
		public virtual unsafe int Code ()
		{
			const string __id = "code.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_;
#pragma warning disable 0169
		static Delegate GetGetResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_Handler ()
		{
			if (cb_getResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_ == null)
				cb_getResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_);
			return cb_getResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_;
		}

		static IntPtr n_GetResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.HttpsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.AdapterFactory> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='HttpsResult']/method[@name='getResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='com.huawei.agconnect.https.Adapter.Factory']]"
		[Register ("getResponse", "(Ljava/lang/Class;Lcom/huawei/agconnect/https/Adapter$Factory;)Ljava/lang/Object;", "GetGetResponse_Ljava_lang_Class_Lcom_huawei_agconnect_https_Adapter_Factory_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetResponse (global::Java.Lang.Class p0, global::Huawei.Agconnect.Https.AdapterFactory p1)
		{
			const string __id = "getResponse.(Ljava/lang/Class;Lcom/huawei/agconnect/https/Adapter$Factory;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
