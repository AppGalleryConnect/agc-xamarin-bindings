using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/Checker", DoNotGenerateAcw=true)]
	public sealed partial class Checker : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/Checker", typeof (Checker));
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

		internal Checker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/constructor[@name='Checker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Checker ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertHandlerThread' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("assertHandlerThread", "(Landroid/os/Handler;)V", "")]
		public static unsafe void AssertHandlerThread (global::Android.OS.Handler p0)
		{
			const string __id = "assertHandlerThread.(Landroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertHandlerThread' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertHandlerThread", "(Landroid/os/Handler;Ljava/lang/String;)V", "")]
		public static unsafe void AssertHandlerThread (global::Android.OS.Handler p0, string p1)
		{
			const string __id = "assertHandlerThread.(Landroid/os/Handler;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertNonEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("assertNonEmpty", "(Ljava/lang/String;)V", "")]
		public static unsafe void AssertNonEmpty (string p0)
		{
			const string __id = "assertNonEmpty.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertNonEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertNonEmpty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AssertNonEmpty (string p0, string p1)
		{
			const string __id = "assertNonEmpty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertNonNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("assertNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AssertNonNull (global::Java.Lang.Object p0)
		{
			const string __id = "assertNonNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertNonNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AssertNonNull (global::Java.Lang.Object p0, string p1)
		{
			const string __id = "assertNonNull.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertNotUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("assertNotUiThread", "(Ljava/lang/String;)V", "")]
		public static unsafe void AssertNotUiThread (string p0)
		{
			const string __id = "assertNotUiThread.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='assertUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("assertUiThread", "(Ljava/lang/String;)V", "")]
		public static unsafe void AssertUiThread (string p0)
		{
			const string __id = "assertUiThread.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkNonEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CheckNonEmpty (string p0)
		{
			const string __id = "checkNonEmpty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkNonEmpty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CheckNonEmpty (string p0, string p1)
		{
			const string __id = "checkNonEmpty.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNonNull (global::Java.Lang.Object p0)
		{
			const string __id = "checkNonNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNonNull (global::Java.Lang.Object p0, string p1)
		{
			const string __id = "checkNonNull.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonZero' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkNonZero", "(I)I", "")]
		public static unsafe int CheckNonZero (int p0)
		{
			const string __id = "checkNonZero.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNonZero' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkNonZero", "(ILjava/lang/String;)I", "")]
		public static unsafe int CheckNonZero (int p0, string p1)
		{
			const string __id = "checkNonZero.(ILjava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNotZero' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("checkNotZero", "(J)J", "")]
		public static unsafe long CheckNotZero (long p0)
		{
			const string __id = "checkNotZero.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Checker']/method[@name='checkNotZero' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkNotZero", "(JLjava/lang/String;)J", "")]
		public static unsafe long CheckNotZero (long p0, string p1)
		{
			const string __id = "checkNotZero.(JLjava/lang/String;)J";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
