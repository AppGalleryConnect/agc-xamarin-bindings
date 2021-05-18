using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/BaseHmsClient", DoNotGenerateAcw=true)]
	public abstract partial class BaseHmsClient : global::Java.Lang.Object {

		[Register ("com/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		public abstract class ConnectionCallbacks : Java.Lang.Object {

			internal ConnectionCallbacks ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']/field[@name='CAUSE_API_CLIENT_EXPIRED']"
			[Register ("CAUSE_API_CLIENT_EXPIRED")]
			public const int CauseApiClientExpired = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']/field[@name='CAUSE_NETWORK_LOST']"
			[Register ("CAUSE_NETWORK_LOST")]
			public const int CauseNetworkLost = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']/field[@name='CAUSE_SERVICE_DISCONNECTED']"
			[Register ("CAUSE_SERVICE_DISCONNECTED")]
			public const int CauseServiceDisconnected = (int) 1;
		}

		[Register ("com/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ConnectionCallbacks' type. This type will be removed in a future release.", error: true)]
		public abstract class ConnectionCallbacksConsts : ConnectionCallbacks {

			private ConnectionCallbacksConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']"
		[Register ("com/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks", "", "Huawei.Hms.Common.Internal.BaseHmsClient/IConnectionCallbacksInvoker")]
		public partial interface IConnectionCallbacks : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']/method[@name='onConnected' and count(parameter)=0]"
			[Register ("onConnected", "()V", "GetOnConnectedHandler:Huawei.Hms.Common.Internal.BaseHmsClient/IConnectionCallbacksInvoker, Huawei.Hms.Base")]
			void OnConnected ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.ConnectionCallbacks']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler:Huawei.Hms.Common.Internal.BaseHmsClient/IConnectionCallbacksInvoker, Huawei.Hms.Base")]
			void OnConnectionSuspended (int p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		internal partial class IConnectionCallbacksInvoker : global::Java.Lang.Object, IConnectionCallbacks {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks", typeof (IConnectionCallbacksInvoker));

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

			public static IConnectionCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnectionCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.internal.BaseHmsClient.ConnectionCallbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConnectionCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnected;
#pragma warning disable 0169
			static Delegate GetOnConnectedHandler ()
			{
				if (cb_onConnected == null)
					cb_onConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnected);
				return cb_onConnected;
			}

			static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnected ();
			}
#pragma warning restore 0169

			IntPtr id_onConnected;
			public unsafe void OnConnected ()
			{
				if (id_onConnected == IntPtr.Zero)
					id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
			}

			static Delegate cb_onConnectionSuspended_I;
#pragma warning disable 0169
			static Delegate GetOnConnectionSuspended_IHandler ()
			{
				if (cb_onConnectionSuspended_I == null)
					cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnConnectionSuspended_I);
				return cb_onConnectionSuspended_I;
			}

			static void n_OnConnectionSuspended_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionSuspended (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionSuspended_I;
			public unsafe void OnConnectionSuspended (int p0)
			{
				if (id_onConnectionSuspended_I == IntPtr.Zero)
					id_onConnectionSuspended_I = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended_I, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.OnConnectionFailedListener']"
		[Register ("com/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener", "", "Huawei.Hms.Common.Internal.BaseHmsClient/IOnConnectionFailedListenerInvoker")]
		public partial interface IOnConnectionFailedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='BaseHmsClient.OnConnectionFailedListener']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.ConnectionResult']]"
			[Register ("onConnectionFailed", "(Lcom/huawei/hms/api/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_Handler:Huawei.Hms.Common.Internal.BaseHmsClient/IOnConnectionFailedListenerInvoker, Huawei.Hms.Base")]
			void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener", DoNotGenerateAcw=true)]
		internal partial class IOnConnectionFailedListenerInvoker : global::Java.Lang.Object, IOnConnectionFailedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener", typeof (IOnConnectionFailedListenerInvoker));

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

			public static IOnConnectionFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnConnectionFailedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.internal.BaseHmsClient.OnConnectionFailedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnConnectionFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
#pragma warning disable 0169
			static Delegate GetOnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_Handler ()
			{
				if (cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ == null)
					cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_);
				return cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
			}

			static void n_OnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
			public unsafe void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				if (id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ == IntPtr.Zero)
					id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lcom/huawei/hms/api/ConnectionResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_, __args);
			}

		}

		// event args for com.huawei.hms.common.internal.BaseHmsClient.OnConnectionFailedListener.onConnectionFailed
		public partial class ConnectionFailedEventArgs : global::System.EventArgs {

			public ConnectionFailedEventArgs (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				this.p0 = p0;
			}

			global::Huawei.Hms.Api.ConnectionResult p0;
			public global::Huawei.Hms.Api.ConnectionResult P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/huawei/hms/common/internal/BaseHmsClient_OnConnectionFailedListenerImplementor")]
		internal sealed partial class IOnConnectionFailedListenerImplementor : global::Java.Lang.Object, IOnConnectionFailedListener {

			object sender;

			public IOnConnectionFailedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hms/common/internal/BaseHmsClient_OnConnectionFailedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ConnectionFailedEventArgs> Handler;
#pragma warning restore 0649

			public void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ConnectionFailedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnConnectionFailedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/BaseHmsClient", typeof (BaseHmsClient));
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

		protected BaseHmsClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/constructor[@name='BaseHmsClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.common.internal.ClientSettings'] and parameter[3][@type='com.huawei.hms.common.internal.BaseHmsClient.OnConnectionFailedListener'] and parameter[4][@type='com.huawei.hms.common.internal.BaseHmsClient.ConnectionCallbacks']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/common/internal/ClientSettings;Lcom/huawei/hms/common/internal/BaseHmsClient$OnConnectionFailedListener;Lcom/huawei/hms/common/internal/BaseHmsClient$ConnectionCallbacks;)V", "")]
		public unsafe BaseHmsClient (global::Android.Content.Context p0, global::Huawei.Hms.Common.Internal.ClientSettings p1, global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener p2, global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks p3)
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ApiNameList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiNameList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getApiNameList' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getAppID' and count(parameter)=0]"
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

		static Delegate cb_getClientSettings;
#pragma warning disable 0169
		static Delegate GetGetClientSettingsHandler ()
		{
			if (cb_getClientSettings == null)
				cb_getClientSettings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientSettings);
			return cb_getClientSettings;
		}

		static IntPtr n_GetClientSettings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientSettings);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Huawei.Hms.Common.Internal.ClientSettings ClientSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getClientSettings' and count(parameter)=0]"
			[Register ("getClientSettings", "()Lcom/huawei/hms/common/internal/ClientSettings;", "GetGetClientSettingsHandler")]
			get {
				const string __id = "getClientSettings.()Lcom/huawei/hms/common/internal/ClientSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ClientSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getContext' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CpID);
		}
#pragma warning restore 0169

		public virtual unsafe string CpID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getCpID' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='isConnected' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='isConnecting' and count(parameter)=0]"
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

		static Delegate cb_getMinApkVersion;
#pragma warning disable 0169
		static Delegate GetGetMinApkVersionHandler ()
		{
			if (cb_getMinApkVersion == null)
				cb_getMinApkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinApkVersion);
			return cb_getMinApkVersion;
		}

		static int n_GetMinApkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinApkVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int MinApkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getMinApkVersion' and count(parameter)=0]"
			[Register ("getMinApkVersion", "()I", "GetGetMinApkVersionHandler")]
			get {
				const string __id = "getMinApkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getPackageName' and count(parameter)=0]"
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

		static Delegate cb_getServiceAction;
#pragma warning disable 0169
		static Delegate GetGetServiceActionHandler ()
		{
			if (cb_getServiceAction == null)
				cb_getServiceAction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceAction);
			return cb_getServiceAction;
		}

		static IntPtr n_GetServiceAction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceAction);
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getServiceAction' and count(parameter)=0]"
			[Register ("getServiceAction", "()Ljava/lang/String;", "GetGetServiceActionHandler")]
			get {
				const string __id = "getServiceAction.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getSessionId' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubAppInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Support.Api.Client.SubAppInfo SubAppInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getSubAppInfo' and count(parameter)=0]"
			[Register ("getSubAppInfo", "()Lcom/huawei/hms/support/api/client/SubAppInfo;", "GetGetSubAppInfoHandler")]
			get {
				const string __id = "getSubAppInfo.()Lcom/huawei/hms/support/api/client/SubAppInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransportName);
		}
#pragma warning restore 0169

		public virtual unsafe string TransportName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='getTransportName' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='checkConnected' and count(parameter)=0]"
		[Register ("checkConnected", "()V", "")]
		protected unsafe void CheckConnected ()
		{
			const string __id = "checkConnected.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connect", "(I)V", "GetConnect_IHandler")]
		public virtual unsafe void Connect (int p0)
		{
			const string __id = "connect.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(IZ)V", "GetConnect_IZHandler")]
		public virtual unsafe void Connect (int p0, bool p1)
		{
			const string __id = "connect.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='connectionConnected' and count(parameter)=0]"
		[Register ("connectionConnected", "()V", "")]
		protected unsafe void ConnectionConnected ()
		{
			const string __id = "connectionConnected.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onConnecting;
#pragma warning disable 0169
		static Delegate GetOnConnectingHandler ()
		{
			if (cb_onConnecting == null)
				cb_onConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnecting);
			return cb_onConnecting;
		}

		static void n_OnConnecting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BaseHmsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnecting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BaseHmsClient']/method[@name='onConnecting' and count(parameter)=0]"
		[Register ("onConnecting", "()V", "GetOnConnectingHandler")]
		public virtual unsafe void OnConnecting ()
		{
			const string __id = "onConnecting.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/BaseHmsClient", DoNotGenerateAcw=true)]
	internal partial class BaseHmsClientInvoker : BaseHmsClient {

		public BaseHmsClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/BaseHmsClient", typeof (BaseHmsClientInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
