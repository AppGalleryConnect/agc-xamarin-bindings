using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsConfig", DoNotGenerateAcw=true)]
	public partial class GrsConfig : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsConfig", typeof (GrsConfig));
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

		protected GrsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/constructor[@name='GrsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GrsConfig ()
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

		static Delegate cb_getAppName;
#pragma warning disable 0169
		static Delegate GetGetAppNameHandler ()
		{
			if (cb_getAppName == null)
				cb_getAppName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppName);
			return cb_getAppName;
		}

		static IntPtr n_GetAppName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		static Delegate cb_setAppName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppName_Ljava_lang_String_ == null)
				cb_setAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppName_Ljava_lang_String_);
			return cb_setAppName_Ljava_lang_String_;
		}

		static void n_SetAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				const string __id = "getAppName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppName", "(Ljava/lang/String;)V", "GetSetAppName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppName.(Ljava/lang/String;)V";
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

		static Delegate cb_getCountrySource;
#pragma warning disable 0169
		static Delegate GetGetCountrySourceHandler ()
		{
			if (cb_getCountrySource == null)
				cb_getCountrySource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCountrySource);
			return cb_getCountrySource;
		}

		static IntPtr n_GetCountrySource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountrySource);
		}
#pragma warning restore 0169

		static Delegate cb_setCountrySource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountrySource_Ljava_lang_String_Handler ()
		{
			if (cb_setCountrySource_Ljava_lang_String_ == null)
				cb_setCountrySource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCountrySource_Ljava_lang_String_);
			return cb_setCountrySource_Ljava_lang_String_;
		}

		static void n_SetCountrySource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountrySource = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CountrySource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getCountrySource' and count(parameter)=0]"
			[Register ("getCountrySource", "()Ljava/lang/String;", "GetGetCountrySourceHandler")]
			get {
				const string __id = "getCountrySource.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setCountrySource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountrySource", "(Ljava/lang/String;)V", "GetSetCountrySource_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCountrySource.(Ljava/lang/String;)V";
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

		static Delegate cb_getIssueCountry;
#pragma warning disable 0169
		static Delegate GetGetIssueCountryHandler ()
		{
			if (cb_getIssueCountry == null)
				cb_getIssueCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIssueCountry);
			return cb_getIssueCountry;
		}

		static IntPtr n_GetIssueCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IssueCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setIssueCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIssueCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setIssueCountry_Ljava_lang_String_ == null)
				cb_setIssueCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIssueCountry_Ljava_lang_String_);
			return cb_setIssueCountry_Ljava_lang_String_;
		}

		static void n_SetIssueCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IssueCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string IssueCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getIssueCountry' and count(parameter)=0]"
			[Register ("getIssueCountry", "()Ljava/lang/String;", "GetGetIssueCountryHandler")]
			get {
				const string __id = "getIssueCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setIssueCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIssueCountry", "(Ljava/lang/String;)V", "GetSetIssueCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIssueCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getRegCountry;
#pragma warning disable 0169
		static Delegate GetGetRegCountryHandler ()
		{
			if (cb_getRegCountry == null)
				cb_getRegCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRegCountry);
			return cb_getRegCountry;
		}

		static IntPtr n_GetRegCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setRegCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setRegCountry_Ljava_lang_String_ == null)
				cb_setRegCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRegCountry_Ljava_lang_String_);
			return cb_setRegCountry_Ljava_lang_String_;
		}

		static void n_SetRegCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string RegCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getRegCountry' and count(parameter)=0]"
			[Register ("getRegCountry", "()Ljava/lang/String;", "GetGetRegCountryHandler")]
			get {
				const string __id = "getRegCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setRegCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegCountry", "(Ljava/lang/String;)V", "GetSetRegCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRegCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getSerCountry;
#pragma warning disable 0169
		static Delegate GetGetSerCountryHandler ()
		{
			if (cb_getSerCountry == null)
				cb_getSerCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSerCountry);
			return cb_getSerCountry;
		}

		static IntPtr n_GetSerCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setSerCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSerCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setSerCountry_Ljava_lang_String_ == null)
				cb_setSerCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSerCountry_Ljava_lang_String_);
			return cb_setSerCountry_Ljava_lang_String_;
		}

		static void n_SetSerCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SerCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SerCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getSerCountry' and count(parameter)=0]"
			[Register ("getSerCountry", "()Ljava/lang/String;", "GetGetSerCountryHandler")]
			get {
				const string __id = "getSerCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setSerCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSerCountry", "(Ljava/lang/String;)V", "GetSetSerCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSerCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getVersionName;
#pragma warning disable 0169
		static Delegate GetGetVersionNameHandler ()
		{
			if (cb_getVersionName == null)
				cb_getVersionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersionName);
			return cb_getVersionName;
		}

		static IntPtr n_GetVersionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName);
		}
#pragma warning restore 0169

		static Delegate cb_setVersionName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersionName_Ljava_lang_String_Handler ()
		{
			if (cb_setVersionName_Ljava_lang_String_ == null)
				cb_setVersionName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVersionName_Ljava_lang_String_);
			return cb_setVersionName_Ljava_lang_String_;
		}

		static void n_SetVersionName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VersionName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string VersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getVersionName' and count(parameter)=0]"
			[Register ("getVersionName", "()Ljava/lang/String;", "GetGetVersionNameHandler")]
			get {
				const string __id = "getVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersionName", "(Ljava/lang/String;)V", "GetSetVersionName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVersionName.(Ljava/lang/String;)V";
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

		static Delegate cb_equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_;
#pragma warning disable 0169
		static Delegate GetEqual_Lcom_huawei_hms_framework_network_grs_GrsConfig_Handler ()
		{
			if (cb_equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_ == null)
				cb_equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_);
			return cb_equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_;
		}

		static bool n_Equal_Lcom_huawei_hms_framework_network_grs_GrsConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equal (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='equal' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.framework.network.grs.GrsConfig']]"
		[Register ("equal", "(Lcom/huawei/hms/framework/network/grs/GrsConfig;)Z", "GetEqual_Lcom_huawei_hms_framework_network_grs_GrsConfig_Handler")]
		public virtual unsafe bool Equal (global::Huawei.Hms.Framework.Network.Grs.GrsConfig p0)
		{
			const string __id = "equal.(Lcom/huawei/hms/framework/network/grs/GrsConfig;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getGrsBaseInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetGrsBaseInfo_Landroid_content_Context_Handler ()
		{
			if (cb_getGrsBaseInfo_Landroid_content_Context_ == null)
				cb_getGrsBaseInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetGrsBaseInfo_Landroid_content_Context_);
			return cb_getGrsBaseInfo_Landroid_content_Context_;
		}

		static IntPtr n_GetGrsBaseInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGrsBaseInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getGrsBaseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getGrsBaseInfo", "(Landroid/content/Context;)Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;", "GetGetGrsBaseInfo_Landroid_content_Context_Handler")]
		public virtual unsafe global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo GetGrsBaseInfo (global::Android.Content.Context p0)
		{
			const string __id = "getGrsBaseInfo.(Landroid/content/Context;)Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getuserId;
#pragma warning disable 0169
		static Delegate GetGetuserIdHandler ()
		{
			if (cb_getuserId == null)
				cb_getuserId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetuserId);
			return cb_getuserId;
		}

		static IntPtr n_GetuserId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetuserId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='getuserId' and count(parameter)=0]"
		[Register ("getuserId", "()Ljava/lang/String;", "GetGetuserIdHandler")]
		public virtual unsafe string GetuserId ()
		{
			const string __id = "getuserId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsConfig']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUserId (string p0)
		{
			const string __id = "setUserId.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
