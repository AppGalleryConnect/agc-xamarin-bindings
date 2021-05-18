using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='FreezableUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/FreezableUtils", DoNotGenerateAcw=true)]
	public sealed partial class FreezableUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/FreezableUtils", typeof (FreezableUtils));
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

		internal FreezableUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='FreezableUtils']/constructor[@name='FreezableUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FreezableUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='FreezableUtils']/method[@name='freeze' and count(parameter)=1 and parameter[1][@type='E[]']]"
		[Register ("freeze", "([Lcom/huawei/hms/common/data/Freezable;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "E extends com.huawei.hms.common.data.Freezable<T>"})]
		public static unsafe global::System.Collections.IList Freeze (global::Java.Lang.Object[] p0)
		{
			const string __id = "freeze.([Lcom/huawei/hms/common/data/Freezable;)Ljava/util/ArrayList;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='FreezableUtils']/method[@name='freeze' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;E&gt;']]"
		[Register ("freeze", "(Ljava/util/ArrayList;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "E extends com.huawei.hms.common.data.Freezable<T>"})]
		public static unsafe global::System.Collections.IList Freeze (global::System.Collections.IList p0)
		{
			const string __id = "freeze.(Ljava/util/ArrayList;)Ljava/util/ArrayList;";
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='FreezableUtils']/method[@name='freezeIterable' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;E&gt;']]"
		[Register ("freezeIterable", "(Ljava/lang/Iterable;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "E extends com.huawei.hms.common.data.Freezable<T>"})]
		public static unsafe global::System.Collections.IList FreezeIterable (global::Java.Lang.IIterable p0)
		{
			const string __id = "freezeIterable.(Ljava/lang/Iterable;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
