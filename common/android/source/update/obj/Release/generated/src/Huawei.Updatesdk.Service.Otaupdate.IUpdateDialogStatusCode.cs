using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateDialogStatusCode", DoNotGenerateAcw=true)]
	public abstract class UpdateDialogStatusCode : Java.Lang.Object {

		internal UpdateDialogStatusCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateDialogStatusCode']/field[@name='DISMISS']"
		[Register ("DISMISS")]
		public const int Dismiss = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='UpdateDialogStatusCode']/field[@name='SHOW']"
		[Register ("SHOW")]
		public const int Show = (int) 10002;
	}

	[Register ("com/huawei/updatesdk/service/otaupdate/UpdateDialogStatusCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UpdateDialogStatusCode' type. This type will be removed in a future release.", error: true)]
	public abstract class UpdateDialogStatusCodeConsts : UpdateDialogStatusCode {

		private UpdateDialogStatusCodeConsts ()
		{
		}
	}

}
