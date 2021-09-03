using System;

namespace Huawei.Agconnect.Https.Annotation {

	[global::Android.Runtime.Annotation ("com.huawei.agconnect.https.annotation.Query")]
	public partial class QueryAttribute : Attribute
	{
		[global::Android.Runtime.Register ("encoded")]
		public bool Encoded { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
