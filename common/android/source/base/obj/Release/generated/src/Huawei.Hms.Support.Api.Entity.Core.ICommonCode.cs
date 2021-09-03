using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$ErrorCode", DoNotGenerateAcw=true)]
	public abstract class CommonCodeErrorCode : Java.Lang.Object {

		internal CommonCodeErrorCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='ARGUMENTS_INVALID']"
		[Register ("ARGUMENTS_INVALID")]
		public const int ArgumentsInvalid = (int) 907135000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='CLIENT_API_INVALID']"
		[Register ("CLIENT_API_INVALID")]
		public const int ClientApiInvalid = (int) 907135003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='EXECUTE_TIMEOUT']"
		[Register ("EXECUTE_TIMEOUT")]
		public const int ExecuteTimeout = (int) 907135004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='HMS_VERSION_CONFIGER_INVALID']"
		[Register ("HMS_VERSION_CONFIGER_INVALID")]
		public const int HmsVersionConfigerInvalid = (int) 907135007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 907135001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='NAMING_INVALID']"
		[Register ("NAMING_INVALID")]
		public const int NamingInvalid = (int) 907135002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='NOT_IN_SERVICE']"
		[Register ("NOT_IN_SERVICE")]
		public const int NotInService = (int) 907135005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.ErrorCode']/field[@name='SESSION_INVALID']"
		[Register ("SESSION_INVALID")]
		public const int SessionInvalid = (int) 907135006;
	}

	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$ErrorCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CommonCodeErrorCode' type. This type will be removed in a future release.", error: true)]
	public abstract class CommonCodeErrorCodeConsts : CommonCodeErrorCode {

		private CommonCodeErrorCodeConsts ()
		{
		}
	}


	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$Resolution", DoNotGenerateAcw=true)]
	public abstract class CommonCodeResolution : Java.Lang.Object {

		internal CommonCodeResolution ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.Resolution']/field[@name='HAS_RESOLUTION']"
		[Register ("HAS_RESOLUTION")]
		public const string HasResolution = (string) "hasContextResolution";
	}

	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$Resolution", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CommonCodeResolution' type. This type will be removed in a future release.", error: true)]
	public abstract class CommonCodeResolutionConsts : CommonCodeResolution {

		private CommonCodeResolutionConsts ()
		{
		}
	}


	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$StatusCode", DoNotGenerateAcw=true)]
	public abstract class CommonCodeStatusCode : Java.Lang.Object {

		internal CommonCodeStatusCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.StatusCode']/field[@name='API_CLIENT_EXPIRED']"
		[Register ("API_CLIENT_EXPIRED")]
		public const int ApiClientExpired = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode.StatusCode']/field[@name='API_UNAVAILABLE']"
		[Register ("API_UNAVAILABLE")]
		public const int ApiUnavailable = (int) 1000;
	}

	[Register ("com/huawei/hms/support/api/entity/core/CommonCode$StatusCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CommonCodeStatusCode' type. This type will be removed in a future release.", error: true)]
	public abstract class CommonCodeStatusCodeConsts : CommonCodeStatusCode {

		private CommonCodeStatusCodeConsts ()
		{
		}
	}


	[Register ("com/huawei/hms/support/api/entity/core/CommonCode", DoNotGenerateAcw=true)]
	public abstract class CommonCode : Java.Lang.Object {

		internal CommonCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CommonCode']/field[@name='OK']"
		[Register ("OK")]
		public const int Ok = (int) 0;
	}

	[Register ("com/huawei/hms/support/api/entity/core/CommonCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CommonCode' type. This type will be removed in a future release.", error: true)]
	public abstract class CommonCodeConsts : CommonCode {

		private CommonCodeConsts ()
		{
		}
	}

}
