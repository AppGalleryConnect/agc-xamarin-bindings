using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Update.Kpms {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']"
	[global::Android.Runtime.Register ("com/huawei/hms/update/kpms/KpmsConstant", DoNotGenerateAcw=true)]
	public partial class KpmsConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='CALLER_PACKAGE_NAME']"
		[Register ("CALLER_PACKAGE_NAME")]
		public const string CallerPackageName = (string) "kpms_key_caller_packagename";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='KIT_UPDATE_RESULT']"
		[Register ("KIT_UPDATE_RESULT")]
		public const string KitUpdateResult = (string) "kit_update_result";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='RESULT_UPDATE_BREAK']"
		[Register ("RESULT_UPDATE_BREAK")]
		public const int ResultUpdateBreak = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='RESULT_UPDATE_CANCEL']"
		[Register ("RESULT_UPDATE_CANCEL")]
		public const int ResultUpdateCancel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='RESULT_UPDATE_FAILED']"
		[Register ("RESULT_UPDATE_FAILED")]
		public const int ResultUpdateFailed = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='RESULT_UPDATE_SUCCESS']"
		[Register ("RESULT_UPDATE_SUCCESS")]
		public const int ResultUpdateSuccess = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/field[@name='UPDATE_PACKAGE_NAME']"
		[Register ("UPDATE_PACKAGE_NAME")]
		public const string UpdatePackageName = (string) "kitUpdatePackageName";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/kpms/KpmsConstant", typeof (KpmsConstant));
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

		protected KpmsConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.update.kpms']/class[@name='KpmsConstant']/constructor[@name='KpmsConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KpmsConstant ()
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
