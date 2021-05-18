using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Uı {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeIntent']"
	[global::Android.Runtime.Register ("com/huawei/hms/ui/SafeIntent", DoNotGenerateAcw=true)]
	public partial class SafeIntent : global::Android.Content.Intent {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/SafeIntent", typeof (SafeIntent));
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

		protected SafeIntent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeIntent']/constructor[@name='SafeIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register (".ctor", "(Landroid/content/Intent;)V", "")]
		public unsafe SafeIntent (global::Android.Content.Intent p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Intent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
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

	}
}
