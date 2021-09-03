using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']"
	[Register ("com/huawei/hms/activity/IBridgeActivityDelegate", "", "Huawei.Hms.Activity.IBridgeActivityDelegateInvoker")]
	public partial interface IBridgeActivityDelegate : IJavaObject, IJavaPeerable {

		int RequestCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='getRequestCode' and count(parameter)=0]"
			[Register ("getRequestCode", "()I", "GetGetRequestCodeHandler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='onBridgeActivityCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onBridgeActivityCreate", "(Landroid/app/Activity;)V", "GetOnBridgeActivityCreate_Landroid_app_Activity_Handler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")]
		void OnBridgeActivityCreate (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='onBridgeActivityDestroy' and count(parameter)=0]"
		[Register ("onBridgeActivityDestroy", "()V", "GetOnBridgeActivityDestroyHandler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")]
		void OnBridgeActivityDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='onBridgeActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onBridgeActivityResult", "(IILandroid/content/Intent;)Z", "GetOnBridgeActivityResult_IILandroid_content_Intent_Handler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")]
		bool OnBridgeActivityResult (int p0, int p1, global::Android.Content.Intent p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='onBridgeConfigurationChanged' and count(parameter)=0]"
		[Register ("onBridgeConfigurationChanged", "()V", "GetOnBridgeConfigurationChangedHandler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")]
		void OnBridgeConfigurationChanged ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity']/interface[@name='IBridgeActivityDelegate']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyUp", "(ILandroid/view/KeyEvent;)V", "GetOnKeyUp_ILandroid_view_KeyEvent_Handler:Huawei.Hms.Activity.IBridgeActivityDelegateInvoker, Huawei.Hms.Ui")]
		void OnKeyUp (int p0, global::Android.Views.KeyEvent p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/activity/IBridgeActivityDelegate", DoNotGenerateAcw=true)]
	internal partial class IBridgeActivityDelegateInvoker : global::Java.Lang.Object, IBridgeActivityDelegate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/IBridgeActivityDelegate", typeof (IBridgeActivityDelegateInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBridgeActivityDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBridgeActivityDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.activity.IBridgeActivityDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBridgeActivityDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestCode;
		}
#pragma warning restore 0169

		IntPtr id_getRequestCode;
		public unsafe int RequestCode {
			get {
				if (id_getRequestCode == IntPtr.Zero)
					id_getRequestCode = JNIEnv.GetMethodID (class_ref, "getRequestCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRequestCode);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBridgeActivityCreate_Landroid_app_Activity_;
		public unsafe void OnBridgeActivityCreate (global::Android.App.Activity p0)
		{
			if (id_onBridgeActivityCreate_Landroid_app_Activity_ == IntPtr.Zero)
				id_onBridgeActivityCreate_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onBridgeActivityCreate", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBridgeActivityCreate_Landroid_app_Activity_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeActivityDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onBridgeActivityDestroy;
		public unsafe void OnBridgeActivityDestroy ()
		{
			if (id_onBridgeActivityDestroy == IntPtr.Zero)
				id_onBridgeActivityDestroy = JNIEnv.GetMethodID (class_ref, "onBridgeActivityDestroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBridgeActivityDestroy);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnBridgeActivityResult (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onBridgeActivityResult_IILandroid_content_Intent_;
		public unsafe bool OnBridgeActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onBridgeActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onBridgeActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBridgeActivityResult", "(IILandroid/content/Intent;)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onBridgeActivityResult_IILandroid_content_Intent_, __args);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBridgeConfigurationChanged ();
		}
#pragma warning restore 0169

		IntPtr id_onBridgeConfigurationChanged;
		public unsafe void OnBridgeConfigurationChanged ()
		{
			if (id_onBridgeConfigurationChanged == IntPtr.Zero)
				id_onBridgeConfigurationChanged = JNIEnv.GetMethodID (class_ref, "onBridgeConfigurationChanged", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBridgeConfigurationChanged);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.IBridgeActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnKeyUp (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onKeyUp_ILandroid_view_KeyEvent_;
		public unsafe void OnKeyUp (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyUp_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyUp_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyUp", "(ILandroid/view/KeyEvent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyUp_ILandroid_view_KeyEvent_, __args);
		}

	}

}
