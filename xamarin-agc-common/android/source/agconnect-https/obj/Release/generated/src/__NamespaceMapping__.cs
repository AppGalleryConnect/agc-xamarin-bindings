using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.agconnect.https", Managed="Huawei.Agconnect.Https")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.agconnect.https.adapter", Managed="Huawei.Agconnect.Https.Adapter")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.agconnect.https.annotation", Managed="Huawei.Agconnect.Https.Annotation")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
