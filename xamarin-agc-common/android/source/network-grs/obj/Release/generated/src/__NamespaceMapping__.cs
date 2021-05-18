using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.framework.network.grs", Managed="Huawei.Hms.Framework.Network.Grs")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.huawei.hms.framework.network.grs.local.model", Managed="Huawei.Hms.Framework.Network.Grs.Local.Model")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPZZL_L (IntPtr jnienv, IntPtr klass, bool p0, bool p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPZZLL_L (IntPtr jnienv, IntPtr klass, bool p0, bool p1, IntPtr p2, IntPtr p3);
