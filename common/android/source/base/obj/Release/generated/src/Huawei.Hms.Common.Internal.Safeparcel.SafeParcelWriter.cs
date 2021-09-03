using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal.Safeparcel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/safeparcel/SafeParcelWriter", DoNotGenerateAcw=true)]
	public partial class SafeParcelWriter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/safeparcel/SafeParcelWriter", typeof (SafeParcelWriter));
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

		protected SafeParcelWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='beginObjectHeader' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("beginObjectHeader", "(Landroid/os/Parcel;)I", "")]
		public static unsafe int BeginObjectHeader (global::Android.OS.Parcel p0)
		{
			const string __id = "beginObjectHeader.(Landroid/os/Parcel;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='finishObjectHeader' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("finishObjectHeader", "(Landroid/os/Parcel;I)V", "")]
		public static unsafe void FinishObjectHeader (global::Android.OS.Parcel p0, int p1)
		{
			const string __id = "finishObjectHeader.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBigDecimal' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.math.BigDecimal'] and parameter[4][@type='boolean']]"
		[Register ("writeBigDecimal", "(Landroid/os/Parcel;ILjava/math/BigDecimal;Z)V", "")]
		public static unsafe void WriteBigDecimal (global::Android.OS.Parcel p0, int p1, global::Java.Math.BigDecimal p2, bool p3)
		{
			const string __id = "writeBigDecimal.(Landroid/os/Parcel;ILjava/math/BigDecimal;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBigDecimalArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.math.BigDecimal[]'] and parameter[4][@type='boolean']]"
		[Register ("writeBigDecimalArray", "(Landroid/os/Parcel;I[Ljava/math/BigDecimal;Z)V", "")]
		public static unsafe void WriteBigDecimalArray (global::Android.OS.Parcel p0, int p1, global::Java.Math.BigDecimal[] p2, bool p3)
		{
			const string __id = "writeBigDecimalArray.(Landroid/os/Parcel;I[Ljava/math/BigDecimal;Z)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBigInteger' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.math.BigInteger'] and parameter[4][@type='boolean']]"
		[Register ("writeBigInteger", "(Landroid/os/Parcel;ILjava/math/BigInteger;Z)V", "")]
		public static unsafe void WriteBigInteger (global::Android.OS.Parcel p0, int p1, global::Java.Math.BigInteger p2, bool p3)
		{
			const string __id = "writeBigInteger.(Landroid/os/Parcel;ILjava/math/BigInteger;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBigIntegerArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.math.BigInteger[]'] and parameter[4][@type='boolean']]"
		[Register ("writeBigIntegerArray", "(Landroid/os/Parcel;I[Ljava/math/BigInteger;Z)V", "")]
		public static unsafe void WriteBigIntegerArray (global::Android.OS.Parcel p0, int p1, global::Java.Math.BigInteger[] p2, bool p3)
		{
			const string __id = "writeBigIntegerArray.(Landroid/os/Parcel;I[Ljava/math/BigInteger;Z)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBoolean' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("writeBoolean", "(Landroid/os/Parcel;IZ)V", "")]
		public static unsafe void WriteBoolean (global::Android.OS.Parcel p0, int p1, bool p2)
		{
			const string __id = "writeBoolean.(Landroid/os/Parcel;IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBooleanArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='boolean[]'] and parameter[4][@type='boolean']]"
		[Register ("writeBooleanArray", "(Landroid/os/Parcel;I[ZZ)V", "")]
		public static unsafe void WriteBooleanArray (global::Android.OS.Parcel p0, int p1, bool[] p2, bool p3)
		{
			const string __id = "writeBooleanArray.(Landroid/os/Parcel;I[ZZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBooleanList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Boolean&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeBooleanList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteBooleanList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Boolean> p2, bool p3)
		{
			const string __id = "writeBooleanList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBooleanObject' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Boolean'] and parameter[4][@type='boolean']]"
		[Register ("writeBooleanObject", "(Landroid/os/Parcel;ILjava/lang/Boolean;Z)V", "")]
		public static unsafe void WriteBooleanObject (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Boolean p2, bool p3)
		{
			const string __id = "writeBooleanObject.(Landroid/os/Parcel;ILjava/lang/Boolean;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeBundle' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean']]"
		[Register ("writeBundle", "(Landroid/os/Parcel;ILandroid/os/Bundle;Z)V", "")]
		public static unsafe void WriteBundle (global::Android.OS.Parcel p0, int p1, global::Android.OS.Bundle p2, bool p3)
		{
			const string __id = "writeBundle.(Landroid/os/Parcel;ILandroid/os/Bundle;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeByte' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Register ("writeByte", "(Landroid/os/Parcel;IB)V", "")]
		public static unsafe void WriteByte (global::Android.OS.Parcel p0, int p1, sbyte p2)
		{
			const string __id = "writeByte.(Landroid/os/Parcel;IB)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeByteArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register ("writeByteArray", "(Landroid/os/Parcel;I[BZ)V", "")]
		public static unsafe void WriteByteArray (global::Android.OS.Parcel p0, int p1, byte[] p2, bool p3)
		{
			const string __id = "writeByteArray.(Landroid/os/Parcel;I[BZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeByteArrayArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='byte[][]'] and parameter[4][@type='boolean']]"
		[Register ("writeByteArrayArray", "(Landroid/os/Parcel;I[[BZ)V", "")]
		public static unsafe void WriteByteArrayArray (global::Android.OS.Parcel p0, int p1, byte[][] p2, bool p3)
		{
			const string __id = "writeByteArrayArray.(Landroid/os/Parcel;I[[BZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeByteArraySparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;byte[]&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeByteArraySparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteByteArraySparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeByteArraySparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeChar' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("writeChar", "(Landroid/os/Parcel;IC)V", "")]
		public static unsafe void WriteChar (global::Android.OS.Parcel p0, int p1, char p2)
		{
			const string __id = "writeChar.(Landroid/os/Parcel;IC)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeCharArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='char[]'] and parameter[4][@type='boolean']]"
		[Register ("writeCharArray", "(Landroid/os/Parcel;I[CZ)V", "")]
		public static unsafe void WriteCharArray (global::Android.OS.Parcel p0, int p1, char[] p2, bool p3)
		{
			const string __id = "writeCharArray.(Landroid/os/Parcel;I[CZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeDouble' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("writeDouble", "(Landroid/os/Parcel;ID)V", "")]
		public static unsafe void WriteDouble (global::Android.OS.Parcel p0, int p1, double p2)
		{
			const string __id = "writeDouble.(Landroid/os/Parcel;ID)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeDoubleArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='double[]'] and parameter[4][@type='boolean']]"
		[Register ("writeDoubleArray", "(Landroid/os/Parcel;I[DZ)V", "")]
		public static unsafe void WriteDoubleArray (global::Android.OS.Parcel p0, int p1, double[] p2, bool p3)
		{
			const string __id = "writeDoubleArray.(Landroid/os/Parcel;I[DZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeDoubleList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Double&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeDoubleList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteDoubleList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Double> p2, bool p3)
		{
			const string __id = "writeDoubleList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeDoubleObject' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Double'] and parameter[4][@type='boolean']]"
		[Register ("writeDoubleObject", "(Landroid/os/Parcel;ILjava/lang/Double;Z)V", "")]
		public static unsafe void WriteDoubleObject (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Double p2, bool p3)
		{
			const string __id = "writeDoubleObject.(Landroid/os/Parcel;ILjava/lang/Double;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeDoubleSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;java.lang.Double&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeDoubleSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteDoubleSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeDoubleSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeFloat' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("writeFloat", "(Landroid/os/Parcel;IF)V", "")]
		public static unsafe void WriteFloat (global::Android.OS.Parcel p0, int p1, float p2)
		{
			const string __id = "writeFloat.(Landroid/os/Parcel;IF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeFloatArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='boolean']]"
		[Register ("writeFloatArray", "(Landroid/os/Parcel;I[FZ)V", "")]
		public static unsafe void WriteFloatArray (global::Android.OS.Parcel p0, int p1, float[] p2, bool p3)
		{
			const string __id = "writeFloatArray.(Landroid/os/Parcel;I[FZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeFloatList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Float&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeFloatList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteFloatList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Float> p2, bool p3)
		{
			const string __id = "writeFloatList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeFloatObject' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Float'] and parameter[4][@type='boolean']]"
		[Register ("writeFloatObject", "(Landroid/os/Parcel;ILjava/lang/Float;Z)V", "")]
		public static unsafe void WriteFloatObject (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Float p2, bool p3)
		{
			const string __id = "writeFloatObject.(Landroid/os/Parcel;ILjava/lang/Float;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeFloatSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;java.lang.Float&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeFloatSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteFloatSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeFloatSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIBinder' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.IBinder'] and parameter[4][@type='boolean']]"
		[Register ("writeIBinder", "(Landroid/os/Parcel;ILandroid/os/IBinder;Z)V", "")]
		public static unsafe void WriteIBinder (global::Android.OS.Parcel p0, int p1, global::Android.OS.IBinder p2, bool p3)
		{
			const string __id = "writeIBinder.(Landroid/os/Parcel;ILandroid/os/IBinder;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIBinderArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.IBinder[]'] and parameter[4][@type='boolean']]"
		[Register ("writeIBinderArray", "(Landroid/os/Parcel;I[Landroid/os/IBinder;Z)V", "")]
		public static unsafe void WriteIBinderArray (global::Android.OS.Parcel p0, int p1, global::Android.OS.IBinder[] p2, bool p3)
		{
			const string __id = "writeIBinderArray.(Landroid/os/Parcel;I[Landroid/os/IBinder;Z)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIBinderList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;android.os.IBinder&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeIBinderList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteIBinderList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Android.OS.IBinder> p2, bool p3)
		{
			const string __id = "writeIBinderList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.OS.IBinder>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIBinderSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;android.os.IBinder&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeIBinderSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteIBinderSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeIBinderSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeInt' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeInt", "(Landroid/os/Parcel;II)V", "")]
		public static unsafe void WriteInt (global::Android.OS.Parcel p0, int p1, int p2)
		{
			const string __id = "writeInt.(Landroid/os/Parcel;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIntArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='boolean']]"
		[Register ("writeIntArray", "(Landroid/os/Parcel;I[IZ)V", "")]
		public static unsafe void WriteIntArray (global::Android.OS.Parcel p0, int p1, int[] p2, bool p3)
		{
			const string __id = "writeIntArray.(Landroid/os/Parcel;I[IZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIntegerList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeIntegerList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteIntegerList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p2, bool p3)
		{
			const string __id = "writeIntegerList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeIntegerObject' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='boolean']]"
		[Register ("writeIntegerObject", "(Landroid/os/Parcel;ILjava/lang/Integer;Z)V", "")]
		public static unsafe void WriteIntegerObject (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Integer p2, bool p3)
		{
			const string __id = "writeIntegerObject.(Landroid/os/Parcel;ILjava/lang/Integer;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List'] and parameter[4][@type='boolean']]"
		[Register ("writeList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteList (global::Android.OS.Parcel p0, int p1, global::System.Collections.IList p2, bool p3)
		{
			const string __id = "writeList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeLong' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("writeLong", "(Landroid/os/Parcel;IJ)V", "")]
		public static unsafe void WriteLong (global::Android.OS.Parcel p0, int p1, long p2)
		{
			const string __id = "writeLong.(Landroid/os/Parcel;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeLongArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='long[]'] and parameter[4][@type='boolean']]"
		[Register ("writeLongArray", "(Landroid/os/Parcel;I[JZ)V", "")]
		public static unsafe void WriteLongArray (global::Android.OS.Parcel p0, int p1, long[] p2, bool p3)
		{
			const string __id = "writeLongArray.(Landroid/os/Parcel;I[JZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeLongList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Long&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeLongList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteLongList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Long> p2, bool p3)
		{
			const string __id = "writeLongList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeLongObject' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='boolean']]"
		[Register ("writeLongObject", "(Landroid/os/Parcel;ILjava/lang/Long;Z)V", "")]
		public static unsafe void WriteLongObject (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Long p2, bool p3)
		{
			const string __id = "writeLongObject.(Landroid/os/Parcel;ILjava/lang/Long;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeParcel' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='boolean']]"
		[Register ("writeParcel", "(Landroid/os/Parcel;ILandroid/os/Parcel;Z)V", "")]
		public static unsafe void WriteParcel (global::Android.OS.Parcel p0, int p1, global::Android.OS.Parcel p2, bool p3)
		{
			const string __id = "writeParcel.(Landroid/os/Parcel;ILandroid/os/Parcel;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeParcelArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcel[]'] and parameter[4][@type='boolean']]"
		[Register ("writeParcelArray", "(Landroid/os/Parcel;I[Landroid/os/Parcel;Z)V", "")]
		public static unsafe void WriteParcelArray (global::Android.OS.Parcel p0, int p1, global::Android.OS.Parcel[] p2, bool p3)
		{
			const string __id = "writeParcelArray.(Landroid/os/Parcel;I[Landroid/os/Parcel;Z)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeParcelList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;android.os.Parcel&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeParcelList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteParcelList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<global::Android.OS.Parcel> p2, bool p3)
		{
			const string __id = "writeParcelList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.OS.Parcel>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeParcelSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;android.os.Parcel&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeParcelSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteParcelSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeParcelSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeParcelable' and count(parameter)=5 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Parcelable'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("writeParcelable", "(Landroid/os/Parcel;ILandroid/os/Parcelable;IZ)V", "")]
		public static unsafe void WriteParcelable (global::Android.OS.Parcel p0, int p1, global::Android.OS.IParcelable p2, int p3, bool p4)
		{
			const string __id = "writeParcelable.(Landroid/os/Parcel;ILandroid/os/Parcelable;IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeShort' and count(parameter)=3 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='short']]"
		[Register ("writeShort", "(Landroid/os/Parcel;IS)V", "")]
		public static unsafe void WriteShort (global::Android.OS.Parcel p0, int p1, short p2)
		{
			const string __id = "writeShort.(Landroid/os/Parcel;IS)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeSparseBooleanArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseBooleanArray'] and parameter[4][@type='boolean']]"
		[Register ("writeSparseBooleanArray", "(Landroid/os/Parcel;ILandroid/util/SparseBooleanArray;Z)V", "")]
		public static unsafe void WriteSparseBooleanArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseBooleanArray p2, bool p3)
		{
			const string __id = "writeSparseBooleanArray.(Landroid/os/Parcel;ILandroid/util/SparseBooleanArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeSparseIntArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseIntArray'] and parameter[4][@type='boolean']]"
		[Register ("writeSparseIntArray", "(Landroid/os/Parcel;ILandroid/util/SparseIntArray;Z)V", "")]
		public static unsafe void WriteSparseIntArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseIntArray p2, bool p3)
		{
			const string __id = "writeSparseIntArray.(Landroid/os/Parcel;ILandroid/util/SparseIntArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeSparseLongArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseLongArray'] and parameter[4][@type='boolean']]"
		[Register ("writeSparseLongArray", "(Landroid/os/Parcel;ILandroid/util/SparseLongArray;Z)V", "")]
		public static unsafe void WriteSparseLongArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseLongArray p2, bool p3)
		{
			const string __id = "writeSparseLongArray.(Landroid/os/Parcel;ILandroid/util/SparseLongArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeString' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("writeString", "(Landroid/os/Parcel;ILjava/lang/String;Z)V", "")]
		public static unsafe void WriteString (global::Android.OS.Parcel p0, int p1, string p2, bool p3)
		{
			const string __id = "writeString.(Landroid/os/Parcel;ILjava/lang/String;Z)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeStringArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='boolean']]"
		[Register ("writeStringArray", "(Landroid/os/Parcel;I[Ljava/lang/String;Z)V", "")]
		public static unsafe void WriteStringArray (global::Android.OS.Parcel p0, int p1, string[] p2, bool p3)
		{
			const string __id = "writeStringArray.(Landroid/os/Parcel;I[Ljava/lang/String;Z)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeStringList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeStringList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		public static unsafe void WriteStringList (global::Android.OS.Parcel p0, int p1, global::System.Collections.Generic.IList<string> p2, bool p3)
		{
			const string __id = "writeStringList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeStringSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;java.lang.String&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeStringSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		public static unsafe void WriteStringSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeStringSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeTypedArray' and count(parameter)=5 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='P[]'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("writeTypedArray", "(Landroid/os/Parcel;I[Landroid/os/Parcelable;IZ)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"P extends android.os.Parcelable"})]
		public static unsafe void WriteTypedArray (global::Android.OS.Parcel p0, int p1, global::Java.Lang.Object[] p2, int p3, bool p4)
		{
			const string __id = "writeTypedArray.(Landroid/os/Parcel;I[Landroid/os/Parcelable;IZ)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeTypedList' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;T&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeTypedList", "(Landroid/os/Parcel;ILjava/util/List;Z)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.os.Parcelable"})]
		public static unsafe void WriteTypedList (global::Android.OS.Parcel p0, int p1, global::System.Collections.IList p2, bool p3)
		{
			const string __id = "writeTypedList.(Landroid/os/Parcel;ILjava/util/List;Z)V";
			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal.safeparcel']/class[@name='SafeParcelWriter']/method[@name='writeTypedSparseArray' and count(parameter)=4 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int'] and parameter[3][@type='android.util.SparseArray&lt;T&gt;'] and parameter[4][@type='boolean']]"
		[Register ("writeTypedSparseArray", "(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.os.Parcelable"})]
		public static unsafe void WriteTypedSparseArray (global::Android.OS.Parcel p0, int p1, global::Android.Util.SparseArray p2, bool p3)
		{
			const string __id = "writeTypedSparseArray.(Landroid/os/Parcel;ILandroid/util/SparseArray;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
