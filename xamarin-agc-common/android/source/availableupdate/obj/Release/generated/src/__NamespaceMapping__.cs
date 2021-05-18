using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.adapter", Managed="Huawei.Hms.Adapter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.adapter.internal", Managed="Huawei.Hms.Adapter.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.adapter.sysobs", Managed="Huawei.Hms.Adapter.Sysobs")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.adapter.ui", Managed="Huawei.Hms.Adapter.Ui")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.base.availableupdate", Managed="Huawei.Hms.Base.Availableupdate")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.update.kpms", Managed="Huawei.Hms.Update.Kpms")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.update.manager", Managed="Huawei.Hms.Update.Manager")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.update.provider", Managed="Huawei.Hms.Update.Provider")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.update.ui", Managed="Huawei.Hms.Update.Ui")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPIIL_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate int _JniMarshal_PPLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPLLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
