using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']"
	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/TaskCompletionSource", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
	public partial class TaskCompletionSource : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/TaskCompletionSource", typeof (TaskCompletionSource));
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

		protected TaskCompletionSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']/constructor[@name='TaskCompletionSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TaskCompletionSource ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']/constructor[@name='TaskCompletionSource' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.CancellationToken']]"
		[Register (".ctor", "(Lcom/huawei/hmf/tasks/CancellationToken;)V", "")]
		public unsafe TaskCompletionSource (global::Huawei.Hmf.Tasks.CancellationToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hmf/tasks/CancellationToken;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getTask;
#pragma warning disable 0169
		static Delegate GetGetTaskHandler ()
		{
			if (cb_getTask == null)
				cb_getTask = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTask);
			return cb_getTask;
		}

		static IntPtr n_GetTask (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Task);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.Task Task {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']/method[@name='getTask' and count(parameter)=0]"
			[Register ("getTask", "()Lcom/huawei/hmf/tasks/Task;", "GetGetTaskHandler")]
			get {
				const string __id = "getTask.()Lcom/huawei/hmf/tasks/Task;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetSetException_Ljava_lang_Exception_Handler ()
		{
			if (cb_setException_Ljava_lang_Exception_ == null)
				cb_setException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetException_Ljava_lang_Exception_);
			return cb_setException_Ljava_lang_Exception_;
		}

		static void n_SetException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetException (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']/method[@name='setException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("setException", "(Ljava/lang/Exception;)V", "GetSetException_Ljava_lang_Exception_Handler")]
		public virtual unsafe void SetException (global::Java.Lang.Exception p0)
		{
			const string __id = "setException.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setResult_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetResult_Ljava_lang_Object_Handler ()
		{
			if (cb_setResult_Ljava_lang_Object_ == null)
				cb_setResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResult_Ljava_lang_Object_);
			return cb_setResult_Ljava_lang_Object_;
		}

		static void n_SetResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='TaskCompletionSource']/method[@name='setResult' and count(parameter)=1 and parameter[1][@type='TResult']]"
		[Register ("setResult", "(Ljava/lang/Object;)V", "GetSetResult_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetResult (global::Java.Lang.Object p0)
		{
			const string __id = "setResult.(Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
