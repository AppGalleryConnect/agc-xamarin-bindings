using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/HuaweiApiManager", DoNotGenerateAcw=true)]
	public partial class HuaweiApiManager : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager.ConnectionManager']"
		[global::Android.Runtime.Register ("com/huawei/hms/common/internal/HuaweiApiManager$ConnectionManager", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"OptionsT extends com.huawei.hms.api.Api.ApiOptions"})]
		public partial class ConnectionManager : global::Java.Lang.Object, global::Huawei.Hms.Common.Internal.BaseHmsClient.IConnectionCallbacks, global::Huawei.Hms.Common.Internal.BaseHmsClient.IOnConnectionFailedListener {


			public static class InterfaceConsts {

				// The following are fields from: com.huawei.hms.common.internal.BaseHmsClient.ConnectionCallbacks

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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/HuaweiApiManager$ConnectionManager", typeof (ConnectionManager));
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

			protected ConnectionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager.ConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnected ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager.ConnectionManager']/method[@name='onConnected' and count(parameter)=0]"
			[Register ("onConnected", "()V", "GetOnConnectedHandler")]
			public virtual unsafe void OnConnected ()
			{
				const string __id = "onConnected.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
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
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager.ConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionFailed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager.ConnectionManager']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.ConnectionResult']]"
			[Register ("onConnectionFailed", "(Lcom/huawei/hms/api/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_Handler")]
			public virtual unsafe void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				const string __id = "onConnectionFailed.(Lcom/huawei/hms/api/ConnectionResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
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
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager.ConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionSuspended (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager.ConnectionManager']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler")]
			public virtual unsafe void OnConnectionSuspended (int p0)
			{
				const string __id = "onConnectionSuspended.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/HuaweiApiManager", typeof (HuaweiApiManager));
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

		protected HuaweiApiManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_disconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
#pragma warning disable 0169
		static Delegate GetDisconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler ()
		{
			if (cb_disconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_ == null)
				cb_disconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DisconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_);
			return cb_disconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_;
		}

		static void n_DisconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.TaskCompletionSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectService (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager']/method[@name='disconnectService' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.HuaweiApi&lt;?&gt;'] and parameter[2][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;java.lang.Boolean&gt;']]"
		[Register ("disconnectService", "(Lcom/huawei/hms/common/HuaweiApi;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "GetDisconnectService_Lcom_huawei_hms_common_HuaweiApi_Lcom_huawei_hmf_tasks_TaskCompletionSource_Handler")]
		public virtual unsafe void DisconnectService (global::Huawei.Hms.Common.HuaweiApi p0, global::Huawei.Hmf.Tasks.TaskCompletionSource p1)
		{
			const string __id = "disconnectService.(Lcom/huawei/hms/common/HuaweiApi;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/common/internal/HuaweiApiManager;", "")]
		public static unsafe global::Huawei.Hms.Common.Internal.HuaweiApiManager GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/common/internal/HuaweiApiManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.HuaweiApiManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='HuaweiApiManager']/method[@name='sendRequest' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.common.HuaweiApi&lt;TOption&gt;'] and parameter[2][@type='com.huawei.hms.common.internal.TaskApiCall&lt;? extends com.huawei.hms.common.internal.AnyClient, TResult&gt;'] and parameter[3][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;TResult&gt;']]"
		[Register ("sendRequest", "(Lcom/huawei/hms/common/HuaweiApi;Lcom/huawei/hms/common/internal/TaskApiCall;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TOption extends com.huawei.hms.api.Api.ApiOptions", "TResult"})]
		public unsafe void SendRequest (global::Huawei.Hms.Common.HuaweiApi p0, global::Huawei.Hms.Common.Internal.TaskApiCall p1, global::Huawei.Hmf.Tasks.TaskCompletionSource p2)
		{
			const string __id = "sendRequest.(Lcom/huawei/hms/common/HuaweiApi;Lcom/huawei/hms/common/internal/TaskApiCall;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
