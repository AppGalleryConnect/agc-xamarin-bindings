using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='Releasable']"
	[Register ("com/huawei/hms/common/api/Releasable", "", "Huawei.Hms.Common.Api.IReleasableInvoker")]
	public partial interface IReleasable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='Releasable']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Huawei.Hms.Common.Api.IReleasableInvoker, Huawei.Hms.Base")]
		void Release ();

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/api/Releasable", DoNotGenerateAcw=true)]
	internal partial class IReleasableInvoker : global::Java.Lang.Object, IReleasable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/Releasable", typeof (IReleasableInvoker));

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

		public static IReleasable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReleasable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.api.Releasable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReleasableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.IReleasable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

	}

}
