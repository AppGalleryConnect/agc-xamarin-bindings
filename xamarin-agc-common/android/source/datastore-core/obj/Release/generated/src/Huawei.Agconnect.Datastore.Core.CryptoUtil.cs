using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Datastore.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='CryptoUtil']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/datastore/core/CryptoUtil", DoNotGenerateAcw=true)]
	public partial class CryptoUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/datastore/core/CryptoUtil", typeof (CryptoUtil));
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

		protected CryptoUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='CryptoUtil']/constructor[@name='CryptoUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CryptoUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='CryptoUtil']/method[@name='getHelper' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getHelper", "(Ljava/lang/Class;)Lcom/huawei/agconnect/datastore/annotation/ICrypto;", "")]
		public static unsafe global::Com.Huawei.Agconnect.Datastore.Annotation.ICrypto GetHelper (global::Java.Lang.Class p0)
		{
			const string __id = "getHelper.(Ljava/lang/Class;)Lcom/huawei/agconnect/datastore/annotation/ICrypto;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ICrypto> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
