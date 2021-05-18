using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsEnhance']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ExecutorsEnhance", DoNotGenerateAcw=true)]
	public partial class ExecutorsEnhance : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ExecutorsEnhance", typeof (ExecutorsEnhance));
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

		protected ExecutorsEnhance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsEnhance']/constructor[@name='ExecutorsEnhance' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExecutorsEnhance ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExecutorsEnhance']/method[@name='newSingleThreadExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("newSingleThreadExecutor", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewSingleThreadExecutor (global::Java.Util.Concurrent.IThreadFactory p0)
		{
			const string __id = "newSingleThreadExecutor.(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
