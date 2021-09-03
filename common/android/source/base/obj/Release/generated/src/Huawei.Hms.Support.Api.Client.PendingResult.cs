using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/PendingResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class PendingResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/PendingResult", typeof (PendingResult));
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

		protected PendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/constructor[@name='PendingResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PendingResult ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		public abstract bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")] get;
		}

		static Delegate cb_await;
#pragma warning disable 0169
		static Delegate GetAwaitHandler ()
		{
			if (cb_await == null)
				cb_await = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Await);
			return cb_await;
		}

		static IntPtr n_Await (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Await ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lcom/huawei/hms/support/api/client/Result;", "GetAwaitHandler")]
		public abstract global::Java.Lang.Object Await ();

		static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_await_JLjava_util_concurrent_TimeUnit_ == null)
				cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Await_JLjava_util_concurrent_TimeUnit_);
			return cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Await_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Await (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/support/api/client/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract global::Java.Lang.Object Await (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

		static Delegate cb_convertResult_Lcom_huawei_hms_support_api_client_ResultConvert_;
#pragma warning disable 0169
		static Delegate GetConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_Handler ()
		{
			if (cb_convertResult_Lcom_huawei_hms_support_api_client_ResultConvert_ == null)
				cb_convertResult_Lcom_huawei_hms_support_api_client_ResultConvert_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_);
			return cb_convertResult_Lcom_huawei_hms_support_api_client_ResultConvert_;
		}

		static IntPtr n_ConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultConvert> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='convertResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultConvert&lt;? super R, ? extends S&gt;']]"
		[Register ("convertResult", "(Lcom/huawei/hms/support/api/client/ResultConvert;)Lcom/huawei/hms/support/api/client/ConvertedResult;", "GetConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.support.api.client.Result"})]
		public virtual unsafe global::Huawei.Hms.Support.Api.Client.ConvertedResult ConvertResult (global::Huawei.Hms.Support.Api.Client.ResultConvert p0)
		{
			const string __id = "convertResult.(Lcom/huawei/hms/support/api/client/ResultConvert;)Lcom/huawei/hms/support/api/client/ConvertedResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ConvertedResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_Handler ()
		{
			if (cb_setResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_ == null)
				cb_setResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_);
			return cb_setResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_;
		}

		static void n_SetResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Landroid/os/Looper;Lcom/huawei/hms/support/api/client/ResultCallback;)V", "GetSetResultCallback_Landroid_os_Looper_Lcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public abstract void SetResultCallback (global::Android.OS.Looper p0, global::Huawei.Hms.Support.Api.Client.IResultCallback p1);

		static Delegate cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_Handler ()
		{
			if (cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ == null)
				cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_);
			return cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_;
		}

		static void n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public abstract void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0);

		static Delegate cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ == null)
				cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJL_V) n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_);
			return cb_setResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_;
		}

		static void n_SetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResult']/method[@name='setResultCallback' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallback&lt;R&gt;'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("setResultCallback", "(Lcom/huawei/hms/support/api/client/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "GetSetResultCallback_Lcom_huawei_hms_support_api_client_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract void SetResultCallback (global::Huawei.Hms.Support.Api.Client.IResultCallback p0, long p1, global::Java.Util.Concurrent.TimeUnit p2);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/PendingResult", DoNotGenerateAcw=true)]
	internal partial class PendingResultInvoker : PendingResult {

		public PendingResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/PendingResult", typeof (PendingResultInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
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
