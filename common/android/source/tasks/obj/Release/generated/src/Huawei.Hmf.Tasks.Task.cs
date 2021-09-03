using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']"
	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/Task", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
	public abstract partial class Task : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/Task", typeof (Task));
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

		protected Task (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/constructor[@name='Task' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Task ()
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

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")] get;
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public abstract bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")] get;
		}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		public abstract bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")] get;
		}

		static Delegate cb_isSuccessful;
#pragma warning disable 0169
		static Delegate GetIsSuccessfulHandler ()
		{
			if (cb_isSuccessful == null)
				cb_isSuccessful = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccessful);
			return cb_isSuccessful;
		}

		static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccessful;
		}
#pragma warning restore 0169

		public abstract bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")] get;
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawResult);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")] get;
		}

		static Delegate cb_addOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler ()
		{
			if (cb_addOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_ == null)
				cb_addOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_);
			return cb_addOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_;
		}

		static IntPtr n_AddOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnCanceledListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCanceledListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCanceledListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCanceledListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnCanceledListener']]"
		[Register ("addOnCanceledListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCanceledListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCanceledListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnCanceledListener p1)
		{
			const string __id = "addOnCanceledListener.(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_addOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler ()
		{
			if (cb_addOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_ == null)
				cb_addOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_);
			return cb_addOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_;
		}

		static IntPtr n_AddOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IOnCanceledListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCanceledListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCanceledListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCanceledListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnCanceledListener']]"
		[Register ("addOnCanceledListener", "(Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCanceledListener_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCanceledListener (global::Huawei.Hmf.Tasks.IOnCanceledListener p0)
		{
			const string __id = "addOnCanceledListener.(Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler ()
		{
			if (cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_ == null)
				cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_);
			return cb_addOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_;
		}

		static IntPtr n_AddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnCanceledListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCanceledListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCanceledListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCanceledListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnCanceledListener']]"
		[Register ("addOnCanceledListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCanceledListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCanceledListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCanceledListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnCanceledListener p1)
		{
			const string __id = "addOnCanceledListener.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnCanceledListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_addOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler ()
		{
			if (cb_addOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_ == null)
				cb_addOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_);
			return cb_addOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_;
		}

		static IntPtr n_AddOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnCompleteListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCompleteListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCompleteListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCompleteListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnCompleteListener&lt;TResult&gt;']]"
		[Register ("addOnCompleteListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCompleteListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCompleteListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnCompleteListener p1)
		{
			const string __id = "addOnCompleteListener.(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_addOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler ()
		{
			if (cb_addOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_ == null)
				cb_addOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_);
			return cb_addOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_;
		}

		static IntPtr n_AddOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IOnCompleteListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCompleteListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnCompleteListener&lt;TResult&gt;']]"
		[Register ("addOnCompleteListener", "(Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCompleteListener_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCompleteListener (global::Huawei.Hmf.Tasks.IOnCompleteListener p0)
		{
			const string __id = "addOnCompleteListener.(Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetAddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler ()
		{
			if (cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_ == null)
				cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_);
			return cb_addOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_;
		}

		static IntPtr n_AddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnCompleteListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCompleteListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnCompleteListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnCompleteListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnCompleteListener&lt;TResult&gt;']]"
		[Register ("addOnCompleteListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnCompleteListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnCompleteListener_Handler")]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task AddOnCompleteListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnCompleteListener p1)
		{
			const string __id = "addOnCompleteListener.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnCompleteListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_addOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_;
#pragma warning disable 0169
		static Delegate GetAddOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_Handler ()
		{
			if (cb_addOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_ == null)
				cb_addOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_);
			return cb_addOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_;
		}

		static IntPtr n_AddOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnFailureListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnFailureListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnFailureListener p1);

		static Delegate cb_addOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_;
#pragma warning disable 0169
		static Delegate GetAddOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_Handler ()
		{
			if (cb_addOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_ == null)
				cb_addOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_);
			return cb_addOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_;
		}

		static IntPtr n_AddOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnFailureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnFailureListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Huawei.Hmf.Tasks.IOnFailureListener p0);

		static Delegate cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_;
#pragma warning disable 0169
		static Delegate GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_Handler ()
		{
			if (cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_ == null)
				cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_);
			return cb_addOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_;
		}

		static IntPtr n_AddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnFailureListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnFailureListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnFailureListener p1);

		static Delegate cb_addOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetAddOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler ()
		{
			if (cb_addOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_ == null)
				cb_addOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_);
			return cb_addOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_;
		}

		static IntPtr n_AddOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnSuccessListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnSuccessListener p1);

		static Delegate cb_addOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetAddOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler ()
		{
			if (cb_addOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_ == null)
				cb_addOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_);
			return cb_addOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_;
		}

		static IntPtr n_AddOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnSuccessListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnSuccessListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Huawei.Hmf.Tasks.IOnSuccessListener p0);

		static Delegate cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler ()
		{
			if (cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_ == null)
				cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_);
			return cb_addOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_;
		}

		static IntPtr n_AddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnSuccessListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public abstract global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnSuccessListener p1);

		static Delegate cb_continueWith_Lcom_huawei_hmf_tasks_Continuation_;
#pragma warning disable 0169
		static Delegate GetContinueWith_Lcom_huawei_hmf_tasks_Continuation_Handler ()
		{
			if (cb_continueWith_Lcom_huawei_hmf_tasks_Continuation_ == null)
				cb_continueWith_Lcom_huawei_hmf_tasks_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ContinueWith_Lcom_huawei_hmf_tasks_Continuation_);
			return cb_continueWith_Lcom_huawei_hmf_tasks_Continuation_;
		}

		static IntPtr n_ContinueWith_Lcom_huawei_hmf_tasks_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ContinueWith (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='continueWith' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Continuation&lt;TResult, TContinuationResult&gt;']]"
		[Register ("continueWith", "(Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;", "GetContinueWith_Lcom_huawei_hmf_tasks_Continuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task ContinueWith (global::Huawei.Hmf.Tasks.IContinuation p0)
		{
			const string __id = "continueWith.(Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_continueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_;
#pragma warning disable 0169
		static Delegate GetContinueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_Handler ()
		{
			if (cb_continueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ == null)
				cb_continueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ContinueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_);
			return cb_continueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_;
		}

		static IntPtr n_ContinueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ContinueWith (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='continueWith' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.Continuation&lt;TResult, TContinuationResult&gt;']]"
		[Register ("continueWith", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;", "GetContinueWith_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task ContinueWith (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IContinuation p1)
		{
			const string __id = "continueWith.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_continueWithTask_Lcom_huawei_hmf_tasks_Continuation_;
#pragma warning disable 0169
		static Delegate GetContinueWithTask_Lcom_huawei_hmf_tasks_Continuation_Handler ()
		{
			if (cb_continueWithTask_Lcom_huawei_hmf_tasks_Continuation_ == null)
				cb_continueWithTask_Lcom_huawei_hmf_tasks_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ContinueWithTask_Lcom_huawei_hmf_tasks_Continuation_);
			return cb_continueWithTask_Lcom_huawei_hmf_tasks_Continuation_;
		}

		static IntPtr n_ContinueWithTask_Lcom_huawei_hmf_tasks_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.IContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ContinueWithTask (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='continueWithTask' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Continuation&lt;TResult, com.huawei.hmf.tasks.Task&lt;TContinuationResult&gt;&gt;']]"
		[Register ("continueWithTask", "(Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;", "GetContinueWithTask_Lcom_huawei_hmf_tasks_Continuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task ContinueWithTask (global::Huawei.Hmf.Tasks.IContinuation p0)
		{
			const string __id = "continueWithTask.(Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_;
#pragma warning disable 0169
		static Delegate GetContinueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_Handler ()
		{
			if (cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ == null)
				cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_ContinueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_);
			return cb_continueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_;
		}

		static IntPtr n_ContinueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.IContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ContinueWithTask (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='continueWithTask' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.Continuation&lt;TResult, com.huawei.hmf.tasks.Task&lt;TContinuationResult&gt;&gt;']]"
		[Register ("continueWithTask", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;", "GetContinueWithTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_Continuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task ContinueWithTask (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IContinuation p1)
		{
			const string __id = "continueWithTask.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/Continuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getResultThrowException_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetResultThrowException_Ljava_lang_Class_Handler ()
		{
			if (cb_getResultThrowException_Ljava_lang_Class_ == null)
				cb_getResultThrowException_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetResultThrowException_Ljava_lang_Class_);
			return cb_getResultThrowException_Ljava_lang_Class_;
		}

		static IntPtr n_GetResultThrowException_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResultThrowException (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getResultThrowException' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;E&gt;']]"
		[Register ("getResultThrowException", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetResultThrowException_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public abstract global::Java.Lang.Object GetResultThrowException (global::Java.Lang.Class p0);

		static Delegate cb_onSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_;
#pragma warning disable 0169
		static Delegate GetOnSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_Handler ()
		{
			if (cb_onSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_ == null)
				cb_onSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_);
			return cb_onSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_;
		}

		static IntPtr n_OnSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hmf.Tasks.ISuccessContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.ISuccessContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnSuccessTask (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='onSuccessTask' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.SuccessContinuation&lt;TResult, TContinuationResult&gt;']]"
		[Register ("onSuccessTask", "(Lcom/huawei/hmf/tasks/SuccessContinuation;)Lcom/huawei/hmf/tasks/Task;", "GetOnSuccessTask_Lcom_huawei_hmf_tasks_SuccessContinuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task OnSuccessTask (global::Huawei.Hmf.Tasks.ISuccessContinuation p0)
		{
			const string __id = "onSuccessTask.(Lcom/huawei/hmf/tasks/SuccessContinuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_;
#pragma warning disable 0169
		static Delegate GetOnSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_Handler ()
		{
			if (cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_ == null)
				cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_OnSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_);
			return cb_onSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_;
		}

		static IntPtr n_OnSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hmf.Tasks.ISuccessContinuation)global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.ISuccessContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnSuccessTask (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='onSuccessTask' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.SuccessContinuation&lt;TResult, TContinuationResult&gt;']]"
		[Register ("onSuccessTask", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/SuccessContinuation;)Lcom/huawei/hmf/tasks/Task;", "GetOnSuccessTask_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_SuccessContinuation_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TContinuationResult"})]
		public virtual unsafe global::Huawei.Hmf.Tasks.Task OnSuccessTask (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.ISuccessContinuation p1)
		{
			const string __id = "onSuccessTask.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/SuccessContinuation;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/Task", DoNotGenerateAcw=true)]
	internal partial class TaskInvoker : Task {

		public TaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/Task", typeof (TaskInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Ljava/lang/Exception;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				const string __id = "isComplete.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				const string __id = "isSuccessful.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected override unsafe global::Java.Lang.Object RawResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnFailureListener p1)
		{
			const string __id = "addOnFailureListener.(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Huawei.Hmf.Tasks.IOnFailureListener p0)
		{
			const string __id = "addOnFailureListener.(Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnFailureListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnFailureListener']]"
		[Register ("addOnFailureListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnFailureListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnFailureListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnFailureListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnFailureListener p1)
		{
			const string __id = "addOnFailureListener.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnFailureListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Landroid_app_Activity_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Android.App.Activity p0, global::Huawei.Hmf.Tasks.IOnSuccessListener p1)
		{
			const string __id = "addOnSuccessListener.(Landroid/app/Activity;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Huawei.Hmf.Tasks.IOnSuccessListener p0)
		{
			const string __id = "addOnSuccessListener.(Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='addOnSuccessListener' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='com.huawei.hmf.tasks.OnSuccessListener&lt;TResult&gt;']]"
		[Register ("addOnSuccessListener", "(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;", "GetAddOnSuccessListener_Ljava_util_concurrent_Executor_Lcom_huawei_hmf_tasks_OnSuccessListener_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.Task AddOnSuccessListener (global::Java.Util.Concurrent.IExecutor p0, global::Huawei.Hmf.Tasks.IOnSuccessListener p1)
		{
			const string __id = "addOnSuccessListener.(Ljava/util/concurrent/Executor;Lcom/huawei/hmf/tasks/OnSuccessListener;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='Task']/method[@name='getResultThrowException' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;E&gt;']]"
		[Register ("getResultThrowException", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetResultThrowException_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public override unsafe global::Java.Lang.Object GetResultThrowException (global::Java.Lang.Class p0)
		{
			const string __id = "getResultThrowException.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
