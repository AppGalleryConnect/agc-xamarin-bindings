using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ClientSettings", DoNotGenerateAcw=true)]
	public partial class ClientSettings : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ClientSettings", typeof (ClientSettings));
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

		protected ClientSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/constructor[@name='ClientSettings' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe ClientSettings (string p0, string p1, global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> p2, string p3, global::System.Collections.Generic.IList<string> p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/constructor[@name='ClientSettings' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[6][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/util/List;Lcom/huawei/hms/support/api/client/SubAppInfo;)V", "")]
		public unsafe ClientSettings (string p0, string p1, global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> p2, string p3, global::System.Collections.Generic.IList<string> p4, global::Huawei.Hms.Support.Api.Client.SubAppInfo p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/util/List;Lcom/huawei/hms/support/api/client/SubAppInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

		static Delegate cb_getApiName;
#pragma warning disable 0169
		static Delegate GetGetApiNameHandler ()
		{
			if (cb_getApiName == null)
				cb_getApiName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiName);
			return cb_getApiName;
		}

		static IntPtr n_GetApiName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ApiName);
		}
#pragma warning restore 0169

		static Delegate cb_setApiName_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetApiName_Ljava_util_List_Handler ()
		{
			if (cb_setApiName_Ljava_util_List_ == null)
				cb_setApiName_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetApiName_Ljava_util_List_);
			return cb_setApiName_Ljava_util_List_;
		}

		static void n_SetApiName_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getApiName' and count(parameter)=0]"
			[Register ("getApiName", "()Ljava/util/List;", "GetGetApiNameHandler")]
			get {
				const string __id = "getApiName.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setApiName' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setApiName", "(Ljava/util/List;)V", "GetSetApiName_Ljava_util_List_Handler")]
			set {
				const string __id = "setApiName.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getAppID;
#pragma warning disable 0169
		static Delegate GetGetAppIDHandler ()
		{
			if (cb_getAppID == null)
				cb_getAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppID);
			return cb_getAppID;
		}

		static IntPtr n_GetAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		static Delegate cb_setAppID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppID_Ljava_lang_String_Handler ()
		{
			if (cb_setAppID_Ljava_lang_String_ == null)
				cb_setAppID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppID_Ljava_lang_String_);
			return cb_setAppID_Ljava_lang_String_;
		}

		static void n_SetAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppID", "(Ljava/lang/String;)V", "GetSetAppID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppID.(Ljava/lang/String;)V";
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

		static Delegate cb_getClientClassName;
#pragma warning disable 0169
		static Delegate GetGetClientClassNameHandler ()
		{
			if (cb_getClientClassName == null)
				cb_getClientClassName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientClassName);
			return cb_getClientClassName;
		}

		static IntPtr n_GetClientClassName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientClassName);
		}
#pragma warning restore 0169

		static Delegate cb_setClientClassName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientClassName_Ljava_lang_String_Handler ()
		{
			if (cb_setClientClassName_Ljava_lang_String_ == null)
				cb_setClientClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientClassName_Ljava_lang_String_);
			return cb_setClientClassName_Ljava_lang_String_;
		}

		static void n_SetClientClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientClassName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getClientClassName' and count(parameter)=0]"
			[Register ("getClientClassName", "()Ljava/lang/String;", "GetGetClientClassNameHandler")]
			get {
				const string __id = "getClientClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setClientClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientClassName", "(Ljava/lang/String;)V", "GetSetClientClassName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientClassName.(Ljava/lang/String;)V";
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

		static Delegate cb_getClientPackageName;
#pragma warning disable 0169
		static Delegate GetGetClientPackageNameHandler ()
		{
			if (cb_getClientPackageName == null)
				cb_getClientPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientPackageName);
			return cb_getClientPackageName;
		}

		static IntPtr n_GetClientPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientPackageName);
		}
#pragma warning restore 0169

		static Delegate cb_setClientPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setClientPackageName_Ljava_lang_String_ == null)
				cb_setClientPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientPackageName_Ljava_lang_String_);
			return cb_setClientPackageName_Ljava_lang_String_;
		}

		static void n_SetClientPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientPackageName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getClientPackageName' and count(parameter)=0]"
			[Register ("getClientPackageName", "()Ljava/lang/String;", "GetGetClientPackageNameHandler")]
			get {
				const string __id = "getClientPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setClientPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientPackageName", "(Ljava/lang/String;)V", "GetSetClientPackageName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientPackageName.(Ljava/lang/String;)V";
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

		static Delegate cb_getCpActivity;
#pragma warning disable 0169
		static Delegate GetGetCpActivityHandler ()
		{
			if (cb_getCpActivity == null)
				cb_getCpActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCpActivity);
			return cb_getCpActivity;
		}

		static IntPtr n_GetCpActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CpActivity);
		}
#pragma warning restore 0169

		static Delegate cb_setCpActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetCpActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setCpActivity_Landroid_app_Activity_ == null)
				cb_setCpActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCpActivity_Landroid_app_Activity_);
			return cb_setCpActivity_Landroid_app_Activity_;
		}

		static void n_SetCpActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CpActivity = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity CpActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getCpActivity' and count(parameter)=0]"
			[Register ("getCpActivity", "()Landroid/app/Activity;", "GetGetCpActivityHandler")]
			get {
				const string __id = "getCpActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setCpActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("setCpActivity", "(Landroid/app/Activity;)V", "GetSetCpActivity_Landroid_app_Activity_Handler")]
			set {
				const string __id = "setCpActivity.(Landroid/app/Activity;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getCpID;
#pragma warning disable 0169
		static Delegate GetGetCpIDHandler ()
		{
			if (cb_getCpID == null)
				cb_getCpID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCpID);
			return cb_getCpID;
		}

		static IntPtr n_GetCpID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CpID);
		}
#pragma warning restore 0169

		static Delegate cb_setCpID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCpID_Ljava_lang_String_Handler ()
		{
			if (cb_setCpID_Ljava_lang_String_ == null)
				cb_setCpID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCpID_Ljava_lang_String_);
			return cb_setCpID_Ljava_lang_String_;
		}

		static void n_SetCpID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CpID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CpID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getCpID' and count(parameter)=0]"
			[Register ("getCpID", "()Ljava/lang/String;", "GetGetCpIDHandler")]
			get {
				const string __id = "getCpID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setCpID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCpID", "(Ljava/lang/String;)V", "GetSetCpID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCpID.(Ljava/lang/String;)V";
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

		static Delegate cb_getInnerHmsPkg;
#pragma warning disable 0169
		static Delegate GetGetInnerHmsPkgHandler ()
		{
			if (cb_getInnerHmsPkg == null)
				cb_getInnerHmsPkg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInnerHmsPkg);
			return cb_getInnerHmsPkg;
		}

		static IntPtr n_GetInnerHmsPkg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InnerHmsPkg);
		}
#pragma warning restore 0169

		static Delegate cb_setInnerHmsPkg_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInnerHmsPkg_Ljava_lang_String_Handler ()
		{
			if (cb_setInnerHmsPkg_Ljava_lang_String_ == null)
				cb_setInnerHmsPkg_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInnerHmsPkg_Ljava_lang_String_);
			return cb_setInnerHmsPkg_Ljava_lang_String_;
		}

		static void n_SetInnerHmsPkg_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InnerHmsPkg = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string InnerHmsPkg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getInnerHmsPkg' and count(parameter)=0]"
			[Register ("getInnerHmsPkg", "()Ljava/lang/String;", "GetGetInnerHmsPkgHandler")]
			get {
				const string __id = "getInnerHmsPkg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setInnerHmsPkg' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInnerHmsPkg", "(Ljava/lang/String;)V", "GetSetInnerHmsPkg_Ljava_lang_String_Handler")]
			set {
				const string __id = "setInnerHmsPkg.(Ljava/lang/String;)V";
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

		static Delegate cb_isHasActivity;
#pragma warning disable 0169
		static Delegate GetIsHasActivityHandler ()
		{
			if (cb_isHasActivity == null)
				cb_isHasActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHasActivity);
			return cb_isHasActivity;
		}

		static bool n_IsHasActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHasActivity;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHasActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='isHasActivity' and count(parameter)=0]"
			[Register ("isHasActivity", "()Z", "GetIsHasActivityHandler")]
			get {
				const string __id = "isHasActivity.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		static Delegate cb_setScopes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetScopes_Ljava_util_List_Handler ()
		{
			if (cb_setScopes_Ljava_util_List_ == null)
				cb_setScopes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScopes_Ljava_util_List_);
			return cb_setScopes_Ljava_util_List_;
		}

		static void n_SetScopes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scopes = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setScopes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;']]"
			[Register ("setScopes", "(Ljava/util/List;)V", "GetSetScopes_Ljava_util_List_Handler")]
			set {
				const string __id = "setScopes.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSubAppID;
#pragma warning disable 0169
		static Delegate GetGetSubAppIDHandler ()
		{
			if (cb_getSubAppID == null)
				cb_getSubAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubAppID);
			return cb_getSubAppID;
		}

		static IntPtr n_GetSubAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubAppID);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Support.Api.Client.SubAppInfo SubAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='getSubAppID' and count(parameter)=0]"
			[Register ("getSubAppID", "()Lcom/huawei/hms/support/api/client/SubAppInfo;", "GetGetSubAppIDHandler")]
			get {
				const string __id = "getSubAppID.()Lcom/huawei/hms/support/api/client/SubAppInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_;
#pragma warning disable 0169
		static Delegate GetSetSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler ()
		{
			if (cb_setSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_ == null)
				cb_setSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_);
			return cb_setSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_;
		}

		static void n_SetSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubAppId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ClientSettings']/method[@name='setSubAppId' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register ("setSubAppId", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)V", "GetSetSubAppId_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler")]
		public virtual unsafe void SetSubAppId (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0)
		{
			const string __id = "setSubAppId.(Lcom/huawei/hms/support/api/client/SubAppInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
