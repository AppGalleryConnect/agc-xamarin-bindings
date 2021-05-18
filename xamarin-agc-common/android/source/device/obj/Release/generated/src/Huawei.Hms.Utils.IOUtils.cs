using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/IOUtils", DoNotGenerateAcw=true)]
	public sealed partial class IOUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/IOUtils", typeof (IOUtils));
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

		internal IOUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/constructor[@name='IOUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IOUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable p0)
		{
			const string __id = "closeQuietly.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("closeQuietly", "(Ljava/io/InputStream;)V", "")]
		public static unsafe void CloseQuietly (global::System.IO.Stream p0)
		{
			const string __id = "closeQuietly.(Ljava/io/InputStream;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("closeQuietly", "(Ljava/io/OutputStream;)V", "")]
		public static unsafe void CloseOutputStreamQuietly (global::System.IO.Stream p0)
		{
			const string __id = "closeQuietly.(Ljava/io/OutputStream;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("closeQuietly", "(Ljava/io/Reader;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.Reader p0)
		{
			const string __id = "closeQuietly.(Ljava/io/Reader;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("closeQuietly", "(Ljava/io/Writer;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.Writer p0)
		{
			const string __id = "closeQuietly.(Ljava/io/Writer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='byte[]']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;[B)J", "")]
		public static unsafe long Copy (global::System.IO.Stream p0, global::System.IO.Stream p1, byte[] p2)
		{
			const string __id = "copy.(Ljava/io/InputStream;Ljava/io/OutputStream;[B)J";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='IOUtils']/method[@name='toInputStream' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toInputStream", "([B)Ljava/io/InputStream;", "")]
		public static unsafe global::System.IO.Stream ToInputStream (byte[] p0)
		{
			const string __id = "toInputStream.([B)Ljava/io/InputStream;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
