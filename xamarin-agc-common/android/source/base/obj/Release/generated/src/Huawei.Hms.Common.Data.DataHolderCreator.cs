using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolderCreator']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataHolderCreator", DoNotGenerateAcw=true)]
	public sealed partial class DataHolderCreator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataHolderCreator", typeof (DataHolderCreator));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal DataHolderCreator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolderCreator']/constructor[@name='DataHolderCreator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataHolderCreator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolderCreator']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createFromParcel", "(Landroid/os/Parcel;)Lcom/huawei/hms/common/data/DataHolder;", "")]
		public unsafe global::Java.Lang.Object CreateFromParcel (global::Android.OS.Parcel p0)
		{
			const string __id = "createFromParcel.(Landroid/os/Parcel;)Lcom/huawei/hms/common/data/DataHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolderCreator']/method[@name='newArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newArray", "(I)[Lcom/huawei/hms/common/data/DataHolder;", "")]
		public unsafe global::Java.Lang.Object[] NewArray (int p0)
		{
			const string __id = "newArray.(I)[Lcom/huawei/hms/common/data/DataHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Huawei.Hms.Common.Data.DataHolder[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Huawei.Hms.Common.Data.DataHolder));
			} finally {
			}
		}

	}
}
