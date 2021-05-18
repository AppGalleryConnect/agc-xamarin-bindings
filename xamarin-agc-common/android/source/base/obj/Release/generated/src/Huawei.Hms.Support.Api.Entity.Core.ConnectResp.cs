using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/ConnectResp", DoNotGenerateAcw=true)]
	public partial class ConnectResp : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectResp']/field[@name='protocolVersion']"
		[Register ("protocolVersion")]
		public global::System.Collections.IList ProtocolVersion {
			get {
				const string __id = "protocolVersion.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "protocolVersion.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectResp']/field[@name='sessionId']"
		[Register ("sessionId")]
		public string SessionId {
			get {
				const string __id = "sessionId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sessionId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/ConnectResp", typeof (ConnectResp));
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

		protected ConnectResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectResp']/constructor[@name='ConnectResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectResp ()
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
