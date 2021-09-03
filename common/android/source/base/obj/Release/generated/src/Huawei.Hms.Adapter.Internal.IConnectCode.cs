using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Internal {

	[Register ("com/huawei/hms/adapter/internal/ConnectCode", DoNotGenerateAcw=true)]
	public abstract class ConnectCode : Java.Lang.Object {

		internal ConnectCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='ConnectCode']/field[@name='CONNECT_RESULT_NULL']"
		[Register ("CONNECT_RESULT_NULL")]
		public const int ConnectResultNull = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='ConnectCode']/field[@name='OK']"
		[Register ("OK")]
		public const int Ok = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='ConnectCode']/field[@name='PARAM_ERROR']"
		[Register ("PARAM_ERROR")]
		public const int ParamError = (int) -2;
	}

	[Register ("com/huawei/hms/adapter/internal/ConnectCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ConnectCode' type. This type will be removed in a future release.", error: true)]
	public abstract class ConnectCodeConsts : ConnectCode {

		private ConnectCodeConsts ()
		{
		}
	}

}
