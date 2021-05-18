using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='UnsupportedApiCallException']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/api/UnsupportedApiCallException", DoNotGenerateAcw=true)]
	public sealed partial class UnsupportedApiCallException : global::Java.Lang.UnsupportedOperationException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/UnsupportedApiCallException", typeof (UnsupportedApiCallException));
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

		internal UnsupportedApiCallException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='UnsupportedApiCallException']/constructor[@name='UnsupportedApiCallException' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.Feature']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/Feature;)V", "")]
		public unsafe UnsupportedApiCallException (global::Huawei.Hms.Common.Feature p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/Feature;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public override unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/class[@name='UnsupportedApiCallException']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
