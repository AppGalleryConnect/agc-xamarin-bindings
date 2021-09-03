using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/PackageConstants", DoNotGenerateAcw=true)]
	public partial class PackageConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='APPID_HMS']"
		[Register ("APPID_HMS")]
		public const string AppidHms = (string) "C10132067";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='APPID_HMS_TV']"
		[Register ("APPID_HMS_TV")]
		public const string AppidHmsTv = (string) "C100636709";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='HMS_SDK_VERSION_CODE']"
		[Register ("HMS_SDK_VERSION_CODE")]
		public const int HmsSdkVersionCode = (int) 50100300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='HMS_SDK_VERSION_NAME']"
		[Register ("HMS_SDK_VERSION_NAME")]
		public const string HmsSdkVersionName = (string) "5.1.0.300";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_ACTION']"
		[Register ("SERVICES_ACTION")]
		public const string ServicesAction = (string) "com.huawei.hms.core.aidlservice";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE']"
		[Register ("SERVICES_PACKAGE")]
		public const string ServicesPackage = (string) "com.huawei.hwid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_ALL_SCENE']"
		[Register ("SERVICES_PACKAGE_ALL_SCENE")]
		public const string ServicesPackageAllScene = (string) "com.huawei.hms";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_APPMARKET']"
		[Register ("SERVICES_PACKAGE_APPMARKET")]
		public const string ServicesPackageAppmarket = (string) "com.huawei.appmarket";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_APPMARKET_CAR']"
		[Register ("SERVICES_PACKAGE_APPMARKET_CAR")]
		public const string ServicesPackageAppmarketCar = (string) "com.huawei.appmarket.car";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_APPMARKET_TV']"
		[Register ("SERVICES_PACKAGE_APPMARKET_TV")]
		public const string ServicesPackageAppmarketTv = (string) "com.huawei.appmarket.tv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_CAR']"
		[Register ("SERVICES_PACKAGE_CAR")]
		public const string ServicesPackageCar = (string) "com.huawei.hwid.car";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_PACKAGE_TV']"
		[Register ("SERVICES_PACKAGE_TV")]
		public const string ServicesPackageTv = (string) "com.huawei.hwid.tv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_SIGNATURE']"
		[Register ("SERVICES_SIGNATURE")]
		public const string ServicesSignature = (string) "B92825C2BD5D6D6D1E7F39EECD17843B7D9016F611136B75441BC6F4D3F00F05";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_SIGNATURE_CAR']"
		[Register ("SERVICES_SIGNATURE_CAR")]
		public const string ServicesSignatureCar = (string) "3517262215D8D3008CBF888750B6418EDC4D562AC33ED6874E0D73ABA667BC3C";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/field[@name='SERVICES_SIGNATURE_TV']"
		[Register ("SERVICES_SIGNATURE_TV")]
		public const string ServicesSignatureTv = (string) "3517262215D8D3008CBF888750B6418EDC4D562AC33ED6874E0D73ABA667BC3C";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/PackageConstants", typeof (PackageConstants));
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

		protected PackageConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='PackageConstants']/constructor[@name='PackageConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackageConstants ()
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
