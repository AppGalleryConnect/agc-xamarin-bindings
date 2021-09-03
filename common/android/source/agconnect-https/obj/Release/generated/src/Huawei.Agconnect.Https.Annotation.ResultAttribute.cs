using System;

namespace Huawei.Agconnect.Https.Annotation {

	[global::Android.Runtime.Annotation ("com.huawei.agconnect.https.annotation.Result")]
	public partial class ResultAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
