using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https.adapter']/class[@name='JsonAdapterFactory']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/adapter/JsonAdapterFactory", DoNotGenerateAcw=true)]
	public partial class JsonAdapterFactory : global::Huawei.Agconnect.Https.AdapterFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/adapter/JsonAdapterFactory", typeof (JsonAdapterFactory));
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

		protected JsonAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https.adapter']/class[@name='JsonAdapterFactory']/constructor[@name='JsonAdapterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonAdapterFactory ()
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
