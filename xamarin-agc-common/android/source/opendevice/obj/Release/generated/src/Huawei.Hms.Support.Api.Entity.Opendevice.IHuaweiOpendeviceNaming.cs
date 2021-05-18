using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Opendevice {

	[Register ("com/huawei/hms/support/api/entity/opendevice/HuaweiOpendeviceNaming", DoNotGenerateAcw=true)]
	public abstract class HuaweiOpendeviceNaming : Java.Lang.Object {

		internal HuaweiOpendeviceNaming ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/interface[@name='HuaweiOpendeviceNaming']/field[@name='getOaid']"
		[Register ("getOaid")]
		public const string GetOaid = (string) "opendevice.getoaid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/interface[@name='HuaweiOpendeviceNaming']/field[@name='getOdid']"
		[Register ("getOdid")]
		public const string GetOdid = (string) "opendevice.getodid";
	}

	[Register ("com/huawei/hms/support/api/entity/opendevice/HuaweiOpendeviceNaming", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HuaweiOpendeviceNaming' type. This type will be removed in a future release.", error: true)]
	public abstract class HuaweiOpendeviceNamingConsts : HuaweiOpendeviceNaming {

		private HuaweiOpendeviceNamingConsts ()
		{
		}
	}

}
