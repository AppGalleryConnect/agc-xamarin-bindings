using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.activity", Managed="Huawei.Hms.Activity")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.base.ui", Managed="Com.Huawei.Hms.Base.UI")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.support.common", Managed="Huawei.Hms.Support.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.ui", Managed="Huawei.Hms.Uı")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.utils", Managed="Huawei.Hms.Utils")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate bool _JniMarshal_PPIIL_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
