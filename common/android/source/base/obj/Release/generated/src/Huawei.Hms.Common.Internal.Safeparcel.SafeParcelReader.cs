using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal.Safeparcel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/safeparcel/SafeParcelReader", DoNotGenerateAcw=true)]
	public partial class SafeParcelReader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader.ParseException']"
		[global::Android.Runtime.Register ("com/huawei/hms/common/internal/safeparcel/SafeParcelReader$ParseException", DoNotGenerateAcw=true)]
		public partial class ParseException : global::Java.Lang.RuntimeException {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/safeparcel/SafeParcelReader$ParseException", typeof (ParseException));
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

			protected ParseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader.ParseException']/constructor[@name='SafeParcelReader.ParseException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Parcel']]"
			[Register (".ctor", "(Ljava/lang/String;Landroid/os/Parcel;)V", "")]
			public unsafe ParseException (string p0, global::Android.OS.Parcel p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Landroid/os/Parcel;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/safeparcel/SafeParcelReader", typeof (SafeParcelReader));
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

		protected SafeParcelReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBigDecimal' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBigDecimal", "(Landroid/os/Parcel;I)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal CreateBigDecimal (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBigDecimal.(Landroid/os/Parcel;I)Ljava/math/BigDecimal;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBigDecimalArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBigDecimalArray", "(Landroid/os/Parcel;I)[Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal[] CreateBigDecimalArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBigDecimalArray.(Landroid/os/Parcel;I)[Ljava/math/BigDecimal;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Math.BigDecimal[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Math.BigDecimal));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBigInteger' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBigInteger", "(Landroid/os/Parcel;I)Ljava/math/BigInteger;", "")]
		public static unsafe global::Java.Math.BigInteger CreateBigInteger (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBigInteger.(Landroid/os/Parcel;I)Ljava/math/BigInteger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBigIntegerArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBigIntegerArray", "(Landroid/os/Parcel;I)[Ljava/math/BigInteger;", "")]
		public static unsafe global::Java.Math.BigInteger[] CreateBigIntegerArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBigIntegerArray.(Landroid/os/Parcel;I)[Ljava/math/BigInteger;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Math.BigInteger[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Math.BigInteger));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBooleanArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBooleanArray", "(Landroid/os/Parcel;I)[Z", "")]
		public static unsafe bool[] CreateBooleanArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBooleanArray.(Landroid/os/Parcel;I)[Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (bool[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBooleanList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBooleanList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Boolean> CreateBooleanList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBooleanList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createBundle' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createBundle", "(Landroid/os/Parcel;I)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle CreateBundle (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createBundle.(Landroid/os/Parcel;I)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createByteArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createByteArray", "(Landroid/os/Parcel;I)[B", "")]
		public static unsafe byte[] CreateByteArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createByteArray.(Landroid/os/Parcel;I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createByteArrayArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createByteArrayArray", "(Landroid/os/Parcel;I)[[B", "")]
		public static unsafe byte[][] CreateByteArrayArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createByteArrayArray.(Landroid/os/Parcel;I)[[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[][]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte[]));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createByteArraySparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createByteArraySparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateByteArraySparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createByteArraySparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createCharArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createCharArray", "(Landroid/os/Parcel;I)[C", "")]
		public static unsafe char[] CreateCharArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createCharArray.(Landroid/os/Parcel;I)[C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createDoubleArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createDoubleArray", "(Landroid/os/Parcel;I)[D", "")]
		public static unsafe double[] CreateDoubleArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createDoubleArray.(Landroid/os/Parcel;I)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createDoubleList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createDoubleList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> CreateDoubleList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createDoubleList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createDoubleSparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createDoubleSparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateDoubleSparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createDoubleSparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createFloatArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createFloatArray", "(Landroid/os/Parcel;I)[F", "")]
		public static unsafe float[] CreateFloatArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createFloatArray.(Landroid/os/Parcel;I)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createFloatList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createFloatList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Float> CreateFloatList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createFloatList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Float>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createFloatSparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createFloatSparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateFloatSparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createFloatSparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createIBinderArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createIBinderArray", "(Landroid/os/Parcel;I)[Landroid/os/IBinder;", "")]
		public static unsafe global::Android.OS.IBinder[] CreateIBinderArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createIBinderArray.(Landroid/os/Parcel;I)[Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Android.OS.IBinder[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.OS.IBinder));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createIBinderList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createIBinderList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.OS.IBinder> CreateIBinderList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createIBinderList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.OS.IBinder>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createIBinderSparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createIBinderSparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateIBinderSparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createIBinderSparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createIntArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createIntArray", "(Landroid/os/Parcel;I)[I", "")]
		public static unsafe int[] CreateIntArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createIntArray.(Landroid/os/Parcel;I)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createIntegerList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createIntegerList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> CreateIntegerList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createIntegerList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createLongArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createLongArray", "(Landroid/os/Parcel;I)[J", "")]
		public static unsafe long[] CreateLongArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createLongArray.(Landroid/os/Parcel;I)[J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createLongList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createLongList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Long> CreateLongList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createLongList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createParcel", "(Landroid/os/Parcel;I)Landroid/os/Parcel;", "")]
		public static unsafe global::Android.OS.Parcel CreateParcel (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createParcel.(Landroid/os/Parcel;I)Landroid/os/Parcel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createParcelArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createParcelArray", "(Landroid/os/Parcel;I)[Landroid/os/Parcel;", "")]
		public static unsafe global::Android.OS.Parcel[] CreateParcelArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createParcelArray.(Landroid/os/Parcel;I)[Landroid/os/Parcel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Android.OS.Parcel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.OS.Parcel));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createParcelList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createParcelList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.OS.Parcel> CreateParcelList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createParcelList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.OS.Parcel>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createParcelSparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createParcelSparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateParcelSparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createParcelSparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createParcelable' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcelable.Creator&lt;P&gt;']]"
		[Register ("createParcelable", "(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Landroid/os/Parcelable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"P extends android.os.Parcelable"})]
		public static unsafe global::Java.Lang.Object CreateParcelable (global::Android.OS.Parcel p0, int p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "createParcelable.(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Landroid/os/Parcelable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createSparseBooleanArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createSparseBooleanArray", "(Landroid/os/Parcel;I)Landroid/util/SparseBooleanArray;", "")]
		public static unsafe global::Android.Util.SparseBooleanArray CreateSparseBooleanArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createSparseBooleanArray.(Landroid/os/Parcel;I)Landroid/util/SparseBooleanArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseBooleanArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createSparseIntArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createSparseIntArray", "(Landroid/os/Parcel;I)Landroid/util/SparseIntArray;", "")]
		public static unsafe global::Android.Util.SparseIntArray CreateSparseIntArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createSparseIntArray.(Landroid/os/Parcel;I)Landroid/util/SparseIntArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createSparseLongArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createSparseLongArray", "(Landroid/os/Parcel;I)Landroid/util/SparseLongArray;", "")]
		public static unsafe global::Android.Util.SparseLongArray CreateSparseLongArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createSparseLongArray.(Landroid/os/Parcel;I)Landroid/util/SparseLongArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseLongArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createString' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createString", "(Landroid/os/Parcel;I)Ljava/lang/String;", "")]
		public static unsafe string CreateString (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createString.(Landroid/os/Parcel;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createStringArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createStringArray", "(Landroid/os/Parcel;I)[Ljava/lang/String;", "")]
		public static unsafe string[] CreateStringArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createStringArray.(Landroid/os/Parcel;I)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createStringList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createStringList", "(Landroid/os/Parcel;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> CreateStringList (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createStringList.(Landroid/os/Parcel;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createStringSparseArray' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("createStringSparseArray", "(Landroid/os/Parcel;I)Landroid/util/SparseArray;", "")]
		public static unsafe global::Android.Util.SparseArray CreateStringSparseArray (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "createStringSparseArray.(Landroid/os/Parcel;I)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createTypedArray' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcelable.Creator&lt;C&gt;']]"
		[Register ("createTypedArray", "(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
		public static unsafe global::Java.Lang.Object[] CreateTypedArray (global::Android.OS.Parcel p0, int p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "createTypedArray.(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)[Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createTypedList' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcelable.Creator&lt;C&gt;']]"
		[Register ("createTypedList", "(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
		public static unsafe global::System.Collections.IList CreateTypedList (global::Android.OS.Parcel p0, int p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "createTypedList.(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='createTypedSparseArray' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcelable.Creator&lt;C&gt;']]"
		[Register ("createTypedSparseArray", "(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Landroid/util/SparseArray;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"C"})]
		public static unsafe global::Android.Util.SparseArray CreateTypedSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.OS.IParcelableCreator p2)
		{
			const string __id = "createTypedSparseArray.(Landroid/os/Parcel;ILandroid/os/Parcelable$Creator;)Landroid/util/SparseArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='ensureAtEnd' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("ensureAtEnd", "(Landroid/os/Parcel;I)V", "")]
		public static unsafe void EnsureAtEnd (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "ensureAtEnd.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='getFieldId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFieldId", "(I)I", "")]
		public static unsafe int GetFieldId (int p0)
		{
			const string __id = "getFieldId.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readBoolean' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readBoolean", "(Landroid/os/Parcel;I)Z", "")]
		public static unsafe bool ReadBoolean (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readBoolean.(Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readBooleanObject' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readBooleanObject", "(Landroid/os/Parcel;I)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean ReadBooleanObject (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readBooleanObject.(Landroid/os/Parcel;I)Ljava/lang/Boolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readByte' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readByte", "(Landroid/os/Parcel;I)B", "")]
		public static unsafe sbyte ReadByte (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readByte.(Landroid/os/Parcel;I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readChar' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readChar", "(Landroid/os/Parcel;I)C", "")]
		public static unsafe char ReadChar (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readChar.(Landroid/os/Parcel;I)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readDouble' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readDouble", "(Landroid/os/Parcel;I)D", "")]
		public static unsafe double ReadDouble (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readDouble.(Landroid/os/Parcel;I)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readDoubleObject' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readDoubleObject", "(Landroid/os/Parcel;I)Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double ReadDoubleObject (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readDoubleObject.(Landroid/os/Parcel;I)Ljava/lang/Double;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readFloat' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readFloat", "(Landroid/os/Parcel;I)F", "")]
		public static unsafe float ReadFloat (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readFloat.(Landroid/os/Parcel;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readFloatObject' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readFloatObject", "(Landroid/os/Parcel;I)Ljava/lang/Float;", "")]
		public static unsafe global::Java.Lang.Float ReadFloatObject (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readFloatObject.(Landroid/os/Parcel;I)Ljava/lang/Float;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readHeader' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("readHeader", "(Landroid/os/Parcel;)I", "")]
		public static unsafe int ReadHeader (global::Android.OS.Parcel p0)
		{
			const string __id = "readHeader.(Landroid/os/Parcel;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readIBinder' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readIBinder", "(Landroid/os/Parcel;I)Landroid/os/IBinder;", "")]
		public static unsafe global::Android.OS.IBinder ReadIBinder (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readIBinder.(Landroid/os/Parcel;I)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readInt' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readInt", "(Landroid/os/Parcel;I)I", "")]
		public static unsafe int ReadInt (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readInt.(Landroid/os/Parcel;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readIntegerObject' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readIntegerObject", "(Landroid/os/Parcel;I)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ReadIntegerObject (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readIntegerObject.(Landroid/os/Parcel;I)Ljava/lang/Integer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List'] and parameter[4][@type='java.lang.ClassLoader']]"
		[Register ("readList", "(Landroid/os/Parcel;ILjava/util/List;Ljava/lang/ClassLoader;)V", "")]
		public static unsafe void ReadList (global::Android.OS.Parcel p0, int p1, global::System.Collections.IList p2, global::Java.Lang.ClassLoader p3)
		{
			const string __id = "readList.(Landroid/os/Parcel;ILjava/util/List;Ljava/lang/ClassLoader;)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readLong' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readLong", "(Landroid/os/Parcel;I)J", "")]
		public static unsafe long ReadLong (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readLong.(Landroid/os/Parcel;I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readLongObject' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readLongObject", "(Landroid/os/Parcel;I)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long ReadLongObject (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readLongObject.(Landroid/os/Parcel;I)Ljava/lang/Long;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readShort' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readShort", "(Landroid/os/Parcel;I)S", "")]
		public static unsafe short ReadShort (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readShort.(Landroid/os/Parcel;I)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='readSize' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("readSize", "(Landroid/os/Parcel;I)I", "")]
		public static unsafe int ReadSize (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "readSize.(Landroid/os/Parcel;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='skipUnknownField' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("skipUnknownField", "(Landroid/os/Parcel;I)V", "")]
		public static unsafe void SkipUnknownField (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "skipUnknownField.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelReader']/method[@name='validateObjectHeader' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("validateObjectHeader", "(Landroid/os/Parcel;)I", "")]
		public static unsafe int ValidateObjectHeader (global::Android.OS.Parcel p0)
		{
			const string __id = "validateObjectHeader.(Landroid/os/Parcel;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
