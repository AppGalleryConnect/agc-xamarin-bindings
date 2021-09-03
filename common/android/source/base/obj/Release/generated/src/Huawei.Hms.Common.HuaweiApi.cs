using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/HuaweiApi", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TOption extends com.huawei.hms.api.Api.ApiOptions"})]
	public partial class HuaweiApi : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/HuaweiApi", typeof (HuaweiApi));
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

		protected HuaweiApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;)V", "")]
		public unsafe HuaweiApi (global::Android.App.Activity p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;I)V", "")]
		public unsafe HuaweiApi (global::Android.App.Activity p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;ILjava/lang/String;)V", "")]
		public unsafe HuaweiApi (global::Android.App.Activity p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3, int p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;)V", "")]
		public unsafe HuaweiApi (global::Android.Content.Context p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;I)V", "")]
		public unsafe HuaweiApi (global::Android.Content.Context p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/constructor[@name='HuaweiApi' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='com.huawei.hms.common.internal.AbstractClientBuilder'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;ILjava/lang/String;)V", "")]
		public unsafe HuaweiApi (global::Android.Content.Context p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, global::Huawei.Hms.Common.Internal.AbstractClientBuilder p3, int p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Lcom/huawei/hms/common/internal/AbstractClientBuilder;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApiLevel;
#pragma warning disable 0169
		static Delegate GetGetApiLevelHandler ()
		{
			if (cb_getApiLevel == null)
				cb_getApiLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetApiLevel);
			return cb_getApiLevel;
		}

		static int n_GetApiLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApiLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setApiLevel_I;
#pragma warning disable 0169
		static Delegate GetSetApiLevel_IHandler ()
		{
			if (cb_setApiLevel_I == null)
				cb_setApiLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetApiLevel_I);
			return cb_setApiLevel_I;
		}

		static void n_SetApiLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApiLevel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getApiLevel' and count(parameter)=0]"
			[Register ("getApiLevel", "()I", "GetGetApiLevelHandler")]
			get {
				const string __id = "getApiLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='setApiLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setApiLevel", "(I)V", "GetSetApiLevel_IHandler")]
			set {
				const string __id = "setApiLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientSetting;
#pragma warning disable 0169
		static Delegate GetGetClientSettingHandler ()
		{
			if (cb_getClientSetting == null)
				cb_getClientSetting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientSetting);
			return cb_getClientSetting;
		}

		static IntPtr n_GetClientSetting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientSetting);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Huawei.Hms.Common.Internal.ClientSettings ClientSetting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getClientSetting' and count(parameter)=0]"
			[Register ("getClientSetting", "()Lcom/huawei/hms/common/internal/ClientSettings;", "GetGetClientSettingHandler")]
			get {
				const string __id = "getClientSetting.()Lcom/huawei/hms/common/internal/ClientSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectionManagerKey;
#pragma warning disable 0169
		static Delegate GetGetConnectionManagerKeyHandler ()
		{
			if (cb_getConnectionManagerKey == null)
				cb_getConnectionManagerKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConnectionManagerKey);
			return cb_getConnectionManagerKey;
		}

		static IntPtr n_GetConnectionManagerKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionManagerKey);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Common.Internal.ConnectionManagerKey ConnectionManagerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getConnectionManagerKey' and count(parameter)=0]"
			[Register ("getConnectionManagerKey", "()Lcom/huawei/hms/common/internal/ConnectionManagerKey;", "GetGetConnectionManagerKeyHandler")]
			get {
				const string __id = "getConnectionManagerKey.()Lcom/huawei/hms/common/internal/ConnectionManagerKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ConnectionManagerKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKitSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetKitSdkVersionHandler ()
		{
			if (cb_getKitSdkVersion == null)
				cb_getKitSdkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetKitSdkVersion);
			return cb_getKitSdkVersion;
		}

		static int n_GetKitSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KitSdkVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setKitSdkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetKitSdkVersion_IHandler ()
		{
			if (cb_setKitSdkVersion_I == null)
				cb_setKitSdkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetKitSdkVersion_I);
			return cb_setKitSdkVersion_I;
		}

		static void n_SetKitSdkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KitSdkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int KitSdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getKitSdkVersion' and count(parameter)=0]"
			[Register ("getKitSdkVersion", "()I", "GetGetKitSdkVersionHandler")]
			get {
				const string __id = "getKitSdkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='setKitSdkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setKitSdkVersion", "(I)V", "GetSetKitSdkVersion_IHandler")]
			set {
				const string __id = "setKitSdkVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOption;
#pragma warning disable 0169
		static Delegate GetGetOptionHandler ()
		{
			if (cb_getOption == null)
				cb_getOption = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOption);
			return cb_getOption;
		}

		static IntPtr n_GetOption (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Option);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Option {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getOption' and count(parameter)=0]"
			[Register ("getOption", "()Lcom/huawei/hms/api/Api$ApiOptions;", "GetGetOptionHandler")]
			get {
				const string __id = "getOption.()Lcom/huawei/hms/api/Api$ApiOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		protected virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubAppID);
		}
#pragma warning restore 0169

		public virtual unsafe string SubAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getSubAppID' and count(parameter)=0]"
			[Register ("getSubAppID", "()Ljava/lang/String;", "GetGetSubAppIDHandler")]
			get {
				const string __id = "getSubAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disconnectService;
#pragma warning disable 0169
		static Delegate GetDisconnectServiceHandler ()
		{
			if (cb_disconnectService == null)
				cb_disconnectService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DisconnectService);
			return cb_disconnectService;
		}

		static IntPtr n_DisconnectService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisconnectService ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='disconnectService' and count(parameter)=0]"
		[Register ("disconnectService", "()Lcom/huawei/hmf/tasks/Task;", "GetDisconnectServiceHandler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task DisconnectService ()
		{
			const string __id = "disconnectService.()Lcom/huawei/hmf/tasks/Task;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_doWrite_Lcom_huawei_hms_common_internal_TaskApiCall_;
#pragma warning disable 0169
		static Delegate GetDoWrite_Lcom_huawei_hms_common_internal_TaskApiCall_Handler ()
		{
			if (cb_doWrite_Lcom_huawei_hms_common_internal_TaskApiCall_ == null)
				cb_doWrite_Lcom_huawei_hms_common_internal_TaskApiCall_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_DoWrite_Lcom_huawei_hms_common_internal_TaskApiCall_);
			return cb_doWrite_Lcom_huawei_hms_common_internal_TaskApiCall_;
		}

		static IntPtr n_DoWrite_Lcom_huawei_hms_common_internal_TaskApiCall_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoWrite (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='doWrite' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.TaskApiCall&lt;TClient, TResult&gt;']]"
		[Register ("doWrite", "(Lcom/huawei/hms/common/internal/TaskApiCall;)Lcom/huawei/hmf/tasks/Task;", "GetDoWrite_Lcom_huawei_hms_common_internal_TaskApiCall_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult", "TClient extends com.huawei.hms.common.internal.AnyClient"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task DoWrite (global::Huawei.Hms.Common.Internal.TaskApiCall p0)
		{
			const string __id = "doWrite.(Lcom/huawei/hms/common/internal/TaskApiCall;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_;
#pragma warning disable 0169
		static Delegate GetGetClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_Handler ()
		{
			if (cb_getClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_ == null)
				cb_getClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_);
			return cb_getClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_;
		}

		static IntPtr n_GetClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager.ConnectionManager> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClient (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='getClient' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.huawei.hms.common.internal.HuaweiApiManager.ConnectionManager']]"
		[Register ("getClient", "(Landroid/os/Looper;Lcom/huawei/hms/common/internal/HuaweiApiManager$ConnectionManager;)Lcom/huawei/hms/common/internal/AnyClient;", "GetGetClient_Landroid_os_Looper_Lcom_huawei_hms_common_internal_HuaweiApiManager_ConnectionManager_Handler")]
		public virtual unsafe global::Huawei.Hms.Common.Internal.IAnyClient GetClient (global::Android.OS.Looper p0, global::Huawei.Hms.Common.Internal.HuaweiApiManager.ConnectionManager p1)
		{
			const string __id = "getClient.(Landroid/os/Looper;Lcom/huawei/hms/common/internal/HuaweiApiManager$ConnectionManager;)Lcom/huawei/hms/common/internal/AnyClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_setInnerHms;
#pragma warning disable 0169
		static Delegate GetSetInnerHmsHandler ()
		{
			if (cb_setInnerHms == null)
				cb_setInnerHms = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetInnerHms);
			return cb_setInnerHms;
		}

		static void n_SetInnerHms (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInnerHms ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='setInnerHms' and count(parameter)=0]"
		[Register ("setInnerHms", "()V", "GetSetInnerHmsHandler")]
		public virtual unsafe void SetInnerHms ()
		{
			const string __id = "setInnerHms.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSubAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubAppId_Ljava_lang_String_ == null)
				cb_setSubAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubAppId_Ljava_lang_String_);
			return cb_setSubAppId_Ljava_lang_String_;
		}

		static void n_SetSubAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubAppId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='setSubAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSubAppId", "(Ljava/lang/String;)V", "GetSetSubAppId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSubAppId (string p0)
		{
			const string __id = "setSubAppId.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
#pragma warning disable 0169
		static Delegate GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler ()
		{
			if (cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ == null)
				cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_);
			return cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
		}

		static bool n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSubAppInfo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='HuaweiApi']/method[@name='setSubAppInfo' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register ("setSubAppInfo", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z", "GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler")]
		public virtual unsafe bool SetSubAppInfo (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0)
		{
			const string __id = "setSubAppInfo.(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
