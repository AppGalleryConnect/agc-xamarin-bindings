using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ScheduledThreadPoolExecutorEnhance']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ScheduledThreadPoolExecutorEnhance", DoNotGenerateAcw=true)]
	public partial class ScheduledThreadPoolExecutorEnhance : global::Java.Util.Concurrent.ScheduledThreadPoolExecutor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ScheduledThreadPoolExecutorEnhance", typeof (ScheduledThreadPoolExecutorEnhance));
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

		protected ScheduledThreadPoolExecutorEnhance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ScheduledThreadPoolExecutorEnhance']/constructor[@name='ScheduledThreadPoolExecutorEnhance' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.concurrent.ThreadFactory']]"
		[Register (".ctor", "(ILjava/util/concurrent/ThreadFactory;)V", "")]
		public unsafe ScheduledThreadPoolExecutorEnhance (int p0, global::Java.Util.Concurrent.IThreadFactory p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/util/concurrent/ThreadFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_decorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_;
#pragma warning disable 0169
		static Delegate GetDecorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_Handler ()
		{
			if (cb_decorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_ == null)
				cb_decorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_DecorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_);
			return cb_decorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_;
		}

		static IntPtr n_DecorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.ScheduledThreadPoolExecutorEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Util.Concurrent.IRunnableScheduledFuture)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IRunnableScheduledFuture> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecorateTask (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ScheduledThreadPoolExecutorEnhance']/method[@name='decorateTask' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='java.util.concurrent.RunnableScheduledFuture&lt;V&gt;']]"
		[Register ("decorateTask", "(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;", "GetDecorateTask_Ljava_lang_Runnable_Ljava_util_concurrent_RunnableScheduledFuture_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		protected override unsafe global::Java.Util.Concurrent.IRunnableScheduledFuture DecorateTask (global::Java.Lang.IRunnable p0, global::Java.Util.Concurrent.IRunnableScheduledFuture p1)
		{
			const string __id = "decorateTask.(Ljava/lang/Runnable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IRunnableScheduledFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_decorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_;
#pragma warning disable 0169
		static Delegate GetDecorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_Handler ()
		{
			if (cb_decorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_ == null)
				cb_decorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_DecorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_);
			return cb_decorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_;
		}

		static IntPtr n_DecorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.ScheduledThreadPoolExecutorEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Util.Concurrent.IRunnableScheduledFuture)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IRunnableScheduledFuture> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecorateTask (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ScheduledThreadPoolExecutorEnhance']/method[@name='decorateTask' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;V&gt;'] and parameter[2][@type='java.util.concurrent.RunnableScheduledFuture&lt;V&gt;']]"
		[Register ("decorateTask", "(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;", "GetDecorateTask_Ljava_util_concurrent_Callable_Ljava_util_concurrent_RunnableScheduledFuture_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		protected override unsafe global::Java.Util.Concurrent.IRunnableScheduledFuture DecorateTask (global::Java.Util.Concurrent.ICallable p0, global::Java.Util.Concurrent.IRunnableScheduledFuture p1)
		{
			const string __id = "decorateTask.(Ljava/util/concurrent/Callable;Ljava/util/concurrent/RunnableScheduledFuture;)Ljava/util/concurrent/RunnableScheduledFuture;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IRunnableScheduledFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
