using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='CheckUpdatelistener']"
	[Register ("com/huawei/hms/api/CheckUpdatelistener", "", "Huawei.Hms.Api.ICheckUpdatelistenerInvoker")]
	public partial interface ICheckUpdatelistener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='CheckUpdatelistener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onResult", "(I)V", "GetOnResult_IHandler:Huawei.Hms.Api.ICheckUpdatelistenerInvoker, Huawei.Hms.Base")]
		void OnResult (int p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/api/CheckUpdatelistener", DoNotGenerateAcw=true)]
	internal partial class ICheckUpdatelistenerInvoker : global::Java.Lang.Object, ICheckUpdatelistener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/CheckUpdatelistener", typeof (ICheckUpdatelistenerInvoker));

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

		public static ICheckUpdatelistener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICheckUpdatelistener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.CheckUpdatelistener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICheckUpdatelistenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResult_I;
#pragma warning disable 0169
		static Delegate GetOnResult_IHandler ()
		{
			if (cb_onResult_I == null)
				cb_onResult_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnResult_I);
			return cb_onResult_I;
		}

		static void n_OnResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ICheckUpdatelistener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_I;
		public unsafe void OnResult (int p0)
		{
			if (id_onResult_I == IntPtr.Zero)
				id_onResult_I = JNIEnv.GetMethodID (class_ref, "onResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_I, __args);
		}

	}

}
