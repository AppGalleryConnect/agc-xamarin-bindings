using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirectImpl']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/DialogRedirectImpl", DoNotGenerateAcw=true)]
	public partial class DialogRedirectImpl : global::Huawei.Hms.Common.Internal.DialogRedirect {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/DialogRedirectImpl", typeof (DialogRedirectImpl));
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

		protected DialogRedirectImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirectImpl']/method[@name='redirect' and count(parameter)=0]"
		[Register ("redirect", "()V", "")]
		protected override sealed unsafe void Redirect ()
		{
			const string __id = "redirect.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
