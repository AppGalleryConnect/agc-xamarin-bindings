using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']"
	[Register ("com/huawei/hms/support/api/client/ApiClient", "", "Huawei.Hms.Support.Api.Client.IApiClientInvoker")]
	public partial interface IApiClient : IJavaObject, IJavaPeerable {

		string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		string CpID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getCpID' and count(parameter)=0]"
			[Register ("getCpID", "()Ljava/lang/String;", "GetGetCpIDHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		global::Huawei.Hms.Support.Api.Client.SubAppInfo SubAppInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getSubAppInfo' and count(parameter)=0]"
			[Register ("getSubAppInfo", "()Lcom/huawei/hms/support/api/client/SubAppInfo;", "GetGetSubAppInfoHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

		string TransportName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/interface[@name='ApiClient']/method[@name='getTransportName' and count(parameter)=0]"
			[Register ("getTransportName", "()Ljava/lang/String;", "GetGetTransportNameHandler:Huawei.Hms.Support.Api.Client.IApiClientInvoker, Huawei.Hms.Base")] get;
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/ApiClient", DoNotGenerateAcw=true)]
	internal partial class IApiClientInvoker : global::Java.Lang.Object, IApiClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/ApiClient", typeof (IApiClientInvoker));

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

		public static IApiClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.client.ApiClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppID;
#pragma warning disable 0169
		static Delegate GetGetAppIDHandler ()
		{
			if (cb_getAppID == null)
				cb_getAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppID);
			return cb_getAppID;
		}

		static IntPtr n_GetAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		IntPtr id_getAppID;
		public unsafe string AppID {
			get {
				if (id_getAppID == IntPtr.Zero)
					id_getAppID = JNIEnv.GetMethodID (class_ref, "getAppID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		IntPtr id_getContext;
		public unsafe global::Android.Content.Context Context {
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCpID;
#pragma warning disable 0169
		static Delegate GetGetCpIDHandler ()
		{
			if (cb_getCpID == null)
				cb_getCpID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCpID);
			return cb_getCpID;
		}

		static IntPtr n_GetCpID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CpID);
		}
#pragma warning restore 0169

		IntPtr id_getCpID;
		public unsafe string CpID {
			get {
				if (id_getCpID == IntPtr.Zero)
					id_getCpID = JNIEnv.GetMethodID (class_ref, "getCpID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCpID), JniHandleOwnership.TransferLocalRef);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		IntPtr id_getPackageName;
		public unsafe string PackageName {
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getSubAppInfo;
#pragma warning disable 0169
		static Delegate GetGetSubAppInfoHandler ()
		{
			if (cb_getSubAppInfo == null)
				cb_getSubAppInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubAppInfo);
			return cb_getSubAppInfo;
		}

		static IntPtr n_GetSubAppInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubAppInfo);
		}
#pragma warning restore 0169

		IntPtr id_getSubAppInfo;
		public unsafe global::Huawei.Hms.Support.Api.Client.SubAppInfo SubAppInfo {
			get {
				if (id_getSubAppInfo == IntPtr.Zero)
					id_getSubAppInfo = JNIEnv.GetMethodID (class_ref, "getSubAppInfo", "()Lcom/huawei/hms/support/api/client/SubAppInfo;");
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubAppInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTransportName;
#pragma warning disable 0169
		static Delegate GetGetTransportNameHandler ()
		{
			if (cb_getTransportName == null)
				cb_getTransportName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransportName);
			return cb_getTransportName;
		}

		static IntPtr n_GetTransportName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransportName);
		}
#pragma warning restore 0169

		IntPtr id_getTransportName;
		public unsafe string TransportName {
			get {
				if (id_getTransportName == IntPtr.Zero)
					id_getTransportName = JNIEnv.GetMethodID (class_ref, "getTransportName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransportName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
