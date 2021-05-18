using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/InnerPendingResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class InnerPendingResult : global::Huawei.Hms.Support.Api.Client.PendingResult {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/InnerPendingResult", typeof (InnerPendingResult));
		internal static new IntPtr class_ref {
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

		protected InnerPendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']/constructor[@name='InnerPendingResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InnerPendingResult ()
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

		static Delegate cb_awaitOnAnyThread;
#pragma warning disable 0169
		static Delegate GetAwaitOnAnyThreadHandler ()
		{
			if (cb_awaitOnAnyThread == null)
				cb_awaitOnAnyThread = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AwaitOnAnyThread);
			return cb_awaitOnAnyThread;
		}

		static IntPtr n_AwaitOnAnyThread (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.InnerPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AwaitOnAnyThread ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']/method[@name='awaitOnAnyThread' and count(parameter)=0]"
		[Register ("awaitOnAnyThread", "()Lcom/huawei/hms/support/api/client/Result;", "GetAwaitOnAnyThreadHandler")]
		public abstract global::Java.Lang.Object AwaitOnAnyThread ();

		static Delegate cb_awaitOnAnyThread_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwaitOnAnyThread_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_awaitOnAnyThread_JLjava_util_concurrent_TimeUnit_ == null)
				cb_awaitOnAnyThread_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_AwaitOnAnyThread_JLjava_util_concurrent_TimeUnit_);
			return cb_awaitOnAnyThread_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_AwaitOnAnyThread_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.InnerPendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AwaitOnAnyThread (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']/method[@name='awaitOnAnyThread' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitOnAnyThread", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "GetAwaitOnAnyThread_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract global::Java.Lang.Object AwaitOnAnyThread (long p0, global::Java.Util.Concurrent.TimeUnit p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/InnerPendingResult", DoNotGenerateAcw=true)]
	internal partial class InnerPendingResultInvoker : InnerPendingResult {

		public InnerPendingResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/InnerPendingResult", typeof (InnerPendingResultInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']/method[@name='awaitOnAnyThread' and count(parameter)=0]"
		[Register ("awaitOnAnyThread", "()Lcom/huawei/hms/support/api/client/Result;", "GetAwaitOnAnyThreadHandler")]
		public override unsafe global::Java.Lang.Object AwaitOnAnyThread ()
		{
			const string __id = "awaitOnAnyThread.()Lcom/huawei/hms/support/api/client/Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='InnerPendingResult']/method[@name='awaitOnAnyThread' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitOnAnyThread", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "GetAwaitOnAnyThread_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::Java.Lang.Object AwaitOnAnyThread (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "awaitOnAnyThread.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		public override unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='isCanceled' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lcom/huawei/hms/support/api/client/Result;", "GetAwaitHandler")]
		public override unsafe global::Java.Lang.Object Await ()
		{
			const string __id = "await.()Lcom/huawei/hms/support/api/client/Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::Java.Lang.Object Await (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "await.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Landroid/os/Looper;Lcom/huawei/hms/support/api/client/ResultCallback;)V", "GetSetResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public override unsafe void SetResultCallback (global::Android.OS.Looper p0, global::Huawei.Hms.Support.Api.Client.IResultCallback p1)
		{
			const string __id = "setResultCallback.(Landroid/os/Looper;Lcom/huawei/hms/support/api/client/ResultCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public override unsafe void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0)
		{
			const string __id = "setResultCallback.(Lcom/huawei/hms/support/api/client/ResultCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			const string __id = "setResultCallback.(Lcom/huawei/hms/support/api/client/ResultCallback;JLjava/util/concurrent/TimeUnit;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

}
