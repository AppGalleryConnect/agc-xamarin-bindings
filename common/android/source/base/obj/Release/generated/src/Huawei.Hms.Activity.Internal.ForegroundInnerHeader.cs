using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']"
	[global::Android.Runtime.Register ("com/huawei/hms/activity/internal/ForegroundInnerHeader", DoNotGenerateAcw=true)]
	public partial class ForegroundInnerHeader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/internal/ForegroundInnerHeader", typeof (ForegroundInnerHeader));
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

		protected ForegroundInnerHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/constructor[@name='ForegroundInnerHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ForegroundInnerHeader ()
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

		static Delegate cb_getAction;
#pragma warning disable 0169
		static Delegate GetGetActionHandler ()
		{
			if (cb_getAction == null)
				cb_getAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAction);
			return cb_getAction;
		}

		static IntPtr n_GetAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Action);
		}
#pragma warning restore 0169

		static Delegate cb_setAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAction_Ljava_lang_String_Handler ()
		{
			if (cb_setAction_Ljava_lang_String_ == null)
				cb_setAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAction_Ljava_lang_String_);
			return cb_setAction_Ljava_lang_String_;
		}

		static void n_SetAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Action = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Action {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='getAction' and count(parameter)=0]"
			[Register ("getAction", "()Ljava/lang/String;", "GetGetActionHandler")]
			get {
				const string __id = "getAction.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='setAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAction", "(Ljava/lang/String;)V", "GetSetAction_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAction.(Ljava/lang/String;)V";
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

		static Delegate cb_getApkVersion;
#pragma warning disable 0169
		static Delegate GetGetApkVersionHandler ()
		{
			if (cb_getApkVersion == null)
				cb_getApkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetApkVersion);
			return cb_getApkVersion;
		}

		static int n_GetApkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApkVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setApkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetApkVersion_IHandler ()
		{
			if (cb_setApkVersion_I == null)
				cb_setApkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetApkVersion_I);
			return cb_setApkVersion_I;
		}

		static void n_SetApkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ApkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='getApkVersion' and count(parameter)=0]"
			[Register ("getApkVersion", "()I", "GetGetApkVersionHandler")]
			get {
				const string __id = "getApkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='setApkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setApkVersion", "(I)V", "GetSetApkVersion_IHandler")]
			set {
				const string __id = "setApkVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseCallbackKey;
#pragma warning disable 0169
		static Delegate GetGetResponseCallbackKeyHandler ()
		{
			if (cb_getResponseCallbackKey == null)
				cb_getResponseCallbackKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResponseCallbackKey);
			return cb_getResponseCallbackKey;
		}

		static IntPtr n_GetResponseCallbackKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseCallbackKey);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseCallbackKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseCallbackKey_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseCallbackKey_Ljava_lang_String_ == null)
				cb_setResponseCallbackKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponseCallbackKey_Ljava_lang_String_);
			return cb_setResponseCallbackKey_Ljava_lang_String_;
		}

		static void n_SetResponseCallbackKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCallbackKey = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ResponseCallbackKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='getResponseCallbackKey' and count(parameter)=0]"
			[Register ("getResponseCallbackKey", "()Ljava/lang/String;", "GetGetResponseCallbackKeyHandler")]
			get {
				const string __id = "getResponseCallbackKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='setResponseCallbackKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseCallbackKey", "(Ljava/lang/String;)V", "GetSetResponseCallbackKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setResponseCallbackKey.(Ljava/lang/String;)V";
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

		static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_ == null)
				cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FromJson_Ljava_lang_String_);
			return cb_fromJson_Ljava_lang_String_;
		}

		static void n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FromJson (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)V", "GetFromJson_Ljava_lang_String_Handler")]
		public virtual unsafe void FromJson (string p0)
		{
			const string __id = "fromJson.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundInnerHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundInnerHeader']/method[@name='toJson' and count(parameter)=0]"
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
