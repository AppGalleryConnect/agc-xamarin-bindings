using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Util {

	[Register ("com/huawei/hms/common/util/HMSSDKConstants", DoNotGenerateAcw=true)]
	public abstract class HMSSDKConstants : Java.Lang.Object {

		internal HMSSDKConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.util']/interface[@name='HMSSDKConstants']/field[@name='FITNESS']"
		[Register ("FITNESS")]
		public const int Fitness = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.util']/interface[@name='HMSSDKConstants']/field[@name='GAMES']"
		[Register ("GAMES")]
		public const int Games = (int) 1;
	}

	[Register ("com/huawei/hms/common/util/HMSSDKConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HMSSDKConstants' type. This type will be removed in a future release.", error: true)]
	public abstract class HMSSDKConstantsConsts : HMSSDKConstants {

		private HMSSDKConstantsConsts ()
		{
		}
	}

}
