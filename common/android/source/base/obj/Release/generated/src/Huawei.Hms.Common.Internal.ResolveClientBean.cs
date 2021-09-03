using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResolveClientBean']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ResolveClientBean", DoNotGenerateAcw=true)]
	public partial class ResolveClientBean : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ResolveClientBean", typeof (ResolveClientBean));
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

		protected ResolveClientBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResolveClientBean']/constructor[@name='ResolveClientBean' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.internal.AnyClient'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/internal/AnyClient;I)V", "")]
		public unsafe ResolveClientBean (global::Huawei.Hms.Common.Internal.IAnyClient p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/internal/AnyClient;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResolveClientBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Common.Internal.IAnyClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResolveClientBean']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lcom/huawei/hms/common/internal/AnyClient;", "GetGetClientHandler")]
			get {
				const string __id = "getClient.()Lcom/huawei/hms/common/internal/AnyClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IAnyClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clientReconnect;
#pragma warning disable 0169
		static Delegate GetClientReconnectHandler ()
		{
			if (cb_clientReconnect == null)
				cb_clientReconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClientReconnect);
			return cb_clientReconnect;
		}

		static void n_ClientReconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResolveClientBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClientReconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResolveClientBean']/method[@name='clientReconnect' and count(parameter)=0]"
		[Register ("clientReconnect", "()V", "GetClientReconnectHandler")]
		public virtual unsafe void ClientReconnect ()
		{
			const string __id = "clientReconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
