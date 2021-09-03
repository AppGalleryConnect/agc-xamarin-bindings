using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/entity/TokenResult", DoNotGenerateAcw=true)]
	public partial class TokenResult : global::Huawei.Hms.Support.Api.Client.Result {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/entity/TokenResult", typeof (TokenResult));
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

		protected TokenResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/constructor[@name='TokenResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenResult ()
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

		static Delegate cb_getBelongId;
#pragma warning disable 0169
		static Delegate GetGetBelongIdHandler ()
		{
			if (cb_getBelongId == null)
				cb_getBelongId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBelongId);
			return cb_getBelongId;
		}

		static IntPtr n_GetBelongId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BelongId);
		}
#pragma warning restore 0169

		static Delegate cb_setBelongId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBelongId_Ljava_lang_String_Handler ()
		{
			if (cb_setBelongId_Ljava_lang_String_ == null)
				cb_setBelongId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBelongId_Ljava_lang_String_);
			return cb_setBelongId_Ljava_lang_String_;
		}

		static void n_SetBelongId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BelongId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string BelongId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='getBelongId' and count(parameter)=0]"
			[Register ("getBelongId", "()Ljava/lang/String;", "GetGetBelongIdHandler")]
			get {
				const string __id = "getBelongId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='setBelongId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBelongId", "(Ljava/lang/String;)V", "GetSetBelongId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBelongId.(Ljava/lang/String;)V";
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

		static Delegate cb_getRetCode;
#pragma warning disable 0169
		static Delegate GetGetRetCodeHandler ()
		{
			if (cb_getRetCode == null)
				cb_getRetCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRetCode);
			return cb_getRetCode;
		}

		static int n_GetRetCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetCode;
		}
#pragma warning restore 0169

		static Delegate cb_setRetCode_I;
#pragma warning disable 0169
		static Delegate GetSetRetCode_IHandler ()
		{
			if (cb_setRetCode_I == null)
				cb_setRetCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRetCode_I);
			return cb_setRetCode_I;
		}

		static void n_SetRetCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RetCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='getRetCode' and count(parameter)=0]"
			[Register ("getRetCode", "()I", "GetGetRetCodeHandler")]
			get {
				const string __id = "getRetCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='setRetCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetCode", "(I)V", "GetSetRetCode_IHandler")]
			set {
				const string __id = "setRetCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenResult']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setToken.(Ljava/lang/String;)V";
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

	}
}
