using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Support.Pm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk.support.pm']/class[@name='PackageInstallerActivity']"
	[global::Android.Runtime.Register ("com/huawei/updatesdk/support/pm/PackageInstallerActivity", DoNotGenerateAcw=true)]
	public partial class PackageInstallerActivity : global::Android.App.Activity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/support/pm/PackageInstallerActivity", typeof (PackageInstallerActivity));
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

		protected PackageInstallerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.updatesdk.support.pm']/class[@name='PackageInstallerActivity']/constructor[@name='PackageInstallerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PackageInstallerActivity ()
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

	}
}
