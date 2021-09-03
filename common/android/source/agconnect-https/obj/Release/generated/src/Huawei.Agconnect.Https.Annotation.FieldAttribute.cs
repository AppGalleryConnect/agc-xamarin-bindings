using System;

namespace Huawei.Agconnect.Https.Annotation {

	[global::Android.Runtime.Annotation ("com.huawei.agconnect.https.annotation.Field")]
	public partial class FieldAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
