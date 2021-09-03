using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='CheckConnectResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/CheckConnectResp", DoNotGenerateAcw=true)]
	public partial class CheckConnectResp : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/CheckConnectResp", typeof (CheckConnectResp));
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

		protected CheckConnectResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='CheckConnectResp']/constructor[@name='CheckConnectResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CheckConnectResp ()
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
