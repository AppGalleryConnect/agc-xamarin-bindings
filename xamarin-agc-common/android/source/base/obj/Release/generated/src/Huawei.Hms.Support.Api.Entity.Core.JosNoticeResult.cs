using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosNoticeResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/JosNoticeResult", DoNotGenerateAcw=true)]
	public partial class JosNoticeResult : global::Huawei.Hms.Support.Api.Client.Result {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/JosNoticeResult", typeof (JosNoticeResult));
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

		protected JosNoticeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosNoticeResult']/constructor[@name='JosNoticeResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JosNoticeResult ()
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