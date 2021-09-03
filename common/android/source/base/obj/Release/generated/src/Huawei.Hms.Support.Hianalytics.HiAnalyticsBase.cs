using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsBase']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/hianalytics/HiAnalyticsBase", DoNotGenerateAcw=true)]
	public partial class HiAnalyticsBase : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/hianalytics/HiAnalyticsBase", typeof (HiAnalyticsBase));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected HiAnalyticsBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsBase']/constructor[@name='HiAnalyticsBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HiAnalyticsBase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsBase']/method[@name='getMapForBi' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMapForBi", "(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;", "")]
		protected static unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapForBi (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getMapForBi.(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
