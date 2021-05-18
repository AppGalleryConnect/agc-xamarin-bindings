using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDevice']"
	[global::Android.Runtime.Register ("com/huawei/hms/opendevice/OpenDevice", DoNotGenerateAcw=true)]
	public partial class OpenDevice : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/opendevice/OpenDevice", typeof (OpenDevice));
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

		protected OpenDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDevice']/constructor[@name='OpenDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenDevice ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDevice']/method[@name='getOpenDeviceClient' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getOpenDeviceClient", "(Landroid/app/Activity;)Lcom/huawei/hms/opendevice/OpenDeviceClient;", "")]
		public static unsafe global::Huawei.Hms.Opendevice.IOpenDeviceClient GetOpenDeviceClient (global::Android.App.Activity p0)
		{
			const string __id = "getOpenDeviceClient.(Landroid/app/Activity;)Lcom/huawei/hms/opendevice/OpenDeviceClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.IOpenDeviceClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDevice']/method[@name='getOpenDeviceClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOpenDeviceClient", "(Landroid/content/Context;)Lcom/huawei/hms/opendevice/OpenDeviceClient;", "")]
		public static unsafe global::Huawei.Hms.Opendevice.IOpenDeviceClient GetOpenDeviceClient (global::Android.Content.Context p0)
		{
			const string __id = "getOpenDeviceClient.(Landroid/content/Context;)Lcom/huawei/hms/opendevice/OpenDeviceClient;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.IOpenDeviceClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
