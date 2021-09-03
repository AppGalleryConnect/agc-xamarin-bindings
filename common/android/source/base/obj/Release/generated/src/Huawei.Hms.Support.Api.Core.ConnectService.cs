using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/core/ConnectService", DoNotGenerateAcw=true)]
	public sealed partial class ConnectService : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/core/ConnectService", typeof (ConnectService));
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

		internal ConnectService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']/method[@name='checkconnect' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.entity.core.CheckConnectInfo']]"
		[Register ("checkconnect", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/CheckConnectInfo;)Lcom/huawei/hms/support/api/client/InnerPendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.InnerPendingResult Checkconnect (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Entity.Core.CheckConnectInfo p1)
		{
			const string __id = "checkconnect.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/CheckConnectInfo;)Lcom/huawei/hms/support/api/client/InnerPendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.InnerPendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.entity.core.ConnectInfo']]"
		[Register ("connect", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/ConnectInfo;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult Connect (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo p1)
		{
			const string __id = "connect.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/ConnectInfo;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.entity.core.DisconnectInfo']]"
		[Register ("disconnect", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/DisconnectInfo;)Lcom/huawei/hms/support/api/ResolvePendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.ResolvePendingResult Disconnect (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Entity.Core.DisconnectInfo p1)
		{
			const string __id = "disconnect.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/DisconnectInfo;)Lcom/huawei/hms/support/api/ResolvePendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolvePendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']/method[@name='forceConnect' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.entity.core.ConnectInfo']]"
		[Register ("forceConnect", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/ConnectInfo;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult ForceConnect (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo p1)
		{
			const string __id = "forceConnect.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/entity/core/ConnectInfo;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.core']/class[@name='ConnectService']/method[@name='getNotice' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getNotice", "(Lcom/huawei/hms/support/api/client/ApiClient;ILjava/lang/String;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult GetNotice (global::Huawei.Hms.Support.Api.Client.IApiClient p0, int p1, string p2)
		{
			const string __id = "getNotice.(Lcom/huawei/hms/support/api/client/ApiClient;ILjava/lang/String;)Lcom/huawei/hms/support/api/client/PendingResult;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
