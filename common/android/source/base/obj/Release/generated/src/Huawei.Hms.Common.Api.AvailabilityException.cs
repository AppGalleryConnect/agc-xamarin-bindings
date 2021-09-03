using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='AvailabilityException']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/api/AvailabilityException", DoNotGenerateAcw=true)]
	public partial class AvailabilityException : global::Java.Lang.Exception {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/AvailabilityException", typeof (AvailabilityException));
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

		protected AvailabilityException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='AvailabilityException']/constructor[@name='AvailabilityException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvailabilityException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_;
#pragma warning disable 0169
		static Delegate GetGetConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_Handler ()
		{
			if (cb_getConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_ == null)
				cb_getConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_);
			return cb_getConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_;
		}

		static IntPtr n_GetConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.AvailabilityException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Common.Api.IHuaweiApiCallable)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.IHuaweiApiCallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='AvailabilityException']/method[@name='getConnectionResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.api.HuaweiApiCallable']]"
		[Register ("getConnectionResult", "(Lcom/huawei/hms/common/api/HuaweiApiCallable;)Lcom/huawei/hms/api/ConnectionResult;", "GetGetConnectionResult_Lcom_huawei_hms_common_api_HuaweiApiCallable_Handler")]
		public virtual unsafe global::Huawei.Hms.Api.ConnectionResult GetConnectionResult (global::Huawei.Hms.Common.Api.IHuaweiApiCallable p0)
		{
			const string __id = "getConnectionResult.(Lcom/huawei/hms/common/api/HuaweiApiCallable;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getConnectionResult_Lcom_huawei_hms_common_HuaweiApi_;
#pragma warning disable 0169
		static Delegate GetGetConnectionResult_Lcom_huawei_hms_common_HuaweiApi_Handler ()
		{
			if (cb_getConnectionResult_Lcom_huawei_hms_common_HuaweiApi_ == null)
				cb_getConnectionResult_Lcom_huawei_hms_common_HuaweiApi_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConnectionResult_Lcom_huawei_hms_common_HuaweiApi_);
			return cb_getConnectionResult_Lcom_huawei_hms_common_HuaweiApi_;
		}

		static IntPtr n_GetConnectionResult_Lcom_huawei_hms_common_HuaweiApi_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.AvailabilityException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='AvailabilityException']/method[@name='getConnectionResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.HuaweiApi&lt;? extends com.huawei.hms.api.Api.ApiOptions&gt;']]"
		[Register ("getConnectionResult", "(Lcom/huawei/hms/common/HuaweiApi;)Lcom/huawei/hms/api/ConnectionResult;", "GetGetConnectionResult_Lcom_huawei_hms_common_HuaweiApi_Handler")]
		public virtual unsafe global::Huawei.Hms.Api.ConnectionResult GetConnectionResult (global::Huawei.Hms.Common.HuaweiApi p0)
		{
			const string __id = "getConnectionResult.(Lcom/huawei/hms/common/HuaweiApi;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
