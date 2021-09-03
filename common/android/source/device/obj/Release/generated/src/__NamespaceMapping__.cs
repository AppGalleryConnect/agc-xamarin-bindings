using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.android", Managed="Huawei.Hms.Android")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.base.device", Managed="Com.Huawei.Hms.Base.Device")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.common", Managed="Huawei.Hms.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.common.internal", Managed="Huawei.Hms.Common.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.common.util", Managed="Huawei.Hms.Common.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.support.gentyref", Managed="Huawei.Hms.Support.Gentyref")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.support.log.common", Managed="Huawei.Hms.Support.Log.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.utils", Managed="Huawei.Hms.Utils")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
