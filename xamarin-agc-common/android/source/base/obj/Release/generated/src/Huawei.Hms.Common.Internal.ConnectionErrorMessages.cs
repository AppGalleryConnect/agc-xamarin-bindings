using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionErrorMessages']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ConnectionErrorMessages", DoNotGenerateAcw=true)]
	public partial class ConnectionErrorMessages : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ConnectionErrorMessages", typeof (ConnectionErrorMessages));
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

		protected ConnectionErrorMessages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionErrorMessages']/constructor[@name='ConnectionErrorMessages' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionErrorMessages ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionErrorMessages']/method[@name='getErrorDialogButtonMessage' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getErrorDialogButtonMessage", "(Landroid/app/Activity;I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorDialogButtonMessage (global::Android.App.Activity p0, int p1)
		{
			const string __id = "getErrorDialogButtonMessage.(Landroid/app/Activity;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionErrorMessages']/method[@name='getErrorMessage' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getErrorMessage", "(Landroid/app/Activity;I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorMessage (global::Android.App.Activity p0, int p1)
		{
			const string __id = "getErrorMessage.(Landroid/app/Activity;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionErrorMessages']/method[@name='getErrorTitle' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("getErrorTitle", "(Landroid/app/Activity;I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorTitle (global::Android.App.Activity p0, int p1)
		{
			const string __id = "getErrorTitle.(Landroid/app/Activity;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
