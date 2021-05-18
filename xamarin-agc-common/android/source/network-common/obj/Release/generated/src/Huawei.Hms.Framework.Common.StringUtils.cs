using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/StringUtils", typeof (StringUtils));
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

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='anonymizeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("anonymizeMessage", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AnonymizeMessage (string p0)
		{
			const string __id = "anonymizeMessage.(Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='byte2Str' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byte2Str", "([B)Ljava/lang/String;", "")]
		public static unsafe string Byte2Str (byte[] p0)
		{
			const string __id = "byte2Str.([B)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string Format (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "format.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytes (string p0)
		{
			const string __id = "getBytes.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getBytes", "(J)[B", "")]
		public static unsafe byte[] GetBytes (long p0)
		{
			const string __id = "getBytes.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='getTraceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getTraceInfo", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string GetTraceInfo (global::Java.Lang.Throwable p0)
		{
			const string __id = "getTraceInfo.(Ljava/lang/Throwable;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='replace' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence']]"
		[Register ("replace", "(Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", "")]
		public static unsafe string Replace (string p0, global::Java.Lang.ICharSequence p1, global::Java.Lang.ICharSequence p2)
		{
			const string __id = "replace.(Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			IntPtr native_p2 = CharSequence.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		public static string Replace (string p0, string p1, string p2)
		{
			var jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			var jls_p2 = p2 == null ? null : new global::Java.Lang.String (p2);
			string __result = Replace (p0, jls_p1, jls_p2);
			var __rsval = __result;
			jls_p1?.Dispose ();
			jls_p2?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='str2Byte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("str2Byte", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Str2Byte (string p0)
		{
			const string __id = "str2Byte.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='strEquals' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("strEquals", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool StrEquals (string p0, string p1)
		{
			const string __id = "strEquals.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='stringToInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("stringToInteger", "(Ljava/lang/String;I)I", "")]
		public static unsafe int StringToInteger (string p0, int p1)
		{
			const string __id = "stringToInteger.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='stringToLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("stringToLong", "(Ljava/lang/String;J)J", "")]
		public static unsafe long StringToLong (string p0, long p1)
		{
			const string __id = "stringToLong.(Ljava/lang/String;J)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='substring' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("substring", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string Substring (string p0, int p1)
		{
			const string __id = "substring.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='substring' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("substring", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public static unsafe string Substring (string p0, int p1, int p2)
		{
			const string __id = "substring.(Ljava/lang/String;II)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='StringUtils']/method[@name='toLowerCase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toLowerCase", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToLowerCase (string p0)
		{
			const string __id = "toLowerCase.(Ljava/lang/String;)Ljava/lang/String;";
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

	}
}
