using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']"
	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/Tasks", DoNotGenerateAcw=true)]
	public partial class Tasks : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/Tasks", typeof (Tasks));
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

		protected Tasks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/constructor[@name='Tasks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tasks ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='allOf' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;?&gt;...']]"
		[Register ("allOf", "([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;", "")]
		public static unsafe global::Huawei.Hmf.Tasks.Task AllOf (params global::Huawei.Hmf.Tasks.Task[] p0)
		{
			const string __id = "allOf.([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='allOf' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.huawei.hmf.tasks.Task&lt;?&gt;&gt;']]"
		[Register ("allOf", "(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;", "")]
		public static unsafe global::Huawei.Hmf.Tasks.Task AllOf (global::System.Collections.Generic.ICollection<global::Huawei.Hmf.Tasks.Task> p0)
		{
			const string __id = "allOf.(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Huawei.Hmf.Tasks.Task>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='await' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;TResult&gt;']]"
		[Register ("await", "(Lcom/huawei/hmf/tasks/Task;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Java.Lang.Object Await (global::Huawei.Hmf.Tasks.Task p0)
		{
			const string __id = "await.(Lcom/huawei/hmf/tasks/Task;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='await' and count(parameter)=3 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;TResult&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(Lcom/huawei/hmf/tasks/Task;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Java.Lang.Object Await (global::Huawei.Hmf.Tasks.Task p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			const string __id = "await.(Lcom/huawei/hmf/tasks/Task;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;TResult&gt;']]"
		[Register ("call", "(Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task Call (global::Java.Util.Concurrent.ICallable p0)
		{
			const string __id = "call.(Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='callInBackground' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;TResult&gt;']]"
		[Register ("callInBackground", "(Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task CallInBackground (global::Java.Util.Concurrent.ICallable p0)
		{
			const string __id = "callInBackground.(Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='callInBackground' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='java.util.concurrent.Callable&lt;TResult&gt;']]"
		[Register ("callInBackground", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task CallInBackground (global::Java.Util.Concurrent.IExecutor p0, global::Java.Util.Concurrent.ICallable p1)
		{
			const string __id = "callInBackground.(Ljava/util/concurrent/Executor;Ljava/util/concurrent/Callable;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='fromCanceled' and count(parameter)=0]"
		[Register ("fromCanceled", "()Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task FromCanceled ()
		{
			const string __id = "fromCanceled.()Lcom/huawei/hmf/tasks/Task;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='fromException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("fromException", "(Ljava/lang/Exception;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task FromException (global::Java.Lang.Exception p0)
		{
			const string __id = "fromException.(Ljava/lang/Exception;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='fromResult' and count(parameter)=1 and parameter[1][@type='TResult']]"
		[Register ("fromResult", "(Ljava/lang/Object;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task FromResult (global::Java.Lang.Object p0)
		{
			const string __id = "fromResult.(Ljava/lang/Object;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='join' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;?&gt;...']]"
		[Register ("join", "([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;", "")]
		public static unsafe global::Huawei.Hmf.Tasks.Task Join (params global::Huawei.Hmf.Tasks.Task[] p0)
		{
			const string __id = "join.([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='join' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.huawei.hmf.tasks.Task&lt;?&gt;&gt;']]"
		[Register ("join", "(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;", "")]
		public static unsafe global::Huawei.Hmf.Tasks.Task Join (global::System.Collections.Generic.ICollection<global::Huawei.Hmf.Tasks.Task> p0)
		{
			const string __id = "join.(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Huawei.Hmf.Tasks.Task>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='successOf' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;?&gt;...']]"
		[Register ("successOf", "([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task SuccessOf (params global::Huawei.Hmf.Tasks.Task[] p0)
		{
			const string __id = "successOf.([Lcom/huawei/hmf/tasks/Task;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Tasks']/method[@name='successOf' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends com.huawei.hmf.tasks.Task&lt;TResult&gt;&gt;']]"
		[Register ("successOf", "(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
		public static unsafe global::Huawei.Hmf.Tasks.Task SuccessOf (global::System.Collections.ICollection p0)
		{
			const string __id = "successOf.(Ljava/util/Collection;)Lcom/huawei/hmf/tasks/Task;";
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
