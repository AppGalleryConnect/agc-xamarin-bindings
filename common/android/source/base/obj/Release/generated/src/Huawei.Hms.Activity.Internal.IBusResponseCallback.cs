using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.activity.internal']/interface[@name='BusResponseCallback']"
	[Register ("com/huawei/hms/activity/internal/BusResponseCallback", "", "Huawei.Hms.Activity.Internal.IBusResponseCallbackInvoker")]
	public partial interface IBusResponseCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/interface[@name='BusResponseCallback']/method[@name='innerError' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("innerError", "(Landroid/app/Activity;ILjava/lang/String;)Lcom/huawei/hms/activity/internal/BusResponseResult;", "GetInnerError_Landroid_app_Activity_ILjava_lang_String_Handler:Huawei.Hms.Activity.Internal.IBusResponseCallbackInvoker, Huawei.Hms.Base")]
		global::Huawei.Hms.Activity.Internal.BusResponseResult InnerError (global::Android.App.Activity p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/interface[@name='BusResponseCallback']/method[@name='succeedReturn' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("succeedReturn", "(Landroid/app/Activity;ILandroid/content/Intent;)Lcom/huawei/hms/activity/internal/BusResponseResult;", "GetSucceedReturn_Landroid_app_Activity_ILandroid_content_Intent_Handler:Huawei.Hms.Activity.Internal.IBusResponseCallbackInvoker, Huawei.Hms.Base")]
		global::Huawei.Hms.Activity.Internal.BusResponseResult SucceedReturn (global::Android.App.Activity p0, int p1, global::Android.Content.Intent p2);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/activity/internal/BusResponseCallback", DoNotGenerateAcw=true)]
	internal partial class IBusResponseCallbackInvoker : global::Java.Lang.Object, IBusResponseCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/internal/BusResponseCallback", typeof (IBusResponseCallbackInvoker));

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

		public static IBusResponseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBusResponseCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.activity.internal.BusResponseCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBusResponseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_innerError_Landroid_app_Activity_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInnerError_Landroid_app_Activity_ILjava_lang_String_Handler ()
		{
			if (cb_innerError_Landroid_app_Activity_ILjava_lang_String_ == null)
				cb_innerError_Landroid_app_Activity_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_L) n_InnerError_Landroid_app_Activity_ILjava_lang_String_);
			return cb_innerError_Landroid_app_Activity_ILjava_lang_String_;
		}

		static IntPtr n_InnerError_Landroid_app_Activity_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.IBusResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InnerError (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_innerError_Landroid_app_Activity_ILjava_lang_String_;
		public unsafe global::Huawei.Hms.Activity.Internal.BusResponseResult InnerError (global::Android.App.Activity p0, int p1, string p2)
		{
			if (id_innerError_Landroid_app_Activity_ILjava_lang_String_ == IntPtr.Zero)
				id_innerError_Landroid_app_Activity_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "innerError", "(Landroid/app/Activity;ILjava/lang/String;)Lcom/huawei/hms/activity/internal/BusResponseResult;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.BusResponseResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_innerError_Landroid_app_Activity_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSucceedReturn_Landroid_app_Activity_ILandroid_content_Intent_Handler ()
		{
			if (cb_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_ == null)
				cb_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_L) n_SucceedReturn_Landroid_app_Activity_ILandroid_content_Intent_);
			return cb_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_;
		}

		static IntPtr n_SucceedReturn_Landroid_app_Activity_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.IBusResponseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SucceedReturn (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_;
		public unsafe global::Huawei.Hms.Activity.Internal.BusResponseResult SucceedReturn (global::Android.App.Activity p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_ == IntPtr.Zero)
				id_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "succeedReturn", "(Landroid/app/Activity;ILandroid/content/Intent;)Lcom/huawei/hms/activity/internal/BusResponseResult;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.BusResponseResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_succeedReturn_Landroid_app_Activity_ILandroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
