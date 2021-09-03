using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClientImpl", DoNotGenerateAcw=true)]
	public partial class HuaweiApiClientImpl : global::Huawei.Hms.Api.HuaweiApiClient, global::Android.Content.IServiceConnection {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/field[@name='DEFAULT_ACCOUNT']"
		[Register ("DEFAULT_ACCOUNT")]
		public const string DefaultAccount = (string) "<<default account>>";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/field[@name='SIGN_IN_MODE_OPTIONAL']"
		[Register ("SIGN_IN_MODE_OPTIONAL")]
		public const int SignInModeOptional = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/field[@name='SIGN_IN_MODE_REQUIRED']"
		[Register ("SIGN_IN_MODE_REQUIRED")]
		public const int SignInModeRequired = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClientImpl", typeof (HuaweiApiClientImpl));
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

		protected HuaweiApiClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/constructor[@name='HuaweiApiClientImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HuaweiApiClientImpl (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getApiMap;
#pragma warning disable 0169
		static Delegate GetGetApiMapHandler ()
		{
			if (cb_getApiMap == null)
				cb_getApiMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiMap);
			return cb_getApiMap;
		}

		static IntPtr n_GetApiMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.ToLocalJniHandle (__this.ApiMap);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions> ApiMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getApiMap' and count(parameter)=0]"
			[Register ("getApiMap", "()Ljava/util/Map;", "GetGetApiMapHandler")]
			get {
				const string __id = "getApiMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApiNameList;
#pragma warning disable 0169
		static Delegate GetGetApiNameListHandler ()
		{
			if (cb_getApiNameList == null)
				cb_getApiNameList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiNameList);
			return cb_getApiNameList;
		}

		static IntPtr n_GetApiNameList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ApiNameList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiNameList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getApiNameList' and count(parameter)=0]"
			[Register ("getApiNameList", "()Ljava/util/List;", "GetGetApiNameListHandler")]
			get {
				const string __id = "getApiNameList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CpID);
		}
#pragma warning restore 0169

		public virtual unsafe string CpID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getCpID' and count(parameter)=0]"
			[Register ("getCpID", "()Ljava/lang/String;", "GetGetCpIDHandler")]
			get {
				const string __id = "getCpID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public override unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public override unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				const string __id = "isConnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPermissionInfos;
#pragma warning disable 0169
		static Delegate GetGetPermissionInfosHandler ()
		{
			if (cb_getPermissionInfos == null)
				cb_getPermissionInfos = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPermissionInfos);
			return cb_getPermissionInfos;
		}

		static IntPtr n_GetPermissionInfos (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.ToLocalJniHandle (__this.PermissionInfos);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo> PermissionInfos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getPermissionInfos' and count(parameter)=0]"
			[Register ("getPermissionInfos", "()Ljava/util/List;", "GetGetPermissionInfosHandler")]
			get {
				const string __id = "getPermissionInfos.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Huawei.Hms.Support.Api.Client.SubAppInfo SubAppInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getSubAppInfo' and count(parameter)=0]"
			[Register ("getSubAppInfo", "()Lcom/huawei/hms/support/api/client/SubAppInfo;", "")]
			get {
				const string __id = "getSubAppInfo.()Lcom/huawei/hms/support/api/client/SubAppInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopActivity;
#pragma warning disable 0169
		static Delegate GetGetTopActivityHandler ()
		{
			if (cb_getTopActivity == null)
				cb_getTopActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTopActivity);
			return cb_getTopActivity;
		}

		static IntPtr n_GetTopActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopActivity);
		}
#pragma warning restore 0169

		public override unsafe global::Android.App.Activity TopActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getTopActivity' and count(parameter)=0]"
			[Register ("getTopActivity", "()Landroid/app/Activity;", "GetGetTopActivityHandler")]
			get {
				const string __id = "getTopActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransportName);
		}
#pragma warning restore 0169

		public virtual unsafe string TransportName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getTransportName' and count(parameter)=0]"
			[Register ("getTransportName", "()Ljava/lang/String;", "GetGetTransportNameHandler")]
			get {
				const string __id = "getTransportName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_;
#pragma warning disable 0169
		static Delegate GetAsyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_Handler ()
		{
			if (cb_asyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_ == null)
				cb_asyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLIL_I) n_AsyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_);
			return cb_asyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_;
		}

		static int n_AsyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Huawei.Hms.Support.Api.Client.IResultCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.IResultCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AsyncRequest (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='asyncRequest' and count(parameter)=4 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.huawei.hms.support.api.client.ResultCallback&lt;com.huawei.hms.support.api.client.BundleResult&gt;']]"
		[Register ("asyncRequest", "(Landroid/os/Bundle;Ljava/lang/String;ILcom/huawei/hms/support/api/client/ResultCallback;)I", "GetAsyncRequest_Landroid_os_Bundle_Ljava_lang_String_ILcom_huawei_hms_support_api_client_ResultCallback_Handler")]
		public virtual unsafe int AsyncRequest (global::Android.OS.Bundle p0, string p1, int p2, global::Huawei.Hms.Support.Api.Client.IResultCallback p3)
		{
			const string __id = "asyncRequest.(Landroid/os/Bundle;Ljava/lang/String;ILcom/huawei/hms/support/api/client/ResultCallback;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_;
#pragma warning disable 0169
		static Delegate GetCheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_Handler ()
		{
			if (cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ == null)
				cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_);
			return cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_;
		}

		static void n_CheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Api.ICheckUpdatelistener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ICheckUpdatelistener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckUpdate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='checkUpdate' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.CheckUpdatelistener']]"
		[Register ("checkUpdate", "(Landroid/app/Activity;Lcom/huawei/hms/api/CheckUpdatelistener;)V", "GetCheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_Handler")]
		public override unsafe void CheckUpdate (global::Android.App.Activity p0, global::Huawei.Hms.Api.ICheckUpdatelistener p1)
		{
			const string __id = "checkUpdate.(Landroid/app/Activity;Lcom/huawei/hms/api/CheckUpdatelistener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_connect_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_app_Activity_Handler ()
		{
			if (cb_connect_Landroid_app_Activity_ == null)
				cb_connect_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Connect_Landroid_app_Activity_);
			return cb_connect_Landroid_app_Activity_;
		}

		static void n_Connect_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("connect", "(Landroid/app/Activity;)V", "GetConnect_Landroid_app_Activity_Handler")]
		public override unsafe void Connect (global::Android.App.Activity p0)
		{
			const string __id = "connect.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_connectForeground;
#pragma warning disable 0169
		static Delegate GetConnectForegroundHandler ()
		{
			if (cb_connectForeground == null)
				cb_connectForeground = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ConnectForeground);
			return cb_connectForeground;
		}

		static void n_ConnectForeground (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectForeground ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='connectForeground' and count(parameter)=0]"
		[Register ("connectForeground", "()V", "GetConnectForegroundHandler")]
		public override unsafe void ConnectForeground ()
		{
			const string __id = "connectForeground.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableLifeCycleManagement_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetDisableLifeCycleManagement_Landroid_app_Activity_Handler ()
		{
			if (cb_disableLifeCycleManagement_Landroid_app_Activity_ == null)
				cb_disableLifeCycleManagement_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DisableLifeCycleManagement_Landroid_app_Activity_);
			return cb_disableLifeCycleManagement_Landroid_app_Activity_;
		}

		static void n_DisableLifeCycleManagement_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisableLifeCycleManagement (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='disableLifeCycleManagement' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("disableLifeCycleManagement", "(Landroid/app/Activity;)V", "GetDisableLifeCycleManagement_Landroid_app_Activity_Handler")]
		public override unsafe void DisableLifeCycleManagement (global::Android.App.Activity p0)
		{
			const string __id = "disableLifeCycleManagement.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_discardAndReconnect;
#pragma warning disable 0169
		static Delegate GetDiscardAndReconnectHandler ()
		{
			if (cb_discardAndReconnect == null)
				cb_discardAndReconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DiscardAndReconnect);
			return cb_discardAndReconnect;
		}

		static IntPtr n_DiscardAndReconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DiscardAndReconnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='discardAndReconnect' and count(parameter)=0]"
		[Register ("discardAndReconnect", "()Lcom/huawei/hms/support/api/client/PendingResult;", "GetDiscardAndReconnectHandler")]
		public override unsafe global::Huawei.Hms.Support.Api.Client.PendingResult DiscardAndReconnect ()
		{
			const string __id = "discardAndReconnect.()Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public override unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getConnectionResult_Lcom_huawei_hms_api_Api_;
#pragma warning disable 0169
		static Delegate GetGetConnectionResult_Lcom_huawei_hms_api_Api_Handler ()
		{
			if (cb_getConnectionResult_Lcom_huawei_hms_api_Api_ == null)
				cb_getConnectionResult_Lcom_huawei_hms_api_Api_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConnectionResult_Lcom_huawei_hms_api_Api_);
			return cb_getConnectionResult_Lcom_huawei_hms_api_Api_;
		}

		static IntPtr n_GetConnectionResult_Lcom_huawei_hms_api_Api_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='getConnectionResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("getConnectionResult", "(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/ConnectionResult;", "GetGetConnectionResult_Lcom_huawei_hms_api_Api_Handler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult GetConnectionResult (global::Huawei.Hms.Api.Api p0)
		{
			const string __id = "getConnectionResult.(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hasConnectedApi_Lcom_huawei_hms_api_Api_;
#pragma warning disable 0169
		static Delegate GetHasConnectedApi_Lcom_huawei_hms_api_Api_Handler ()
		{
			if (cb_hasConnectedApi_Lcom_huawei_hms_api_Api_ == null)
				cb_hasConnectedApi_Lcom_huawei_hms_api_Api_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectedApi_Lcom_huawei_hms_api_Api_);
			return cb_hasConnectedApi_Lcom_huawei_hms_api_Api_;
		}

		static bool n_HasConnectedApi_Lcom_huawei_hms_api_Api_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectedApi (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='hasConnectedApi' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("hasConnectedApi", "(Lcom/huawei/hms/api/Api;)Z", "GetHasConnectedApi_Lcom_huawei_hms_api_Api_Handler")]
		public override unsafe bool HasConnectedApi (global::Huawei.Hms.Api.Api p0)
		{
			const string __id = "hasConnectedApi.(Lcom/huawei/hms/api/Api;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetHasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static bool n_HasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectionFailureListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='hasConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("hasConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Z", "GetHasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe bool HasConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "hasConnectionFailureListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetHasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static bool n_HasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectionSuccessListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='hasConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("hasConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Z", "GetHasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe bool HasConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "hasConnectionSuccessListener.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_holdUpConnect;
#pragma warning disable 0169
		static Delegate GetHoldUpConnectHandler ()
		{
			if (cb_holdUpConnect == null)
				cb_holdUpConnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_HoldUpConnect);
			return cb_holdUpConnect;
		}

		static IntPtr n_HoldUpConnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HoldUpConnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='holdUpConnect' and count(parameter)=0]"
		[Register ("holdUpConnect", "()Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnectHandler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult HoldUpConnect ()
		{
			const string __id = "holdUpConnect.()Lcom/huawei/hms/api/ConnectionResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetHoldUpConnect_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_ == null)
				cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_HoldUpConnect_JLjava_util_concurrent_TimeUnit_);
			return cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_HoldUpConnect_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HoldUpConnect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='holdUpConnect' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("holdUpConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnect_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult HoldUpConnect (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "holdUpConnect.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_innerIsConnected;
#pragma warning disable 0169
		static Delegate GetInnerIsConnectedHandler ()
		{
			if (cb_innerIsConnected == null)
				cb_innerIsConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_InnerIsConnected);
			return cb_innerIsConnected;
		}

		static bool n_InnerIsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InnerIsConnected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='innerIsConnected' and count(parameter)=0]"
		[Register ("innerIsConnected", "()Z", "GetInnerIsConnectedHandler")]
		public virtual unsafe bool InnerIsConnected ()
		{
			const string __id = "innerIsConnected.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onPause_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPause_Landroid_app_Activity_Handler ()
		{
			if (cb_onPause_Landroid_app_Activity_ == null)
				cb_onPause_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPause_Landroid_app_Activity_);
			return cb_onPause_Landroid_app_Activity_;
		}

		static void n_OnPause_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler")]
		public override unsafe void OnPause (global::Android.App.Activity p0)
		{
			const string __id = "onPause.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onResume_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnResume_Landroid_app_Activity_Handler ()
		{
			if (cb_onResume_Landroid_app_Activity_ == null)
				cb_onResume_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResume_Landroid_app_Activity_);
			return cb_onResume_Landroid_app_Activity_;
		}

		static void n_OnResume_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "GetOnResume_Landroid_app_Activity_Handler")]
		public override unsafe void OnResume (global::Android.App.Activity p0)
		{
			const string __id = "onResume.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName p0)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrint_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler ()
		{
			if (cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
				cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_);
			return cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		static void n_Print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.PrintWriter> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Print (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='print' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.FileDescriptor'] and parameter[3][@type='java.io.PrintWriter'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("print", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetPrint_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public override unsafe void Print (string p0, global::Java.IO.FileDescriptor p1, global::Java.IO.PrintWriter p2, string[] p3)
		{
			const string __id = "print.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public override unsafe void Reconnect ()
		{
			const string __id = "reconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static void n_RemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionFailureListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='removeConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("removeConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetRemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe void RemoveConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "removeConnectionFailureListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static void n_RemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionSuccessListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='removeConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("removeConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetRemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe void RemoveConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "removeConnectionSuccessListener.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setApiMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetApiMap_Ljava_util_Map_Handler ()
		{
			if (cb_setApiMap_Ljava_util_Map_ == null)
				cb_setApiMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetApiMap_Ljava_util_Map_);
			return cb_setApiMap_Ljava_util_Map_;
		}

		static void n_SetApiMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApiMap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setApiMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.huawei.hms.api.Api&lt;?&gt;, com.huawei.hms.api.Api.ApiOptions&gt;']]"
		[Register ("setApiMap", "(Ljava/util/Map;)V", "GetSetApiMap_Ljava_util_Map_Handler")]
		public virtual unsafe void SetApiMap (global::System.Collections.Generic.IDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions> p0)
		{
			const string __id = "setApiMap.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setAutoLifecycleClientId_I;
#pragma warning disable 0169
		static Delegate GetSetAutoLifecycleClientId_IHandler ()
		{
			if (cb_setAutoLifecycleClientId_I == null)
				cb_setAutoLifecycleClientId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAutoLifecycleClientId_I);
			return cb_setAutoLifecycleClientId_I;
		}

		static void n_SetAutoLifecycleClientId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoLifecycleClientId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setAutoLifecycleClientId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAutoLifecycleClientId", "(I)V", "GetSetAutoLifecycleClientId_IHandler")]
		protected virtual unsafe void SetAutoLifecycleClientId (int p0)
		{
			const string __id = "setAutoLifecycleClientId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetSetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static void n_SetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("setConnectionCallbacks", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetSetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe void SetConnectionCallbacks (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "setConnectionCallbacks.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetSetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static void n_SetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("setConnectionFailedListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetSetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe void SetConnectionFailedListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "setConnectionFailedListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setHasShowNotice_Z;
#pragma warning disable 0169
		static Delegate GetSetHasShowNotice_ZHandler ()
		{
			if (cb_setHasShowNotice_Z == null)
				cb_setHasShowNotice_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHasShowNotice_Z);
			return cb_setHasShowNotice_Z;
		}

		static void n_SetHasShowNotice_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHasShowNotice (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setHasShowNotice' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHasShowNotice", "(Z)V", "GetSetHasShowNotice_ZHandler")]
		public virtual unsafe void SetHasShowNotice (bool p0)
		{
			const string __id = "setHasShowNotice.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPermissionInfos_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPermissionInfos_Ljava_util_List_Handler ()
		{
			if (cb_setPermissionInfos_Ljava_util_List_ == null)
				cb_setPermissionInfos_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPermissionInfos_Ljava_util_List_);
			return cb_setPermissionInfos_Ljava_util_List_;
		}

		static void n_SetPermissionInfos_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPermissionInfos (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setPermissionInfos' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.PermissionInfo&gt;']]"
		[Register ("setPermissionInfos", "(Ljava/util/List;)V", "GetSetPermissionInfos_Ljava_util_List_Handler")]
		public virtual unsafe void SetPermissionInfos (global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo> p0)
		{
			const string __id = "setPermissionInfos.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setScopes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetScopes_Ljava_util_List_Handler ()
		{
			if (cb_setScopes_Ljava_util_List_ == null)
				cb_setScopes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScopes_Ljava_util_List_);
			return cb_setScopes_Ljava_util_List_;
		}

		static void n_SetScopes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScopes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setScopes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;']]"
		[Register ("setScopes", "(Ljava/util/List;)V", "GetSetScopes_Ljava_util_List_Handler")]
		public virtual unsafe void SetScopes (global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> p0)
		{
			const string __id = "setScopes.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
#pragma warning disable 0169
		static Delegate GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler ()
		{
			if (cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ == null)
				cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_);
			return cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
		}

		static bool n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSubAppInfo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClientImpl']/method[@name='setSubAppInfo' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register ("setSubAppInfo", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z", "GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler")]
		public override unsafe bool SetSubAppInfo (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0)
		{
			const string __id = "setSubAppInfo.(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

#region "Event implementation for Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener"
		public event EventHandler<global::Huawei.Hms.Api.HuaweiApiClient.ConnectionFailedEventArgs> ConnectionFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor>(
						ref weak_implementor_SetConnectionFailedListener,
						__CreateIOnConnectionFailedListenerImplementor,
						SetConnectionFailedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor>(
						ref weak_implementor_SetConnectionFailedListener,
						global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor.__IsEmpty,
						__v => SetConnectionFailedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConnectionFailedListener;

		global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor __CreateIOnConnectionFailedListenerImplementor ()
		{
			return new global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor (this);
		}
#endregion
	}
}
