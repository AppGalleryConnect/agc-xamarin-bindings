using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/class[@name='ProxyCenter']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/plugin/ProxyCenter", DoNotGenerateAcw=true)]
	public partial class ProxyCenter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/plugin/ProxyCenter", typeof (ProxyCenter));
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

		protected ProxyCenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/class[@name='ProxyCenter']/constructor[@name='ProxyCenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProxyCenter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Huawei.Hms.Aaid.Plugin.ProxyCenter Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/class[@name='ProxyCenter']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/aaid/plugin/ProxyCenter;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/aaid/plugin/ProxyCenter;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.ProxyCenter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Huawei.Hms.Aaid.Plugin.IPushProxy Proxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/class[@name='ProxyCenter']/method[@name='getProxy' and count(parameter)=0]"
			[Register ("getProxy", "()Lcom/huawei/hms/aaid/plugin/PushProxy;", "")]
			get {
				const string __id = "getProxy.()Lcom/huawei/hms/aaid/plugin/PushProxy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/class[@name='ProxyCenter']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.aaid.plugin.PushProxy']]"
		[Register ("register", "(Lcom/huawei/hms/aaid/plugin/PushProxy;)V", "")]
		public static unsafe void Register (global::Huawei.Hms.Aaid.Plugin.IPushProxy p0)
		{
			const string __id = "register.(Lcom/huawei/hms/aaid/plugin/PushProxy;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
