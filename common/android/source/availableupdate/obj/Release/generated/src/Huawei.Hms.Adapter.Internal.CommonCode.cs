using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/class[@name='CommonCode']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/internal/CommonCode", DoNotGenerateAcw=true)]
	public partial class CommonCode : global::Java.Lang.Object {

		[Register ("com/huawei/hms/adapter/internal/CommonCode$MapKey", DoNotGenerateAcw=true)]
		public abstract class MapKey : Java.Lang.Object {

			internal MapKey ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='API_NAME']"
			[Register ("API_NAME")]
			public const string ApiName = (string) "api_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='HAS_RESOLUTION']"
			[Register ("HAS_RESOLUTION")]
			public const string HasResolution = (string) "resolution";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='HMS_FOREGROUND_RES_UI']"
			[Register ("HMS_FOREGROUND_RES_UI")]
			public const string HmsForegroundResUi = (string) "HMS_FOREGROUND_RES_UI";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='JSON_BODY']"
			[Register ("JSON_BODY")]
			public const string JsonBody = (string) "json_body";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='JSON_HEADER']"
			[Register ("JSON_HEADER")]
			public const string JsonHeader = (string) "json_header";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='NEW_UPDATE']"
			[Register ("NEW_UPDATE")]
			public const string NewUpdate = (string) "new_update";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='TRANSACTION_ID']"
			[Register ("TRANSACTION_ID")]
			public const string TransactionId = (string) "transaction_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='CommonCode.MapKey']/field[@name='UPDATE_VERSION']"
			[Register ("UPDATE_VERSION")]
			public const string UpdateVersion = (string) "update_version";
		}

		[Register ("com/huawei/hms/adapter/internal/CommonCode$MapKey", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'MapKey' type. This type will be removed in a future release.", error: true)]
		public abstract class MapKeyConsts : MapKey {

			private MapKeyConsts ()
			{
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/internal/CommonCode", typeof (CommonCode));
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

		protected CommonCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/class[@name='CommonCode']/constructor[@name='CommonCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonCode ()
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
