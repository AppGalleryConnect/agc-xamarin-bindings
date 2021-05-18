using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/ui/UpdateAdapter", DoNotGenerateAcw=true)]
	public partial class UpdateAdapter : global::Java.Lang.Object, global::Huawei.Hms.Activity.IBridgeActivityDelegate, global::Huawei.Hms.Update.Manager.PackageNameManager.IQueryPublishCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/ui/UpdateAdapter", typeof (UpdateAdapter));
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

		protected UpdateAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/constructor[@name='UpdateAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UpdateAdapter ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestCode;
		}
#pragma warning restore 0169

		public virtual unsafe int RequestCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='getRequestCode' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;I)Z", "")]
		public unsafe bool A (global::Android.Content.Context p0, string p1, int p2)
		{
			const string __id = "a.(Landroid/content/Context;Ljava/lang/String;I)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Landroid/app/Activity;", "")]
		public unsafe global::Android.App.Activity B ()
		{
			const string __id = "b.()Landroid/app/Activity;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public unsafe void D ()
		{
			const string __id = "d.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public unsafe void E ()
		{
			const string __id = "e.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onBridgeActivityCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onBridgeActivityDestroy' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnBridgeActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onBridgeActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeConfigurationChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onBridgeConfigurationChanged' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyUp (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
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

		static Delegate cb_onQueryResult;
#pragma warning disable 0169
		static Delegate GetOnQueryResultHandler ()
		{
			if (cb_onQueryResult == null)
				cb_onQueryResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnQueryResult);
			return cb_onQueryResult;
		}

		static void n_OnQueryResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Ui.UpdateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnQueryResult ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.ui']/class[@name='UpdateAdapter']/method[@name='onQueryResult' and count(parameter)=0]"
		[Register ("onQueryResult", "()V", "GetOnQueryResultHandler")]
		public virtual unsafe void OnQueryResult ()
		{
			const string __id = "onQueryResult.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
