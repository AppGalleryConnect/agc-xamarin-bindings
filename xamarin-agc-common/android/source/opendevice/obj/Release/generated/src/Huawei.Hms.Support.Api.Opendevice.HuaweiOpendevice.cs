using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendevice']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/opendevice/HuaweiOpendevice", DoNotGenerateAcw=true)]
	public partial class HuaweiOpendevice : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendevice']/field[@name='HuaweiOpendeviceApi']"
		[Register ("HuaweiOpendeviceApi")]
		public static global::Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApi HuaweiOpendeviceApi {
			get {
				const string __id = "HuaweiOpendeviceApi.Lcom/huawei/hms/support/api/opendevice/HuaweiOpendeviceApi;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Opendevice.IHuaweiOpendeviceApi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendevice']/field[@name='OPEN_DEVICE_API']"
		[Register ("OPEN_DEVICE_API")]
		public static global::Huawei.Hms.Api.Api OpenDeviceApi {
			get {
				const string __id = "OPEN_DEVICE_API.Lcom/huawei/hms/api/Api;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/opendevice/HuaweiOpendevice", typeof (HuaweiOpendevice));
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

		protected HuaweiOpendevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.opendevice']/class[@name='HuaweiOpendevice']/constructor[@name='HuaweiOpendevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiOpendevice ()
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

	}
}
