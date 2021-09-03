using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateStatusCode$DialogButton", DoNotGenerateAcw=true)]
	public abstract class UpdateStatusCodeDialogButton : Java.Lang.Object {

		internal UpdateStatusCodeDialogButton ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode.DialogButton']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public const int Cancel = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode.DialogButton']/field[@name='CONFIRM']"
		[Register ("CONFIRM")]
		public const int Confirm = (int) 101;
	}

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateStatusCode$DialogButton", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UpdateStatusCodeDialogButton' type. This type will be removed in a future release.", error: true)]
	public abstract class UpdateStatusCodeDialogButtonConsts : UpdateStatusCodeDialogButton {

		private UpdateStatusCodeDialogButtonConsts ()
		{
		}
	}


	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateStatusCode", DoNotGenerateAcw=true)]
	public abstract class UpdateStatusCode : Java.Lang.Object {

		internal UpdateStatusCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public const int Cancel = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='CHECK_FAILED']"
		[Register ("CHECK_FAILED")]
		public const int CheckFailed = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='CONNECT_ERROR']"
		[Register ("CONNECT_ERROR")]
		public const int ConnectError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='HAS_UPGRADE_INFO']"
		[Register ("HAS_UPGRADE_INFO")]
		public const int HasUpgradeInfo = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='INSTALL_FAILED']"
		[Register ("INSTALL_FAILED")]
		public const int InstallFailed = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='IN_MARKET_UPDATING']"
		[Register ("IN_MARKET_UPDATING")]
		public const int InMarketUpdating = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='MARKET_FORBID']"
		[Register ("MARKET_FORBID")]
		public const int MarketForbid = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='NO_UPGRADE_INFO']"
		[Register ("NO_UPGRADE_INFO")]
		public const int NoUpgradeInfo = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateStatusCode']/field[@name='PARAMER_ERROR']"
		[Register ("PARAMER_ERROR")]
		public const int ParamerError = (int) 1;
	}

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateStatusCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UpdateStatusCode' type. This type will be removed in a future release.", error: true)]
	public abstract class UpdateStatusCodeConsts : UpdateStatusCode {

		private UpdateStatusCodeConsts ()
		{
		}
	}

}
