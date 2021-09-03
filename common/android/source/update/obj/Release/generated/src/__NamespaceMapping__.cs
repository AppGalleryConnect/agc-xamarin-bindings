using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.updatesdk", Managed="Huawei.Updatesdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.updatesdk.fileprovider", Managed="Huawei.Updatesdk.Fileprovider")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.updatesdk.service.appmgr.bean", Managed="Com.Huawei.Updatesdk.Service.Appmgr.Bean")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.updatesdk.service.otaupdate", Managed="Huawei.Updatesdk.Service.Otaupdate")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.updatesdk.support.pm", Managed="Huawei.Updatesdk.Support.Pm")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate int _JniMarshal_PPLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPLLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
