using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	[Register ("com/huawei/hms/support/api/entity/core/CoreNaming", DoNotGenerateAcw=true)]
	public abstract class CoreNaming : Java.Lang.Object {

		internal CoreNaming ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='CHECKCONNECT']"
		[Register ("CHECKCONNECT")]
		public const string Checkconnect = (string) "core.checkconnect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='CONNECT']"
		[Register ("CONNECT")]
		public const string Connect = (string) "core.connect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='DISCONNECT']"
		[Register ("DISCONNECT")]
		public const string Disconnect = (string) "core.disconnect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='FORECONNECT']"
		[Register ("FORECONNECT")]
		public const string Foreconnect = (string) "core.foreconnect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='GETNOTICE']"
		[Register ("GETNOTICE")]
		public const string Getnotice = (string) "core.getNoticeIntent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/interface[@name='CoreNaming']/field[@name='HUBREQUEST']"
		[Register ("HUBREQUEST")]
		public const string Hubrequest = (string) "hub.request";
	}

	[Register ("com/huawei/hms/support/api/entity/core/CoreNaming", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'CoreNaming' type. This type will be removed in a future release.", error: true)]
	public abstract class CoreNamingConsts : CoreNaming {

		private CoreNamingConsts ()
		{
		}
	}

}
