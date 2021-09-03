using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HmsClient']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/HmsClient", DoNotGenerateAcw=true)]
	public abstract partial class HmsClient : global::Huawei.Hms.Common.Internal.BaseHmsClient, global::Huawei.Hms.Common.Internal.IAnyClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/HmsClient", typeof (HmsClient));
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

		protected HmsClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HmsClient']/constructor[@name='HmsClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.common.internal.ClientSettings'] and parameter[3][@type='com.huawei.hms.common.internal.BaseHmsClient.OnConnectionFailedListener'] and parameter[4][@type='com.huawei.hms.common.internal.BaseHmsClient.ConnectionCallbacks']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/common/internal/ClientSettings;Lcom/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener;Lcom/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks;)V", "")]
		public unsafe HmsClient (global::Android.Content.Context p0, global::Huawei.Hms.Common.Internal.ClientSettings p1, global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener p2, global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/huawei/hms/common/internal/ClientSettings;Lcom/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener;Lcom/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_Handler ()
		{
			if (cb_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_ == null)
				cb_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_);
			return cb_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_;
		}

		static void n_Post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Core.Aidl.IMessageEntity)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.IMessageEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Huawei.Hms.Common.Internal.IAnyClientCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClientCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HmsClient']/method[@name='post' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.common.internal.AnyClient.CallBack']]"
		[Register ("post", "(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;Lcom/huawei/hms/common/internal/AnyClient$CallBack;)V", "GetPost_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_Handler")]
		public virtual unsafe void Post (global::Huawei.Hms.Core.Aidl.IMessageEntity p0, string p1, global::Huawei.Hms.Common.Internal.IAnyClientCallBack p2)
		{
			const string __id = "post.(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;Lcom/huawei/hms/common/internal/AnyClient$CallBack;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_updateSessionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSessionId_Ljava_lang_String_Handler ()
		{
			if (cb_updateSessionId_Ljava_lang_String_ == null)
				cb_updateSessionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateSessionId_Ljava_lang_String_);
			return cb_updateSessionId_Ljava_lang_String_;
		}

		static void n_UpdateSessionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSessionId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HmsClient']/method[@name='updateSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSessionId", "(Ljava/lang/String;)V", "GetUpdateSessionId_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateSessionId (string p0)
		{
			const string __id = "updateSessionId.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/HmsClient", DoNotGenerateAcw=true)]
	internal partial class HmsClientInvoker : HmsClient {

		public HmsClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/HmsClient", typeof (HmsClientInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
