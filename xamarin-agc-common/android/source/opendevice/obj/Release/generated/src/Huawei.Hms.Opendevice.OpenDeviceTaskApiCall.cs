using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']"
	[global::Android.Runtime.Register ("com/huawei/hms/opendevice/OpenDeviceTaskApiCall", DoNotGenerateAcw=true)]
	public partial class OpenDeviceTaskApiCall : global::Huawei.Hms.Common.Internal.TaskApiCall {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/opendevice/OpenDeviceTaskApiCall", typeof (OpenDeviceTaskApiCall));
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

		protected OpenDeviceTaskApiCall (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']/constructor[@name='OpenDeviceTaskApiCall' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OpenDeviceTaskApiCall (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_doExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
#pragma warning disable 0169
		static Delegate GetDoExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler ()
		{
			if (cb_doExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ == null)
				cb_doExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_DoExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_);
			return cb_doExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
		}

		static void n_DoExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceTaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceHmsClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Common.Internal.IResponseErrorCode)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DoExecute (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']/method[@name='doExecute' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.opendevice.OpenDeviceHmsClient'] and parameter[2][@type='com.huawei.hms.common.internal.ResponseErrorCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;com.huawei.hms.support.api.opendevice.OdidResult&gt;']]"
		[Register ("doExecute", "(Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "GetDoExecute_Lcom_huawei_hms_opendevice_OpenDeviceHmsClient_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler")]
		public virtual unsafe void DoExecute (global::Huawei.Hms.Opendevice.OpenDeviceHmsClient p0, global::Huawei.Hms.Common.Internal.IResponseErrorCode p1, string p2, global::Huawei.Hmf.Tasks.TaskCompletionSource p3)
		{
			const string __id = "doExecute.(Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_doExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
#pragma warning disable 0169
		static Delegate GetDoExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler ()
		{
			if (cb_doExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ == null)
				cb_doExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_DoExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_);
			return cb_doExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
		}

		static void n_DoExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceTaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Common.Internal.IResponseErrorCode)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DoExecute (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']/method[@name='doExecute' and count(parameter)=4 and parameter[1][@type='Java.Lang.Object'] and parameter[2][@type='com.huawei.hms.common.internal.ResponseErrorCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;java.lang.Void&gt;']]"
		[Register ("doExecute", "(Ljava/lang/Object;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "GetDoExecute_Ljava_lang_Object_Lcom_huawei_hms_common_internal_ResponseErrorCode_Ljava_lang_String_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler")]
		protected virtual unsafe void DoExecute (global::Java.Lang.Object p0, global::Huawei.Hms.Common.Internal.IResponseErrorCode p1, string p2, global::Huawei.Hmf.Tasks.TaskCompletionSource p3)
		{
			const string __id = "doExecute.(Ljava/lang/Object;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
