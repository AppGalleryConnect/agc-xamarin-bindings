using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='ResolvePendingResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/ResolvePendingResult", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.huawei.hms.core.aidl.IMessageEntity"})]
	public partial class ResolvePendingResult : global::Huawei.Hms.Support.Api.PendingResultImpl {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/ResolvePendingResult", typeof (ResolvePendingResult));
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

		protected ResolvePendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='ResolvePendingResult']/constructor[@name='ResolvePendingResult' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[4][@type='java.lang.Class&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V", "")]
		protected unsafe ResolvePendingResult (global::Huawei.Hms.Support.Api.Client.IApiClient p0, string p1, global::Huawei.Hms.Core.Aidl.IMessageEntity p2, global::Java.Lang.Class p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='ResolvePendingResult']/method[@name='build' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[4][@type='java.lang.Class&lt;R&gt;']]"
		[Register ("build", "(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)Lcom/huawei/hms/support/api/ResolvePendingResult;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.core.aidl.IMessageEntity"})]
		public static unsafe global::Huawei.Hms.Support.Api.ResolvePendingResult Build (global::Huawei.Hms.Support.Api.Client.IApiClient p0, string p1, global::Huawei.Hms.Core.Aidl.IMessageEntity p2, global::Java.Lang.Class p3)
		{
			const string __id = "build.(Lcom/huawei/hms/support/api/client/ApiClient;Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)Lcom/huawei/hms/support/api/ResolvePendingResult;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolvePendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolvePendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='ResolvePendingResult']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/huawei/hms/core/aidl/IMessageEntity;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Lcom/huawei/hms/core/aidl/IMessageEntity;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_Handler ()
		{
			if (cb_onComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_ == null)
				cb_onComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_);
			return cb_onComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_;
		}

		static IntPtr n_OnComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolvePendingResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnComplete (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api']/class[@name='ResolvePendingResult']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onComplete", "(Lcom/huawei/hms/core/aidl/IMessageEntity;)Lcom/huawei/hms/support/api/ResolveResult;", "GetOnComplete_Lcom_huawei_hms_core_aidl_IMessageEntity_Handler")]
		public virtual unsafe global::Java.Lang.Object OnComplete (global::Java.Lang.Object p0)
		{
			const string __id = "onComplete.(Lcom/huawei/hms/core/aidl/IMessageEntity;)Lcom/huawei/hms/support/api/ResolveResult;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolveResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
