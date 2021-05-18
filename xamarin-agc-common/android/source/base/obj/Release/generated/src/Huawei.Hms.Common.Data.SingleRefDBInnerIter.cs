using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='SingleRefDBInnerIter']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/SingleRefDBInnerIter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class SingleRefDBInnerIter : global::Huawei.Hms.Common.Data.DBInnerIter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/SingleRefDBInnerIter", typeof (SingleRefDBInnerIter));
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

		protected SingleRefDBInnerIter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='SingleRefDBInnerIter']/constructor[@name='SingleRefDBInnerIter' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/data/DataBuffer;)V", "")]
		public unsafe SingleRefDBInnerIter (global::Huawei.Hms.Common.Data.IDataBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/data/DataBuffer;)V";

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
