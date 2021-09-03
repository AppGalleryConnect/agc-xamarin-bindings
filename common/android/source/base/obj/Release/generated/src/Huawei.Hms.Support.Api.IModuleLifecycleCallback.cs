using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api']/interface[@name='ModuleLifecycleCallback']"
	[Register ("com/huawei/hms/support/api/ModuleLifecycleCallback", "", "Huawei.Hms.Support.Api.IModuleLifecycleCallbackInvoker")]
	public partial interface IModuleLifecycleCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/interface[@name='ModuleLifecycleCallback']/method[@name='onCreated' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onCreated", "(Landroid/content/Context;)V", "GetOnCreated_Landroid_content_Context_Handler:Huawei.Hms.Support.Api.IModuleLifecycleCallbackInvoker, Huawei.Hms.Base")]
		void OnCreated (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/interface[@name='ModuleLifecycleCallback']/method[@name='onDestroyed' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onDestroyed", "(Landroid/content/Context;)V", "GetOnDestroyed_Landroid_content_Context_Handler:Huawei.Hms.Support.Api.IModuleLifecycleCallbackInvoker, Huawei.Hms.Base")]
		void OnDestroyed (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/ModuleLifecycleCallback", DoNotGenerateAcw=true)]
	internal partial class IModuleLifecycleCallbackInvoker : global::Java.Lang.Object, IModuleLifecycleCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/ModuleLifecycleCallback", typeof (IModuleLifecycleCallbackInvoker));

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

		public static IModuleLifecycleCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModuleLifecycleCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.ModuleLifecycleCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModuleLifecycleCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreated_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnCreated_Landroid_content_Context_Handler ()
		{
			if (cb_onCreated_Landroid_content_Context_ == null)
				cb_onCreated_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCreated_Landroid_content_Context_);
			return cb_onCreated_Landroid_content_Context_;
		}

		static void n_OnCreated_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.IModuleLifecycleCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreated_Landroid_content_Context_;
		public unsafe void OnCreated (global::Android.Content.Context p0)
		{
			if (id_onCreated_Landroid_content_Context_ == IntPtr.Zero)
				id_onCreated_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onCreated", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreated_Landroid_content_Context_, __args);
		}

		static Delegate cb_onDestroyed_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnDestroyed_Landroid_content_Context_Handler ()
		{
			if (cb_onDestroyed_Landroid_content_Context_ == null)
				cb_onDestroyed_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDestroyed_Landroid_content_Context_);
			return cb_onDestroyed_Landroid_content_Context_;
		}

		static void n_OnDestroyed_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.IModuleLifecycleCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroyed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDestroyed_Landroid_content_Context_;
		public unsafe void OnDestroyed (global::Android.Content.Context p0)
		{
			if (id_onDestroyed_Landroid_content_Context_ == IntPtr.Zero)
				id_onDestroyed_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onDestroyed", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyed_Landroid_content_Context_, __args);
		}

	}

}
