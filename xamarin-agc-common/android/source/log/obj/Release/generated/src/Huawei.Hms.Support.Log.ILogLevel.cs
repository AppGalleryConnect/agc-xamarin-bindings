using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Log {

	[Register ("com/huawei/hms/support/log/LogLevel", DoNotGenerateAcw=true)]
	public abstract class LogLevel : Java.Lang.Object {

		internal LogLevel ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.log']/interface[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.log']/interface[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.log']/interface[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.log']/interface[@name='LogLevel']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 5;
	}

	[Register ("com/huawei/hms/support/log/LogLevel", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LogLevel' type. This type will be removed in a future release.", error: true)]
	public abstract class LogLevelConsts : LogLevel {

		private LogLevelConsts ()
		{
		}
	}

}
