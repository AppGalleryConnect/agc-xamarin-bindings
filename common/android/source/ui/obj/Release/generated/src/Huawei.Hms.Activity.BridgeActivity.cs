using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']"
	[global::Android.Runtime.Register ("com/huawei/hms/activity/BridgeActivity", DoNotGenerateAcw=true)]
	public partial class BridgeActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/field[@name='EXTRA_DELEGATE_CLASS_NAME']"
		[Register ("EXTRA_DELEGATE_CLASS_NAME")]
		public const string ExtraDelegateClassName = (string) "intent.extra.DELEGATE_CLASS_OBJECT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/field[@name='EXTRA_DELEGATE_UPDATE_INFO']"
		[Register ("EXTRA_DELEGATE_UPDATE_INFO")]
		public const string ExtraDelegateUpdateInfo = (string) "intent.extra.update.info";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/field[@name='EXTRA_INTENT']"
		[Register ("EXTRA_INTENT")]
		public const string ExtraIntent = (string) "intent.extra.intent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/field[@name='EXTRA_IS_FULLSCREEN']"
		[Register ("EXTRA_IS_FULLSCREEN")]
		public const string ExtraIsFullscreen = (string) "intent.extra.isfullscreen";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/field[@name='EXTRA_RESULT']"
		[Register ("EXTRA_RESULT")]
		public const string ExtraResult = (string) "intent.extra.RESULT";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/BridgeActivity", typeof (BridgeActivity));
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

		protected BridgeActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/constructor[@name='BridgeActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BridgeActivity ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.view.Window'] and parameter[2][@type='boolean']]"
		[Register ("a", "(Landroid/view/Window;Z)V", "")]
		public static unsafe void A (global::Android.Views.Window p0, bool p1)
		{
			const string __id = "a.(Landroid/view/Window;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("a", "(Ljava/lang/String;I)I", "")]
		public static unsafe int A (string p0, int p1)
		{
			const string __id = "a.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public unsafe bool B ()
		{
			const string __id = "b.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='getIntentStartBridgeActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIntentStartBridgeActivity", "(Landroid/app/Activity;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetIntentStartBridgeActivity (global::Android.App.Activity p0, string p1)
		{
			const string __id = "getIntentStartBridgeActivity.(Landroid/app/Activity;Ljava/lang/String;)Landroid/content/Intent;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='getIntentStartBridgeActivity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIntentStartBridgeActivity", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetIntentStartBridgeActivity (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getIntentStartBridgeActivity.(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.BridgeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.App.Result) native_p1;
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result p1, global::Android.Content.Intent p2)
		{
			const string __id = "onActivityResult.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((int) p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.BridgeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.BridgeActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/class[@name='BridgeActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
