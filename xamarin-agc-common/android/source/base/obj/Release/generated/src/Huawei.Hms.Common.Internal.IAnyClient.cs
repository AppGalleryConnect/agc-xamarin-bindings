using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient.CallBack']"
	[Register ("com/huawei/hms/common/internal/AnyClient$CallBack", "", "Huawei.Hms.Common.Internal.IAnyClientCallBackInvoker")]
	public partial interface IAnyClientCallBack : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient.CallBack']/method[@name='onCallback' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[2][@type='java.lang.String']]"
		[Register ("onCallback", "(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;)V", "GetOnCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Handler:Huawei.Hms.Common.Internal.IAnyClientCallBackInvoker, Huawei.Hms.Base")]
		void OnCallback (global::Huawei.Hms.Core.Aidl.IMessageEntity p0, string p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/AnyClient$CallBack", DoNotGenerateAcw=true)]
	internal partial class IAnyClientCallBackInvoker : global::Java.Lang.Object, IAnyClientCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/AnyClient$CallBack", typeof (IAnyClientCallBackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAnyClientCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnyClientCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.internal.AnyClient.CallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnyClientCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Handler ()
		{
			if (cb_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_ == null)
				cb_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_);
			return cb_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_;
		}

		static void n_OnCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClientCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Core.Aidl.IMessageEntity)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.IMessageEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCallback (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_;
		public unsafe void OnCallback (global::Huawei.Hms.Core.Aidl.IMessageEntity p0, string p1)
		{
			if (id_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_ == IntPtr.Zero)
				id_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCallback", "(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallback_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']"
	[Register ("com/huawei/hms/common/internal/AnyClient", "", "Huawei.Hms.Common.Internal.IAnyClientInvoker")]
	public partial interface IAnyClient : IJavaObject, IJavaPeerable {

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")] get;
		}

		bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")] get;
		}

		string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connect", "(I)V", "GetConnect_IHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")]
		void Connect (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(IZ)V", "GetConnect_IZHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")]
		void Connect (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='AnyClient']/method[@name='post' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.common.internal.AnyClient.CallBack']]"
		[Register ("post", "(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;Lcom/huawei/hms/common/internal/AnyClient$CallBack;)V", "GetPost_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_Handler:Huawei.Hms.Common.Internal.IAnyClientInvoker, Huawei.Hms.Base")]
		void Post (global::Huawei.Hms.Core.Aidl.IMessageEntity p0, string p1, global::Huawei.Hms.Common.Internal.IAnyClientCallBack p2);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/AnyClient", DoNotGenerateAcw=true)]
	internal partial class IAnyClientInvoker : global::Java.Lang.Object, IAnyClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/AnyClient", typeof (IAnyClientInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAnyClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnyClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.internal.AnyClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnyClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public unsafe bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		IntPtr id_isConnecting;
		public unsafe bool IsConnecting {
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting);
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		IntPtr id_getSessionId;
		public unsafe string SessionId {
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_connect_I;
#pragma warning disable 0169
		static Delegate GetConnect_IHandler ()
		{
			if (cb_connect_I == null)
				cb_connect_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Connect_I);
			return cb_connect_I;
		}

		static void n_Connect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		IntPtr id_connect_I;
		public unsafe void Connect (int p0)
		{
			if (id_connect_I == IntPtr.Zero)
				id_connect_I = JNIEnv.GetMethodID (class_ref, "connect", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_I, __args);
		}

		static Delegate cb_connect_IZ;
#pragma warning disable 0169
		static Delegate GetConnect_IZHandler ()
		{
			if (cb_connect_IZ == null)
				cb_connect_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_Connect_IZ);
			return cb_connect_IZ;
		}

		static void n_Connect_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_connect_IZ;
		public unsafe void Connect (int p0, bool p1)
		{
			if (id_connect_IZ == IntPtr.Zero)
				id_connect_IZ = JNIEnv.GetMethodID (class_ref, "connect", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_IZ, __args);
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Core.Aidl.IMessageEntity)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.IMessageEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Huawei.Hms.Common.Internal.IAnyClientCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClientCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_;
		public unsafe void Post (global::Huawei.Hms.Core.Aidl.IMessageEntity p0, string p1, global::Huawei.Hms.Common.Internal.IAnyClientCallBack p2)
		{
			if (id_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_ == IntPtr.Zero)
				id_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/String;Lcom/huawei/hms/common/internal/AnyClient$CallBack;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_huawei_hms_core_aidl_IMessageEntity_Ljava_lang_String_Lcom_huawei_hms_common_internal_AnyClient_CallBack_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
