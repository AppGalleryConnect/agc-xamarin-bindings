using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateKey", DoNotGenerateAcw=true)]
	public abstract class UpdateKey : Java.Lang.Object {

		internal UpdateKey ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='BUTTON_STATUS']"
		[Register ("BUTTON_STATUS")]
		public const string ButtonStatus = (string) "buttonstatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='DIALOG_STATUS']"
		[Register ("DIALOG_STATUS")]
		public const string DialogStatus = (string) "dialogstatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='FAIL_CODE']"
		[Register ("FAIL_CODE")]
		public const string FailCode = (string) "failcause";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='FAIL_REASON']"
		[Register ("FAIL_REASON")]
		public const string FailReason = (string) "failreason";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='INFO']"
		[Register ("INFO")]
		public const string Info = (string) "updatesdk_update_info";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='INFO_LIST']"
		[Register ("INFO_LIST")]
		public const string InfoList = (string) "updatesdk_update_info_list";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='MARKET_DLD_STATUS']"
		[Register ("MARKET_DLD_STATUS")]
		public const string MarketDldStatus = (string) "downloadStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='MARKET_INSTALL_STATE']"
		[Register ("MARKET_INSTALL_STATE")]
		public const string MarketInstallState = (string) "installState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='MARKET_INSTALL_TYPE']"
		[Register ("MARKET_INSTALL_TYPE")]
		public const string MarketInstallType = (string) "installType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='MUST_UPDATE']"
		[Register ("MUST_UPDATE")]
		public const string MustUpdate = (string) "compulsoryUpdateCancel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='REQUEST_SIGN']"
		[Register ("REQUEST_SIGN")]
		public const string RequestSign = (string) "requestsign";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='RESPONSE_CODE']"
		[Register ("RESPONSE_CODE")]
		public const string ResponseCode = (string) "responsecode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateKey']/field[@name='STATUS']"
		[Register ("STATUS")]
		public const string Status = (string) "status";
	}

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateKey", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UpdateKey' type. This type will be removed in a future release.", error: true)]
	public abstract class UpdateKeyConsts : UpdateKey {

		private UpdateKeyConsts ()
		{
		}
	}

}
