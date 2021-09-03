using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='Freezable']"
	[Register ("com/huawei/hms/common/data/Freezable", "", "Huawei.Hms.Common.Data.IFreezableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFreezable : IJavaObject, IJavaPeerable {

		bool IsDataValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='Freezable']/method[@name='isDataValid' and count(parameter)=0]"
			[Register ("isDataValid", "()Z", "GetIsDataValidHandler:Huawei.Hms.Common.Data.IFreezableInvoker, Huawei.Hms.Base")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='Freezable']/method[@name='freeze' and count(parameter)=0]"
		[Register ("freeze", "()Ljava/lang/Object;", "GetFreezeHandler:Huawei.Hms.Common.Data.IFreezableInvoker, Huawei.Hms.Base")]
		global::Java.Lang.Object Freeze ();

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/data/Freezable", DoNotGenerateAcw=true)]
	internal partial class IFreezableInvoker : global::Java.Lang.Object, IFreezable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/Freezable", typeof (IFreezableInvoker));

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

		public static IFreezable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFreezable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.data.Freezable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFreezableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isDataValid;
#pragma warning disable 0169
		static Delegate GetIsDataValidHandler ()
		{
			if (cb_isDataValid == null)
				cb_isDataValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDataValid);
			return cb_isDataValid;
		}

		static bool n_IsDataValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IFreezable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataValid;
		}
#pragma warning restore 0169

		IntPtr id_isDataValid;
		public unsafe bool IsDataValid {
			get {
				if (id_isDataValid == IntPtr.Zero)
					id_isDataValid = JNIEnv.GetMethodID (class_ref, "isDataValid", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDataValid);
			}
		}

		static Delegate cb_freeze;
#pragma warning disable 0169
		static Delegate GetFreezeHandler ()
		{
			if (cb_freeze == null)
				cb_freeze = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Freeze);
			return cb_freeze;
		}

		static IntPtr n_Freeze (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IFreezable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Freeze ());
		}
#pragma warning restore 0169

		IntPtr id_freeze;
		public unsafe global::Java.Lang.Object Freeze ()
		{
			if (id_freeze == IntPtr.Zero)
				id_freeze = JNIEnv.GetMethodID (class_ref, "freeze", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_freeze), JniHandleOwnership.TransferLocalRef);
		}

	}

}
