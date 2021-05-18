using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ErrorDialogFragment']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/ErrorDialogFragment", DoNotGenerateAcw=true)]
	public partial class ErrorDialogFragment : global::Android.App.DialogFragment {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/ErrorDialogFragment", typeof (ErrorDialogFragment));
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

		protected ErrorDialogFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ErrorDialogFragment']/constructor[@name='ErrorDialogFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorDialogFragment ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ErrorDialogFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("newInstance", "(Landroid/app/Dialog;)Lcom/huawei/hms/common/ErrorDialogFragment;", "")]
		public static unsafe global::Huawei.Hms.Common.ErrorDialogFragment NewInstance (global::Android.App.Dialog p0)
		{
			const string __id = "newInstance.(Landroid/app/Dialog;)Lcom/huawei/hms/common/ErrorDialogFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ErrorDialogFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ErrorDialogFragment']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='android.app.Dialog'] and parameter[2][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("newInstance", "(Landroid/app/Dialog;Landroid/content/DialogInterface$OnCancelListener;)Lcom/huawei/hms/common/ErrorDialogFragment;", "")]
		public static unsafe global::Huawei.Hms.Common.ErrorDialogFragment NewInstance (global::Android.App.Dialog p0, global::Android.Content.IDialogInterfaceOnCancelListener p1)
		{
			const string __id = "newInstance.(Landroid/app/Dialog;Landroid/content/DialogInterface$OnCancelListener;)Lcom/huawei/hms/common/ErrorDialogFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ErrorDialogFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
