using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.support.hianalytics", Managed="Huawei.Hms.Support.Hianalytics")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.utils", Managed="Huawei.Hms.Utils")]

delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3);
