using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Opendevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.opendevice']/interface[@name='OpenDeviceClient']"
	[Register ("com/huawei/hms/opendevice/OpenDeviceClient", "", "Huawei.Hms.Opendevice.IOpenDeviceClientInvoker")]
	public partial interface IOpenDeviceClient : IJavaObject, IJavaPeerable {

		global::Huawei.Hmf.Tasks.Task Odid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/interface[@name='OpenDeviceClient']/method[@name='getOdid' and count(parameter)=0]"
			[Register ("getOdid", "()Lcom/huawei/hmf/tasks/Task;", "GetGetOdidHandler:Huawei.Hms.Opendevice.IOpenDeviceClientInvoker, Huawei.Hms.Opendevice")] get;
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/opendevice/OpenDeviceClient", DoNotGenerateAcw=true)]
	internal partial class IOpenDeviceClientInvoker : global::Java.Lang.Object, IOpenDeviceClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/opendevice/OpenDeviceClient", typeof (IOpenDeviceClientInvoker));

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

		public static IOpenDeviceClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOpenDeviceClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.opendevice.OpenDeviceClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOpenDeviceClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getOdid;
#pragma warning disable 0169
		static Delegate GetGetOdidHandler ()
		{
			if (cb_getOdid == null)
				cb_getOdid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOdid);
			return cb_getOdid;
		}

		static IntPtr n_GetOdid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.IOpenDeviceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Odid);
		}
#pragma warning restore 0169

		IntPtr id_getOdid;
		public unsafe global::Huawei.Hmf.Tasks.Task Odid {
			get {
				if (id_getOdid == IntPtr.Zero)
					id_getOdid = JNIEnv.GetMethodID (class_ref, "getOdid", "()Lcom/huawei/hmf/tasks/Task;");
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOdid), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
