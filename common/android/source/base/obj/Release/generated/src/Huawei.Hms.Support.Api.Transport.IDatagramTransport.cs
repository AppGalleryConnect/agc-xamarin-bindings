using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Transport {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.transport']/interface[@name='DatagramTransport.CallBack']"
	[Register ("com/huawei/hms/support/api/transport/DatagramTransport$CallBack", "", "Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBackInvoker")]
	public partial interface IDatagramTransportCallBack : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.transport']/interface[@name='DatagramTransport.CallBack']/method[@name='onCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.huawei.hms.core.aidl.IMessageEntity']]"
		[Register ("onCallback", "(ILcom/huawei/hms/core/aidl/IMessageEntity;)V", "GetOnCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_Handler:Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBackInvoker, Huawei.Hms.Base")]
		void OnCallback (int p0, global::Huawei.Hms.Core.Aidl.IMessageEntity p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/transport/DatagramTransport$CallBack", DoNotGenerateAcw=true)]
	internal partial class IDatagramTransportCallBackInvoker : global::Java.Lang.Object, IDatagramTransportCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/transport/DatagramTransport$CallBack", typeof (IDatagramTransportCallBackInvoker));

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

		public static IDatagramTransportCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatagramTransportCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.transport.DatagramTransport.CallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatagramTransportCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_;
#pragma warning disable 0169
		static Delegate GetOnCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_Handler ()
		{
			if (cb_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_ == null)
				cb_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_);
			return cb_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_;
		}

		static void n_OnCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Core.Aidl.IMessageEntity)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.IMessageEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCallback (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_;
		public unsafe void OnCallback (int p0, global::Huawei.Hms.Core.Aidl.IMessageEntity p1)
		{
			if (id_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_ == IntPtr.Zero)
				id_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_ = JNIEnv.GetMethodID (class_ref, "onCallback", "(ILcom/huawei/hms/core/aidl/IMessageEntity;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallback_ILcom_huawei_hms_core_aidl_IMessageEntity_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.transport']/interface[@name='DatagramTransport']"
	[Register ("com/huawei/hms/support/api/transport/DatagramTransport", "", "Huawei.Hms.Support.Api.Transport.IDatagramTransportInvoker")]
	public partial interface IDatagramTransport : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.transport']/interface[@name='DatagramTransport']/method[@name='post' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.transport.DatagramTransport.CallBack']]"
		[Register ("post", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V", "GetPost_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_Handler:Huawei.Hms.Support.Api.Transport.IDatagramTransportInvoker, Huawei.Hms.Base")]
		void Post (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.transport']/interface[@name='DatagramTransport']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.transport.DatagramTransport.CallBack']]"
		[Register ("send", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V", "GetSend_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_Handler:Huawei.Hms.Support.Api.Transport.IDatagramTransportInvoker, Huawei.Hms.Base")]
		void Send (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/transport/DatagramTransport", DoNotGenerateAcw=true)]
	internal partial class IDatagramTransportInvoker : global::Java.Lang.Object, IDatagramTransport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/transport/DatagramTransport", typeof (IDatagramTransportInvoker));

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

		public static IDatagramTransport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatagramTransport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.transport.DatagramTransport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatagramTransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_Handler ()
		{
			if (cb_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ == null)
				cb_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_);
			return cb_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
		}

		static void n_Post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IApiClient)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
		public unsafe void Post (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1)
		{
			if (id_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ == IntPtr.Zero)
				id_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_, __args);
		}

		static Delegate cb_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_Handler ()
		{
			if (cb_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ == null)
				cb_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_);
			return cb_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
		}

		static void n_Send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Support.Api.Client.IApiClient)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_;
		public unsafe void Send (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1)
		{
			if (id_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ == IntPtr.Zero)
				id_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Lcom_huawei_hms_support_api_client_ApiClient_Lcom_huawei_hms_support_api_transport_DatagramTransport_CallBack_, __args);
		}

	}

}
