using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/BindingFailedResolution", DoNotGenerateAcw=true)]
	public partial class BindingFailedResolution : global::Java.Lang.Object, global::Android.Content.IServiceConnection, global::Huawei.Hms.Activity.IBridgeActivityDelegate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/BindingFailedResolution", typeof (BindingFailedResolution));
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

		protected BindingFailedResolution (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/constructor[@name='BindingFailedResolution' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BindingFailedResolution ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='getActivity' and count(parameter)=0]"
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

		static Delegate cb_getRequestCode;
#pragma warning disable 0169
		static Delegate GetGetRequestCodeHandler ()
		{
			if (cb_getRequestCode == null)
				cb_getRequestCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRequestCode);
			return cb_getRequestCode;
		}

		static int n_GetRequestCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestCode;
		}
#pragma warning restore 0169

		public virtual unsafe int RequestCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='getRequestCode' and count(parameter)=0]"
			[Register ("getRequestCode", "()I", "GetGetRequestCodeHandler")]
			get {
				const string __id = "getRequestCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onBridgeActivityCreate_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnBridgeActivityCreate_Landroid_app_Activity_Handler ()
		{
			if (cb_onBridgeActivityCreate_Landroid_app_Activity_ == null)
				cb_onBridgeActivityCreate_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBridgeActivityCreate_Landroid_app_Activity_);
			return cb_onBridgeActivityCreate_Landroid_app_Activity_;
		}

		static void n_OnBridgeActivityCreate_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onBridgeActivityCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onBridgeActivityCreate", "(Landroid/app/Activity;)V", "GetOnBridgeActivityCreate_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnBridgeActivityCreate (global::Android.App.Activity p0)
		{
			const string __id = "onBridgeActivityCreate.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onBridgeActivityDestroy;
#pragma warning disable 0169
		static Delegate GetOnBridgeActivityDestroyHandler ()
		{
			if (cb_onBridgeActivityDestroy == null)
				cb_onBridgeActivityDestroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBridgeActivityDestroy);
			return cb_onBridgeActivityDestroy;
		}

		static void n_OnBridgeActivityDestroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onBridgeActivityDestroy' and count(parameter)=0]"
		[Register ("onBridgeActivityDestroy", "()V", "GetOnBridgeActivityDestroyHandler")]
		public virtual unsafe void OnBridgeActivityDestroy ()
		{
			const string __id = "onBridgeActivityDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBridgeActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBridgeActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onBridgeActivityResult_IILandroid_content_Intent_ == null)
				cb_onBridgeActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_Z) n_OnBridgeActivityResult_IILandroid_content_Intent_);
			return cb_onBridgeActivityResult_IILandroid_content_Intent_;
		}

		static bool n_OnBridgeActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnBridgeActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onBridgeActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onBridgeActivityResult", "(IILandroid/content/Intent;)Z", "GetOnBridgeActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe bool OnBridgeActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			const string __id = "onBridgeActivityResult.(IILandroid/content/Intent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onBridgeConfigurationChanged;
#pragma warning disable 0169
		static Delegate GetOnBridgeConfigurationChangedHandler ()
		{
			if (cb_onBridgeConfigurationChanged == null)
				cb_onBridgeConfigurationChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnBridgeConfigurationChanged);
			return cb_onBridgeConfigurationChanged;
		}

		static void n_OnBridgeConfigurationChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeConfigurationChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onBridgeConfigurationChanged' and count(parameter)=0]"
		[Register ("onBridgeConfigurationChanged", "()V", "GetOnBridgeConfigurationChangedHandler")]
		public virtual unsafe void OnBridgeConfigurationChanged ()
		{
			const string __id = "onBridgeConfigurationChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
				cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnKeyUp_ILandroid_view_KeyEvent_);
			return cb_onKeyUp_ILandroid_view_KeyEvent_;
		}

		static void n_OnKeyUp_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyUp (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyUp", "(ILandroid/view/KeyEvent;)V", "GetOnKeyUp_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe void OnKeyUp (int p0, global::Android.Views.KeyEvent p1)
		{
			const string __id = "onKeyUp.(ILandroid/view/KeyEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName p0)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onStartResult_Z;
#pragma warning disable 0169
		static Delegate GetOnStartResult_ZHandler ()
		{
			if (cb_onStartResult_Z == null)
				cb_onStartResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnStartResult_Z);
			return cb_onStartResult_Z;
		}

		static void n_OnStartResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.BindingFailedResolution> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStartResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='BindingFailedResolution']/method[@name='onStartResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onStartResult", "(Z)V", "GetOnStartResult_ZHandler")]
		protected virtual unsafe void OnStartResult (bool p0)
		{
			const string __id = "onStartResult.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
