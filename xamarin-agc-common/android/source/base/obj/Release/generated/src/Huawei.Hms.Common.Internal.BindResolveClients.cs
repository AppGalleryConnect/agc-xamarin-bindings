using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BindResolveClients']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/BindResolveClients", DoNotGenerateAcw=true)]
	public partial class BindResolveClients : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/BindResolveClients", typeof (BindResolveClients));
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

		protected BindResolveClients (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Huawei.Hms.Common.Internal.BindResolveClients Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BindResolveClients']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/common/internal/BindResolveClients;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/common/internal/BindResolveClients;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BindResolveClients> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_notifyClientReconnect;
#pragma warning disable 0169
		static Delegate GetNotifyClientReconnectHandler ()
		{
			if (cb_notifyClientReconnect == null)
				cb_notifyClientReconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyClientReconnect);
			return cb_notifyClientReconnect;
		}

		static void n_NotifyClientReconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BindResolveClients> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyClientReconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BindResolveClients']/method[@name='notifyClientReconnect' and count(parameter)=0]"
		[Register ("notifyClientReconnect", "()V", "GetNotifyClientReconnectHandler")]
		public virtual unsafe void NotifyClientReconnect ()
		{
			const string __id = "notifyClientReconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unRegisterAll;
#pragma warning disable 0169
		static Delegate GetUnRegisterAllHandler ()
		{
			if (cb_unRegisterAll == null)
				cb_unRegisterAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnRegisterAll);
			return cb_unRegisterAll;
		}

		static void n_UnRegisterAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.BindResolveClients> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='BindResolveClients']/method[@name='unRegisterAll' and count(parameter)=0]"
		[Register ("unRegisterAll", "()V", "GetUnRegisterAllHandler")]
		public virtual unsafe void UnRegisterAll ()
		{
			const string __id = "unRegisterAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
