using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Sysobs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemObserver']"
	[Register ("com/huawei/hms/adapter/sysobs/SystemObserver", "", "Huawei.Hms.Adapter.Sysobs.ISystemObserverInvoker")]
	public partial interface ISystemObserver : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemObserver']/method[@name='onSolutionResult' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSolutionResult", "(Landroid/content/Intent;Ljava/lang/String;)Z", "GetOnSolutionResult_Landroid_content_Intent_Ljava_lang_String_Handler:Huawei.Hms.Adapter.Sysobs.ISystemObserverInvoker, Huawei.Hms.Availableupdate")]
		bool OnSolutionResult (global::Android.Content.Intent p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemObserver']/method[@name='onUpdateResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUpdateResult", "(I)Z", "GetOnUpdateResult_IHandler:Huawei.Hms.Adapter.Sysobs.ISystemObserverInvoker, Huawei.Hms.Availableupdate")]
		bool OnUpdateResult (int p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/adapter/sysobs/SystemObserver", DoNotGenerateAcw=true)]
	internal partial class ISystemObserverInvoker : global::Java.Lang.Object, ISystemObserver {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/sysobs/SystemObserver", typeof (ISystemObserverInvoker));

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

		public static ISystemObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISystemObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.adapter.sysobs.SystemObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISystemObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSolutionResult_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_OnSolutionResult_Landroid_content_Intent_Ljava_lang_String_);
			return cb_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_;
		}

		static bool n_OnSolutionResult_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSolutionResult (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_;
		public unsafe bool OnSolutionResult (global::Android.Content.Intent p0, string p1)
		{
			if (id_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSolutionResult", "(Landroid/content/Intent;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSolutionResult_Landroid_content_Intent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_onUpdateResult_I;
#pragma warning disable 0169
		static Delegate GetOnUpdateResult_IHandler ()
		{
			if (cb_onUpdateResult_I == null)
				cb_onUpdateResult_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_OnUpdateResult_I);
			return cb_onUpdateResult_I;
		}

		static bool n_OnUpdateResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnUpdateResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateResult_I;
		public unsafe bool OnUpdateResult (int p0)
		{
			if (id_onUpdateResult_I == IntPtr.Zero)
				id_onUpdateResult_I = JNIEnv.GetMethodID (class_ref, "onUpdateResult", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateResult_I, __args);
		}

	}

}
