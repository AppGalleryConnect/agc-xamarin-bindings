using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/Logger", typeof (Logger));
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

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='isAPPLoggable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAPPLoggable", "(I)Z", "")]
		public static unsafe bool IsAPPLoggable (int p0)
		{
			const string __id = "isAPPLoggable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='isLoggable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoggable", "(I)Z", "")]
		public static unsafe bool IsLoggable (int p0)
		{
			const string __id = "isLoggable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='println' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("println", "(ILjava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void Println (int p0, string p1, global::Java.Lang.Object p2)
		{
			const string __id = "println.(ILjava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='println' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("println", "(ILjava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Println (int p0, string p1, string p2, params global::Java.Lang.Object[] p3)
		{
			const string __id = "println.(ILjava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='setExtLogger' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.framework.common.ExtLogger'] and parameter[2][@type='boolean']]"
		[Register ("setExtLogger", "(Lcom/huawei/hms/framework/common/ExtLogger;Z)V", "")]
		public static unsafe void SetExtLogger (global::Huawei.Hms.Framework.Common.ExtLogger p0, bool p1)
		{
			const string __id = "setExtLogger.(Lcom/huawei/hms/framework/common/ExtLogger;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void V (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='Logger']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
