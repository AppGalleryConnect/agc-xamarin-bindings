using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']"
	[global::Android.Runtime.Register ("com/huawei/hms/activity/ForegroundIntentBuilder", DoNotGenerateAcw=true)]
	public partial class ForegroundIntentBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/ForegroundIntentBuilder", typeof (ForegroundIntentBuilder));
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

		protected ForegroundIntentBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/constructor[@name='ForegroundIntentBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe ForegroundIntentBuilder (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Landroid/content/Intent;", "GetBuildHandler")]
		public virtual unsafe global::Android.Content.Intent Build ()
		{
			const string __id = "build.()Landroid/content/Intent;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='registerResponseCallback' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.activity.internal.BusResponseCallback']]"
		[Register ("registerResponseCallback", "(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)V", "")]
		public static unsafe void RegisterResponseCallback (string p0, global::Huawei.Hms.Activity.Internal.IBusResponseCallback p1)
		{
			const string __id = "registerResponseCallback.(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_setAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAction_Ljava_lang_String_Handler ()
		{
			if (cb_setAction_Ljava_lang_String_ == null)
				cb_setAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAction_Ljava_lang_String_);
			return cb_setAction_Ljava_lang_String_;
		}

		static IntPtr n_SetAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAction (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAction", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetAction_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetAction (string p0)
		{
			const string __id = "setAction.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setApiLevel_I;
#pragma warning disable 0169
		static Delegate GetSetApiLevel_IHandler ()
		{
			if (cb_setApiLevel_I == null)
				cb_setApiLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetApiLevel_I);
			return cb_setApiLevel_I;
		}

		static IntPtr n_SetApiLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetApiLevel (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setApiLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setApiLevel", "(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetApiLevel_IHandler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetApiLevel (int p0)
		{
			const string __id = "setApiLevel.(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setKitSdkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetKitSdkVersion_IHandler ()
		{
			if (cb_setKitSdkVersion_I == null)
				cb_setKitSdkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetKitSdkVersion_I);
			return cb_setKitSdkVersion_I;
		}

		static IntPtr n_SetKitSdkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetKitSdkVersion (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setKitSdkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKitSdkVersion", "(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetKitSdkVersion_IHandler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetKitSdkVersion (int p0)
		{
			const string __id = "setKitSdkVersion.(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMinApkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetMinApkVersion_IHandler ()
		{
			if (cb_setMinApkVersion_I == null)
				cb_setMinApkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetMinApkVersion_I);
			return cb_setMinApkVersion_I;
		}

		static IntPtr n_SetMinApkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMinApkVersion (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setMinApkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinApkVersion", "(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetMinApkVersion_IHandler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetMinApkVersion (int p0)
		{
			const string __id = "setMinApkVersion.(I)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRequestBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestBody_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestBody_Ljava_lang_String_ == null)
				cb_setRequestBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetRequestBody_Ljava_lang_String_);
			return cb_setRequestBody_Ljava_lang_String_;
		}

		static IntPtr n_SetRequestBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setRequestBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRequestBody", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetRequestBody_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetRequestBody (string p0)
		{
			const string __id = "setRequestBody.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setResponseCallback_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseCallback_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseCallback_Ljava_lang_String_ == null)
				cb_setResponseCallback_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetResponseCallback_Ljava_lang_String_);
			return cb_setResponseCallback_Ljava_lang_String_;
		}

		static IntPtr n_SetResponseCallback_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponseCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setResponseCallback' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResponseCallback", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetResponseCallback_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetResponseCallback (string p0)
		{
			const string __id = "setResponseCallback.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_;
#pragma warning disable 0169
		static Delegate GetSetResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_Handler ()
		{
			if (cb_setResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ == null)
				cb_setResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SetResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_);
			return cb_setResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_;
		}

		static IntPtr n_SetResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Activity.Internal.IBusResponseCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.IBusResponseCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponseCallback (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setResponseCallback' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.activity.internal.BusResponseCallback']]"
		[Register ("setResponseCallback", "(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetResponseCallback_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetResponseCallback (string p0, global::Huawei.Hms.Activity.Internal.IBusResponseCallback p1)
		{
			const string __id = "setResponseCallback.(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_setServiceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceName_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceName_Ljava_lang_String_ == null)
				cb_setServiceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetServiceName_Ljava_lang_String_);
			return cb_setServiceName_Ljava_lang_String_;
		}

		static IntPtr n_SetServiceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetServiceName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServiceName", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetServiceName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetServiceName (string p0)
		{
			const string __id = "setServiceName.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSubAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubAppId_Ljava_lang_String_ == null)
				cb_setSubAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSubAppId_Ljava_lang_String_);
			return cb_setSubAppId_Ljava_lang_String_;
		}

		static IntPtr n_SetSubAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSubAppId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setSubAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSubAppId", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetSubAppId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetSubAppId (string p0)
		{
			const string __id = "setSubAppId.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static IntPtr n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTransactionId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTransactionId", "(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;", "GetSetTransactionId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.ForegroundIntentBuilder SetTransactionId (string p0)
		{
			const string __id = "setTransactionId.(Ljava/lang/String;)Lcom/huawei/hms/activity/ForegroundIntentBuilder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.ForegroundIntentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='ForegroundIntentBuilder']/method[@name='unregisterResponseCallback' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterResponseCallback", "(Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterResponseCallback (string p0)
		{
			const string __id = "unregisterResponseCallback.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
