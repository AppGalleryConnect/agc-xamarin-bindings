using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ConvertedResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class ConvertedResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ConvertedResult", typeof (ConvertedResult));
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

		protected ConvertedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']/constructor[@name='ConvertedResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConvertedResult ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ConvertedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultConvert> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']/method[@name='convertResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultConvert&lt;? super R, ? extends S&gt;']]"
		[Register ("convertResult", "(Lcom/huawei/hms/support/api/client/ResultConvert;)Lcom/huawei/hms/support/api/client/ConvertedResult;", "GetConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.support.api.client.Result"})]
		public abstract global::Huawei.Hms.Support.Api.Client.ConvertedResult ConvertResult (global::Huawei.Hms.Support.Api.Client.ResultConvert p0);

		static Delegate cb_finalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_;
#pragma warning disable 0169
		static Delegate GetFinalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_Handler ()
		{
			if (cb_finalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_ == null)
				cb_finalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FinalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_);
			return cb_finalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_;
		}

		static void n_FinalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ConvertedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FinalExec (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']/method[@name='finalExec' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallbacks&lt;? super R&gt;']]"
		[Register ("finalExec", "(Lcom/huawei/hms/support/api/client/ResultCallbacks;)V", "GetFinalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_Handler")]
		public abstract void FinalExec (global::Huawei.Hms.Support.Api.Client.ResultCallbacks p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ConvertedResult", DoNotGenerateAcw=true)]
	internal partial class ConvertedResultInvoker : ConvertedResult {

		public ConvertedResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ConvertedResult", typeof (ConvertedResultInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']/method[@name='convertResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultConvert&lt;? super R, ? extends S&gt;']]"
		[Register ("convertResult", "(Lcom/huawei/hms/support/api/client/ResultConvert;)Lcom/huawei/hms/support/api/client/ConvertedResult;", "GetConvertResult_Lcom_huawei_hms_support_api_client_ResultConvert_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S extends com.huawei.hms.support.api.client.Result"})]
		public override unsafe global::Huawei.Hms.Support.Api.Client.ConvertedResult ConvertResult (global::Huawei.Hms.Support.Api.Client.ResultConvert p0)
		{
			const string __id = "convertResult.(Lcom/huawei/hms/support/api/client/ResultConvert;)Lcom/huawei/hms/support/api/client/ConvertedResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ConvertedResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ConvertedResult']/method[@name='finalExec' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ResultCallbacks&lt;? super R&gt;']]"
		[Register ("finalExec", "(Lcom/huawei/hms/support/api/client/ResultCallbacks;)V", "GetFinalExec_Lcom_huawei_hms_support_api_client_ResultCallbacks_Handler")]
		public override unsafe void FinalExec (global::Huawei.Hms.Support.Api.Client.ResultCallbacks p0)
		{
			const string __id = "finalExec.(Lcom/huawei/hms/support/api/client/ResultCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
