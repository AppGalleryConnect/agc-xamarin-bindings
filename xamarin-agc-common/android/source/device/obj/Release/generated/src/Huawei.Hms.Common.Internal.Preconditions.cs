using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/Preconditions", DoNotGenerateAcw=true)]
	public sealed partial class Preconditions : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/Preconditions", typeof (Preconditions));
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

		internal Preconditions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/constructor[@name='Preconditions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Preconditions ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public static unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, global::Java.Lang.Object p1)
		{
			const string __id = "checkArgument.(ZLjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkHandlerThread' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("checkHandlerThread", "(Landroid/os/Handler;)V", "")]
		public static unsafe void CheckHandlerThread (global::Android.OS.Handler p0)
		{
			const string __id = "checkHandlerThread.(Landroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkHandlerThread' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkHandlerThread", "(Landroid/os/Handler;Ljava/lang/String;)V", "")]
		public static unsafe void CheckHandlerThread (global::Android.OS.Handler p0, string p1)
		{
			const string __id = "checkHandlerThread.(Landroid/os/Handler;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkMainThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkMainThread", "(Ljava/lang/String;)V", "")]
		public static unsafe void CheckMainThread (string p0)
		{
			const string __id = "checkMainThread.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkNotMainThread' and count(parameter)=0]"
		[Register ("checkNotMainThread", "()V", "")]
		public static unsafe void CheckNotMainThread ()
		{
			const string __id = "checkNotMainThread.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='O']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"O"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0)
		{
			const string __id = "checkNotNull.(Ljava/lang/Object;)Ljava/lang/Object;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='O'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"O"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			const string __id = "checkNotNull.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, global::Java.Lang.Object p1)
		{
			const string __id = "checkState.(ZLjava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
