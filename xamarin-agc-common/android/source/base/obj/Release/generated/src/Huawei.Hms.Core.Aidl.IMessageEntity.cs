using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Core.Aidl {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.core.aidl']/interface[@name='IMessageEntity']"
	[Register ("com/huawei/hms/core/aidl/IMessageEntity", "", "Huawei.Hms.Core.Aidl.IMessageEntityInvoker")]
	public partial interface IMessageEntity : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/huawei/hms/core/aidl/IMessageEntity", DoNotGenerateAcw=true)]
	internal partial class IMessageEntityInvoker : global::Java.Lang.Object, IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/core/aidl/IMessageEntity", typeof (IMessageEntityInvoker));

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

		public static IMessageEntity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.core.aidl.IMessageEntity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
