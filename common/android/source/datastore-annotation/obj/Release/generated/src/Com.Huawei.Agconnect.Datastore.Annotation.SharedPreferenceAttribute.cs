using System;

namespace Com.Huawei.Agconnect.Datastore.Annotation {

	[global::Android.Runtime.Annotation ("com.huawei.agconnect.datastore.annotation.SharedPreference")]
	public partial class SharedPreferenceAttribute : Attribute
	{
		[global::Android.Runtime.Register ("crypto")]
		public global::Java.Lang.Class Crypto { get; set; }

		[global::Android.Runtime.Register ("fileName")]
		public string FileName { get; set; }

		[global::Android.Runtime.Register ("key")]
		public string Key { get; set; }

	}
}
