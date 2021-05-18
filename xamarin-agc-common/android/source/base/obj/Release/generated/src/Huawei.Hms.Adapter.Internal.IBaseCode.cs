using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Internal {

	[Register ("com/huawei/hms/adapter/internal/BaseCode", DoNotGenerateAcw=true)]
	public abstract class BaseCode : Java.Lang.Object {

		internal BaseCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='ACTIVITY_NULL']"
		[Register ("ACTIVITY_NULL")]
		public const int ActivityNull = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='DATA_NULL_IN_INTENT']"
		[Register ("DATA_NULL_IN_INTENT")]
		public const int DataNullInIntent = (int) -7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='KPMS_UPDATE_FAILED']"
		[Register ("KPMS_UPDATE_FAILED")]
		public const int KpmsUpdateFailed = (int) -10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='NO_AVAILABLE_LIB_ERROR']"
		[Register ("NO_AVAILABLE_LIB_ERROR")]
		public const int NoAvailableLibError = (int) -9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='NO_SOLUTION']"
		[Register ("NO_SOLUTION")]
		public const int NoSolution = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='OK']"
		[Register ("OK")]
		public const int Ok = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='PARAM_ERROR']"
		[Register ("PARAM_ERROR")]
		public const int ParamError = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='RESULT_NULL']"
		[Register ("RESULT_NULL")]
		public const int ResultNull = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='SOLUTION_GET_RESPONSE_CODE_ERROR']"
		[Register ("SOLUTION_GET_RESPONSE_CODE_ERROR")]
		public const int SolutionGetResponseCodeError = (int) -8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='TRANSACTION_IS_NULL']"
		[Register ("TRANSACTION_IS_NULL")]
		public const int TransactionIsNull = (int) -6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BaseCode']/field[@name='URI_IS_NULL']"
		[Register ("URI_IS_NULL")]
		public const int UriIsNull = (int) -5;
	}

	[Register ("com/huawei/hms/adapter/internal/BaseCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BaseCode' type. This type will be removed in a future release.", error: true)]
	public abstract class BaseCodeConsts : BaseCode {

		private BaseCodeConsts ()
		{
		}
	}

}
