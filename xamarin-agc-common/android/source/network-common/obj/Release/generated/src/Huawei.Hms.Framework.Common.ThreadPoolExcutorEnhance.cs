using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ThreadPoolExcutorEnhance']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ThreadPoolExcutorEnhance", DoNotGenerateAcw=true)]
	public partial class ThreadPoolExcutorEnhance : global::Java.Util.Concurrent.ThreadPoolExecutor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ThreadPoolExcutorEnhance", typeof (ThreadPoolExcutorEnhance));
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

		protected ThreadPoolExcutorEnhance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ThreadPoolExcutorEnhance']/constructor[@name='ThreadPoolExcutorEnhance' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.TimeUnit'] and parameter[5][@type='java.util.concurrent.BlockingQueue&lt;java.lang.Runnable&gt;'] and parameter[6][@type='java.util.concurrent.ThreadFactory']]"
		[Register (".ctor", "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V", "")]
		public unsafe ThreadPoolExcutorEnhance (int p0, int p1, long p2, global::Java.Util.Concurrent.TimeUnit p3, global::Java.Util.Concurrent.IBlockingQueue p4, global::Java.Util.Concurrent.IThreadFactory p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIJLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/BlockingQueue;Ljava/util/concurrent/ThreadFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
				global::System.GC.KeepAlive (p5);
			}
		}

	}
}
