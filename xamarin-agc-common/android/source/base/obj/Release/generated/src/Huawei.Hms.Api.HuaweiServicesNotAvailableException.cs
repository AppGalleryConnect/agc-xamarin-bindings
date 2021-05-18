using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesNotAvailableException']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiServicesNotAvailableException", DoNotGenerateAcw=true)]
	public sealed partial class HuaweiServicesNotAvailableException : global::Java.Lang.Exception {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesNotAvailableException']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				const string __id = "errorCode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "errorCode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiServicesNotAvailableException", typeof (HuaweiServicesNotAvailableException));
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

		internal HuaweiServicesNotAvailableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesNotAvailableException']/constructor[@name='HuaweiServicesNotAvailableException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe HuaweiServicesNotAvailableException (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
