using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/api/CommonStatusCodes", DoNotGenerateAcw=true)]
	public partial class CommonStatusCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='API_NOT_CONNECTED']"
		[Register ("API_NOT_CONNECTED")]
		public const int ApiNotConnected = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='DEVELOPER_ERROR']"
		[Register ("DEVELOPER_ERROR")]
		public const int DeveloperError = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='INTERRUPTED']"
		[Register ("INTERRUPTED")]
		public const int Interrupted = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='INVALID_ACCOUNT']"
		[Register ("INVALID_ACCOUNT")]
		public const int InvalidAccount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='RESOLUTION_REQUIRED']"
		[Register ("RESOLUTION_REQUIRED")]
		public const int ResolutionRequired = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		public const int ServiceDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='SIGN_IN_REQUIRED']"
		[Register ("SIGN_IN_REQUIRED")]
		public const int SignInRequired = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='SUCCESS_CACHE']"
		[Register ("SUCCESS_CACHE")]
		public const int SuccessCache = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 15;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/CommonStatusCodes", typeof (CommonStatusCodes));
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

		protected CommonStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/constructor[@name='CommonStatusCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CommonStatusCodes ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='CommonStatusCodes']/method[@name='getStatusCodeString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStatusCodeString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetStatusCodeString (int p0)
		{
			const string __id = "getStatusCodeString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
