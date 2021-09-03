using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskExecutors']"
	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/TaskExecutors", DoNotGenerateAcw=true)]
	public sealed partial class TaskExecutors : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/TaskExecutors", typeof (TaskExecutors));
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

		internal TaskExecutors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskExecutors']/method[@name='immediate' and count(parameter)=0]"
		[Register ("immediate", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor Immediate ()
		{
			const string __id = "immediate.()Ljava/util/concurrent/Executor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskExecutors']/method[@name='uiThread' and count(parameter)=0]"
		[Register ("uiThread", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor UiThread ()
		{
			const string __id = "uiThread.()Ljava/util/concurrent/Executor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
