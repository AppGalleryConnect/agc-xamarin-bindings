using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Internal {

	[Register ("com/huawei/hms/adapter/internal/AvailableCode", DoNotGenerateAcw=true)]
	public abstract class AvailableCode : Java.Lang.Object {

		internal AvailableCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='ERROR_NO_ACTIVITY']"
		[Register ("ERROR_NO_ACTIVITY")]
		public const int ErrorNoActivity = (int) 26;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='ERROR_ON_ACTIVITY_RESULT']"
		[Register ("ERROR_ON_ACTIVITY_RESULT")]
		public const int ErrorOnActivityResult = (int) 25;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		public const int ServiceDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='SERVICE_MISSING']"
		[Register ("SERVICE_MISSING")]
		public const int ServiceMissing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='SERVICE_UNSUPPORTED']"
		[Register ("SERVICE_UNSUPPORTED")]
		public const int ServiceUnsupported = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='AvailableCode']/field[@name='USER_IGNORE_PREVIOUS_POPUP']"
		[Register ("USER_IGNORE_PREVIOUS_POPUP")]
		public const int UserIgnorePreviousPopup = (int) 27;
	}

	[Register ("com/huawei/hms/adapter/internal/AvailableCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AvailableCode' type. This type will be removed in a future release.", error: true)]
	public abstract class AvailableCodeConsts : AvailableCode {

		private AvailableCodeConsts ()
		{
		}
	}

}
