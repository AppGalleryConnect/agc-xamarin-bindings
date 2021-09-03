using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Internal {

	[Register ("com/huawei/hms/adapter/internal/BinderCode", DoNotGenerateAcw=true)]
	public abstract class BinderCode : Java.Lang.Object {

		internal BinderCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BinderCode']/field[@name='BINDER_SYSTEM_ERROR']"
		[Register ("BINDER_SYSTEM_ERROR")]
		public const int BinderSystemError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BinderCode']/field[@name='OK']"
		[Register ("OK")]
		public const int Ok = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.internal']/interface[@name='BinderCode']/field[@name='PARAM_ERROR']"
		[Register ("PARAM_ERROR")]
		public const int ParamError = (int) -2;
	}

	[Register ("com/huawei/hms/adapter/internal/BinderCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BinderCode' type. This type will be removed in a future release.", error: true)]
	public abstract class BinderCodeConsts : BinderCode {

		private BinderCodeConsts ()
		{
		}
	}

}
