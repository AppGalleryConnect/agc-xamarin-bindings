using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApp']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsApp", DoNotGenerateAcw=true)]
	public partial class GrsApp : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsApp", typeof (GrsApp));
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

		protected GrsApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAppConfigName;
#pragma warning disable 0169
		static Delegate GetGetAppConfigNameHandler ()
		{
			if (cb_getAppConfigName == null)
				cb_getAppConfigName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppConfigName);
			return cb_getAppConfigName;
		}

		static IntPtr n_GetAppConfigName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppConfigName);
		}
#pragma warning restore 0169

		static Delegate cb_setAppConfigName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppConfigName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppConfigName_Ljava_lang_String_ == null)
				cb_setAppConfigName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppConfigName_Ljava_lang_String_);
			return cb_setAppConfigName_Ljava_lang_String_;
		}

		static void n_SetAppConfigName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppConfigName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppConfigName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApp']/method[@name='getAppConfigName' and count(parameter)=0]"
			[Register ("getAppConfigName", "()Ljava/lang/String;", "GetGetAppConfigNameHandler")]
			get {
				const string __id = "getAppConfigName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApp']/method[@name='setAppConfigName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppConfigName", "(Ljava/lang/String;)V", "GetSetAppConfigName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppConfigName.(Ljava/lang/String;)V";
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

		public static unsafe global::Huawei.Hms.Framework.Network.Grs.GrsApp Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApp']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/framework/network/grs/GrsApp;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/framework/network/grs/GrsApp;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsApp> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIssueCountryCode_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetIssueCountryCode_Landroid_content_Context_Handler ()
		{
			if (cb_getIssueCountryCode_Landroid_content_Context_ == null)
				cb_getIssueCountryCode_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetIssueCountryCode_Landroid_content_Context_);
			return cb_getIssueCountryCode_Landroid_content_Context_;
		}

		static IntPtr n_GetIssueCountryCode_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIssueCountryCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApp']/method[@name='getIssueCountryCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIssueCountryCode", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIssueCountryCode_Landroid_content_Context_Handler")]
		public virtual unsafe string GetIssueCountryCode (global::Android.Content.Context p0)
		{
			const string __id = "getIssueCountryCode.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
