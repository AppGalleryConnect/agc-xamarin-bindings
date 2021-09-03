using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCallWrapper']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/TaskApiCallWrapper", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
	public partial class TaskApiCallWrapper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/TaskApiCallWrapper", typeof (TaskApiCallWrapper));
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

		protected TaskApiCallWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCallWrapper']/constructor[@name='TaskApiCallWrapper' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.internal.TaskApiCall&lt;? extends com.huawei.hms.common.internal.AnyClient, TResult&gt;'] and parameter[2][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;TResult&gt;']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/internal/TaskApiCall;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "")]
		public unsafe TaskApiCallWrapper (global::Huawei.Hms.Common.Internal.TaskApiCall p0, global::Huawei.Hmf.Tasks.TaskCompletionSource p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/internal/TaskApiCall;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getTaskApiCall;
#pragma warning disable 0169
		static Delegate GetGetTaskApiCallHandler ()
		{
			if (cb_getTaskApiCall == null)
				cb_getTaskApiCall = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTaskApiCall);
			return cb_getTaskApiCall;
		}

		static IntPtr n_GetTaskApiCall (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCallWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TaskApiCall);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Common.Internal.TaskApiCall TaskApiCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCallWrapper']/method[@name='getTaskApiCall' and count(parameter)=0]"
			[Register ("getTaskApiCall", "()Lcom/huawei/hms/common/internal/TaskApiCall;", "GetGetTaskApiCallHandler")]
			get {
				const string __id = "getTaskApiCall.()Lcom/huawei/hms/common/internal/TaskApiCall;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTaskCompletionSource;
#pragma warning disable 0169
		static Delegate GetGetTaskCompletionSourceHandler ()
		{
			if (cb_getTaskCompletionSource == null)
				cb_getTaskCompletionSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTaskCompletionSource);
			return cb_getTaskCompletionSource;
		}

		static IntPtr n_GetTaskCompletionSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCallWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TaskCompletionSource);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.TaskCompletionSource TaskCompletionSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCallWrapper']/method[@name='getTaskCompletionSource' and count(parameter)=0]"
			[Register ("getTaskCompletionSource", "()Lcom/huawei/hmf/tasks/TaskCompletionSource;", "GetGetTaskCompletionSourceHandler")]
			get {
				const string __id = "getTaskCompletionSource.()Lcom/huawei/hmf/tasks/TaskCompletionSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
