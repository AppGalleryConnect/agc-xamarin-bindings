using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesRepairableException']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiServicesRepairableException", DoNotGenerateAcw=true)]
	public partial class HuaweiServicesRepairableException : global::Huawei.Hms.Api.UserRecoverableException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiServicesRepairableException", typeof (HuaweiServicesRepairableException));
		internal static new IntPtr class_ref {
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

		protected HuaweiServicesRepairableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesRepairableException']/constructor[@name='HuaweiServicesRepairableException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Intent']]"
		[Register (".ctor", "(ILjava/lang/String;Landroid/content/Intent;)V", "")]
		public unsafe HuaweiServicesRepairableException (int p0, string p1, global::Android.Content.Intent p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Landroid/content/Intent;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_getConnectionStatusCode;
#pragma warning disable 0169
		static Delegate GetGetConnectionStatusCodeHandler ()
		{
			if (cb_getConnectionStatusCode == null)
				cb_getConnectionStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetConnectionStatusCode);
			return cb_getConnectionStatusCode;
		}

		static int n_GetConnectionStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiServicesRepairableException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionStatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectionStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiServicesRepairableException']/method[@name='getConnectionStatusCode' and count(parameter)=0]"
			[Register ("getConnectionStatusCode", "()I", "GetGetConnectionStatusCodeHandler")]
			get {
				const string __id = "getConnectionStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
