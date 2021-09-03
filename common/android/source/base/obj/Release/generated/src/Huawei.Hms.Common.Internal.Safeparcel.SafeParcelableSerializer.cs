using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal.Safeparcel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/safeparcel/SafeParcelableSerializer", DoNotGenerateAcw=true)]
	public sealed partial class SafeParcelableSerializer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/safeparcel/SafeParcelableSerializer", typeof (SafeParcelableSerializer));
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

		internal SafeParcelableSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/constructor[@name='SafeParcelableSerializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SafeParcelableSerializer ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='deserializeFromBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.os.Parcelable.Creator&lt;S&gt;']]"
		[Register ("deserializeFromBytes", "([BLandroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe global::Java.Lang.Object DeserializeFromBytes (byte[] p0, global::Android.OS.IParcelableCreator p1)
		{
			const string __id = "deserializeFromBytes.([BLandroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='deserializeFromIntentExtra' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Parcelable.Creator&lt;S&gt;']]"
		[Register ("deserializeFromIntentExtra", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe global::Java.Lang.Object DeserializeFromIntentExtra (global::Android.Content.Intent p0, string p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "deserializeFromIntentExtra.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='deserializeFromString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Parcelable.Creator&lt;S&gt;']]"
		[Register ("deserializeFromString", "(Ljava/lang/String;Landroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe global::Java.Lang.Object DeserializeFromString (string p0, global::Android.OS.IParcelableCreator p1)
		{
			const string __id = "deserializeFromString.(Ljava/lang/String;Landroid/os/Parcelable$Creator;)Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='deserializeIterableFromBundle' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Parcelable.Creator&lt;S&gt;']]"
		[Register ("deserializeIterableFromBundle", "(Landroid/os/Bundle;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe global::System.Collections.IList DeserializeIterableFromBundle (global::Android.OS.Bundle p0, string p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "deserializeIterableFromBundle.(Landroid/os/Bundle;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='deserializeIterableFromIntentExtra' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Parcelable.Creator&lt;S&gt;']]"
		[Register ("deserializeIterableFromIntentExtra", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe global::System.Collections.IList DeserializeIterableFromIntentExtra (global::Android.Content.Intent p0, string p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "deserializeIterableFromIntentExtra.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='serializeIterableToBundle' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;S&gt;'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String']]"
		[Register ("serializeIterableToBundle", "(Ljava/lang/Iterable;Landroid/os/Bundle;Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe void SerializeIterableToBundle (global::Java.Lang.IIterable p0, global::Android.OS.Bundle p1, string p2)
		{
			const string __id = "serializeIterableToBundle.(Ljava/lang/Iterable;Landroid/os/Bundle;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='serializeIterableToIntentExtra' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable&lt;S&gt;'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='java.lang.String']]"
		[Register ("serializeIterableToIntentExtra", "(Ljava/lang/Iterable;Landroid/content/Intent;Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe void SerializeIterableToIntentExtra (global::Java.Lang.IIterable p0, global::Android.Content.Intent p1, string p2)
		{
			const string __id = "serializeIterableToIntentExtra.(Ljava/lang/Iterable;Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='serializeToBytes' and count(parameter)=1 and parameter[1][@type='S']]"
		[Register ("serializeToBytes", "(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;)[B", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe byte[] SerializeToBytes (global::Java.Lang.Object p0)
		{
			const string __id = "serializeToBytes.(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;)[B";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='serializeToIntentExtra' and count(parameter)=3 and parameter[1][@type='S'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='java.lang.String']]"
		[Register ("serializeToIntentExtra", "(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;Landroid/content/Intent;Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe void SerializeToIntentExtra (global::Java.Lang.Object p0, global::Android.Content.Intent p1, string p2)
		{
			const string __id = "serializeToIntentExtra.(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelableSerializer']/method[@name='serializeToString' and count(parameter)=1 and parameter[1][@type='S']]"
		[Register ("serializeToString", "(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.common.internal.safeparcel.SafeParcelable"})]
		public static unsafe string SerializeToString (global::Java.Lang.Object p0)
		{
			const string __id = "serializeToString.(Lcom/huawei/hms/common/internal/safeparcel/SafeParcelable;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
