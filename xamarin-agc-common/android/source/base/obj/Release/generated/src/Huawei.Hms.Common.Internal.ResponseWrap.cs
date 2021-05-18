using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ResponseWrap", DoNotGenerateAcw=true)]
	public partial class ResponseWrap : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ResponseWrap", typeof (ResponseWrap));
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

		protected ResponseWrap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/constructor[@name='ResponseWrap' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.ResponseHeader']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/internal/ResponseHeader;)V", "")]
		public unsafe ResponseWrap (global::Huawei.Hms.Common.Internal.ResponseHeader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/internal/ResponseHeader;)V";

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

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		static Delegate cb_setBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBody_Ljava_lang_String_Handler ()
		{
			if (cb_setBody_Ljava_lang_String_ == null)
				cb_setBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBody_Ljava_lang_String_);
			return cb_setBody_Ljava_lang_String_;
		}

		static void n_SetBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Body = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				const string __id = "getBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBody", "(Ljava/lang/String;)V", "GetSetBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBody.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseHeader;
#pragma warning disable 0169
		static Delegate GetGetResponseHeaderHandler ()
		{
			if (cb_getResponseHeader == null)
				cb_getResponseHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseHeader);
			return cb_getResponseHeader;
		}

		static IntPtr n_GetResponseHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHeader);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_;
#pragma warning disable 0169
		static Delegate GetSetResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_Handler ()
		{
			if (cb_setResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_ == null)
				cb_setResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_);
			return cb_setResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_;
		}

		static void n_SetResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseHeader = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Common.Internal.ResponseHeader ResponseHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='getResponseHeader' and count(parameter)=0]"
			[Register ("getResponseHeader", "()Lcom/huawei/hms/common/internal/ResponseHeader;", "GetGetResponseHeaderHandler")]
			get {
				const string __id = "getResponseHeader.()Lcom/huawei/hms/common/internal/ResponseHeader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='setResponseHeader' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.ResponseHeader']]"
			[Register ("setResponseHeader", "(Lcom/huawei/hms/common/internal/ResponseHeader;)V", "GetSetResponseHeader_Lcom_huawei_hms_common_internal_ResponseHeader_Handler")]
			set {
				const string __id = "setResponseHeader.(Lcom/huawei/hms/common/internal/ResponseHeader;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_ == null)
				cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_FromJson_Ljava_lang_String_);
			return cb_fromJson_Ljava_lang_String_;
		}

		static bool n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.FromJson (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Z", "GetFromJson_Ljava_lang_String_Handler")]
		public virtual unsafe bool FromJson (string p0)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseWrap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseWrap']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler")]
		public virtual unsafe string ToJson ()
		{
			const string __id = "toJson.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
