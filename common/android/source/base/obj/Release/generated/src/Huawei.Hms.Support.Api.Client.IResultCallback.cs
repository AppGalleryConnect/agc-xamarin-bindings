using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ResultCallback']"
	[Register ("com/huawei/hms/support/api/client/ResultCallback", "", "Huawei.Hms.Support.Api.Client.IResultCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IResultCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ResultCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onResult", "(Ljava/lang/Object;)V", "GetOnResult_Ljava_lang_Object_Handler:Huawei.Hms.Support.Api.Client.IResultCallbackInvoker, Huawei.Hms.Base")]
		void OnResult (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultCallback", DoNotGenerateAcw=true)]
	internal partial class IResultCallbackInvoker : global::Java.Lang.Object, IResultCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultCallback", typeof (IResultCallbackInvoker));

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

		public static IResultCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.client.ResultCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResult_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnResult_Ljava_lang_Object_Handler ()
		{
			if (cb_onResult_Ljava_lang_Object_ == null)
				cb_onResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Ljava_lang_Object_);
			return cb_onResult_Ljava_lang_Object_;
		}

		static void n_OnResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Ljava_lang_Object_;
		public unsafe void OnResult (global::Java.Lang.Object p0)
		{
			if (id_onResult_Ljava_lang_Object_ == IntPtr.Zero)
				id_onResult_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
