using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/JosStatusCodes", DoNotGenerateAcw=true)]
	public partial class JosStatusCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RNT_CODE_NETWORK_ERROR']"
		[Register ("RNT_CODE_NETWORK_ERROR")]
		public const int RntCodeNetworkError = (int) 8300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RNT_CODE_NO_JOS_INFO']"
		[Register ("RNT_CODE_NO_JOS_INFO")]
		public const int RntCodeNoJosInfo = (int) 8002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RNT_CODE_SERVER_ERROR']"
		[Register ("RNT_CODE_SERVER_ERROR")]
		public const int RntCodeServerError = (int) 8200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RTN_CODE_COMMON_ERROR']"
		[Register ("RTN_CODE_COMMON_ERROR")]
		public const int RtnCodeCommonError = (int) 8000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RTN_CODE_NO_SUPPORT_JOS']"
		[Register ("RTN_CODE_NO_SUPPORT_JOS")]
		public const int RtnCodeNoSupportJos = (int) 8001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='RTN_CODE_PARAMS_ERROR']"
		[Register ("RTN_CODE_PARAMS_ERROR")]
		public const int RtnCodeParamsError = (int) 8100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/JosStatusCodes", typeof (JosStatusCodes));
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

		protected JosStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosStatusCodes']/constructor[@name='JosStatusCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JosStatusCodes ()
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
