using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='HuaweiOpendeviceStatusCodes']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/opendevice/HuaweiOpendeviceStatusCodes", DoNotGenerateAcw=true)]
	public sealed partial class HuaweiOpendeviceStatusCodes : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='HuaweiOpendeviceStatusCodes']/field[@name='RTN_CODE_INNER_CODE']"
		[Register ("RTN_CODE_INNER_CODE")]
		public int RtnCodeInnerCode {
			get {
				const string __id = "RTN_CODE_INNER_CODE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "RTN_CODE_INNER_CODE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='HuaweiOpendeviceStatusCodes']/field[@name='RTN_CODE_VENDOR_CODE_ERR']"
		[Register ("RTN_CODE_VENDOR_CODE_ERR")]
		public int RtnCodeVendorCodeErr {
			get {
				const string __id = "RTN_CODE_VENDOR_CODE_ERR.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "RTN_CODE_VENDOR_CODE_ERR.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='HuaweiOpendeviceStatusCodes']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public int Success {
			get {
				const string __id = "SUCCESS.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "SUCCESS.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/opendevice/HuaweiOpendeviceStatusCodes", typeof (HuaweiOpendeviceStatusCodes));
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

		internal HuaweiOpendeviceStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='HuaweiOpendeviceStatusCodes']/constructor[@name='HuaweiOpendeviceStatusCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiOpendeviceStatusCodes ()
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
