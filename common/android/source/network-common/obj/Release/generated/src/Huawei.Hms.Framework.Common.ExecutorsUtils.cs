using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ExecutorsUtils", DoNotGenerateAcw=true)]
	public partial class ExecutorsUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ExecutorsUtils", typeof (ExecutorsUtils));
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

		protected ExecutorsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/constructor[@name='ExecutorsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExecutorsUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/method[@name='createThreadFactory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createThreadFactory", "(Ljava/lang/String;)Ljava/util/concurrent/ThreadFactory;", "")]
		public static unsafe global::Java.Util.Concurrent.IThreadFactory CreateThreadFactory (string p0)
		{
			const string __id = "createThreadFactory.(Ljava/lang/String;)Ljava/util/concurrent/ThreadFactory;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/method[@name='newCachedThreadPool' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newCachedThreadPool", "(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool (string p0)
		{
			const string __id = "newCachedThreadPool.(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/method[@name='newFixedThreadPool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("newFixedThreadPool", "(ILjava/lang/String;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewFixedThreadPool (int p0, string p1)
		{
			const string __id = "newFixedThreadPool.(ILjava/lang/String;)Ljava/util/concurrent/ExecutorService;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/method[@name='newScheduledThreadPool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("newScheduledThreadPool", "(ILjava/lang/String;)Ljava/util/concurrent/ScheduledExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IScheduledExecutorService NewScheduledThreadPool (int p0, string p1)
		{
			const string __id = "newScheduledThreadPool.(ILjava/lang/String;)Ljava/util/concurrent/ScheduledExecutorService;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsUtils']/method[@name='newSingleThreadExecutor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newSingleThreadExecutor", "(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor (string p0)
		{
			const string __id = "newSingleThreadExecutor.(Ljava/lang/String;)Ljava/util/concurrent/ExecutorService;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
