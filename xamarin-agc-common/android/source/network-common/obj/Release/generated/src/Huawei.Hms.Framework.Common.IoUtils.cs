using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/IoUtils", DoNotGenerateAcw=true)]
	public partial class IoUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/IoUtils", typeof (IoUtils));
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

		protected IoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='close' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("close", "(Landroid/database/Cursor;)V", "")]
		public static unsafe void Close (global::Android.Database.ICursor p0)
		{
			const string __id = "close.(Landroid/database/Cursor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='closeSecure' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeSecure", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseSecure (global::Java.IO.ICloseable p0)
		{
			const string __id = "closeSecure.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='closeSecure' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("closeSecure", "(Ljava/io/InputStream;)V", "")]
		public static unsafe void CloseSecure (global::System.IO.Stream p0)
		{
			const string __id = "closeSecure.(Ljava/io/InputStream;)V";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='closeSecure' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("closeSecure", "(Ljava/io/OutputStream;)V", "")]
		public static unsafe void CloseOutputStream (global::System.IO.Stream p0)
		{
			const string __id = "closeSecure.(Ljava/io/OutputStream;)V";
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='closeSecure' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("closeSecure", "(Ljava/io/Reader;)V", "")]
		public static unsafe void CloseSecure (global::Java.IO.Reader p0)
		{
			const string __id = "closeSecure.(Ljava/io/Reader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='closeSecure' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("closeSecure", "(Ljava/io/Writer;)V", "")]
		public static unsafe void CloseSecure (global::Java.IO.Writer p0)
		{
			const string __id = "closeSecure.(Ljava/io/Writer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)J", "")]
		public static unsafe long Copy (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			const string __id = "copy.(Ljava/io/InputStream;Ljava/io/OutputStream;)J";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='IoUtils']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("toByteArray", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ToByteArray (global::System.IO.Stream p0)
		{
			const string __id = "toByteArray.(Ljava/io/InputStream;)[B";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
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

	}
}
