using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultConvert", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result", "S extends com.huawei.hms.support.api.client.Result"})]
	public abstract partial class ResultConvert : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert.FailPendingResult']"
		[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultConvert$FailPendingResult", DoNotGenerateAcw=true)]
		public partial class FailPendingResult : global::Huawei.Hms.Support.Api.Client.EmptyPendingResult {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultConvert$FailPendingResult", typeof (FailPendingResult));
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

			protected FailPendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert.FailPendingResult']/constructor[@name='ResultConvert.FailPendingResult' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ResultConvert'] and parameter[2][@type='com.huawei.hms.support.api.client.Status']]"
			[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ResultConvert;Lcom/huawei/hms/support/api/client/Status;)V", "")]
			public unsafe FailPendingResult (global::Huawei.Hms.Support.Api.Client.ResultConvert __self, global::Huawei.Hms.Support.Api.Client.Status p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/huawei/hms/support/api/client/Status;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultConvert", typeof (ResultConvert));
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

		protected ResultConvert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']/constructor[@name='ResultConvert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultConvert ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']/method[@name='newFailedPendingResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("newFailedPendingResult", "(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public unsafe global::Huawei.Hms.Support.Api.Client.PendingResult NewFailedPendingResult (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "newFailedPendingResult.(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onFailed_Lcom_huawei_hms_support_api_client_Status_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_huawei_hms_support_api_client_Status_Handler ()
		{
			if (cb_onFailed_Lcom_huawei_hms_support_api_client_Status_ == null)
				cb_onFailed_Lcom_huawei_hms_support_api_client_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnFailed_Lcom_huawei_hms_support_api_client_Status_);
			return cb_onFailed_Lcom_huawei_hms_support_api_client_Status_;
		}

		static IntPtr n_OnFailed_Lcom_huawei_hms_support_api_client_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultConvert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnFailed (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("onFailed", "(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/Status;", "GetOnFailed_Lcom_huawei_hms_support_api_client_Status_Handler")]
		public virtual unsafe global::Huawei.Hms.Support.Api.Client.Status OnFailed (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "onFailed.(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/Status;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler ()
		{
			if (cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_ == null)
				cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnSuccess_Lcom_huawei_hms_support_api_client_Result_);
			return cb_onSuccess_Lcom_huawei_hms_support_api_client_Result_;
		}

		static IntPtr n_OnSuccess_Lcom_huawei_hms_support_api_client_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.ResultConvert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Result> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnSuccess (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Result']]"
		[Register ("onSuccess", "(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/support/api/client/PendingResult;", "GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler")]
		public abstract global::Huawei.Hms.Support.Api.Client.PendingResult OnSuccess (global::Huawei.Hms.Support.Api.Client.Result p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ResultConvert", DoNotGenerateAcw=true)]
	internal partial class ResultConvertInvoker : ResultConvert {

		public ResultConvertInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ResultConvert", typeof (ResultConvertInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='ResultConvert']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Result']]"
		[Register ("onSuccess", "(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/support/api/client/PendingResult;", "GetOnSuccess_Lcom_huawei_hms_support_api_client_Result_Handler")]
		public override unsafe global::Huawei.Hms.Support.Api.Client.PendingResult OnSuccess (global::Huawei.Hms.Support.Api.Client.Result p0)
		{
			const string __id = "onSuccess.(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
