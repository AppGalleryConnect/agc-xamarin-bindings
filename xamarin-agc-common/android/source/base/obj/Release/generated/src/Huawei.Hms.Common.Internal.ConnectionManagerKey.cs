using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionManagerKey']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ConnectionManagerKey", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TOption extends com.huawei.hms.api.Api.ApiOptions"})]
	public partial class ConnectionManagerKey : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ConnectionManagerKey", typeof (ConnectionManagerKey));
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

		protected ConnectionManagerKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionManagerKey']/method[@name='createConnectionManagerKey' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[3][@type='TOption'] and parameter[4][@type='java.lang.String']]"
		[Register ("createConnectionManagerKey", "(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Ljava/lang/String;)Lcom/huawei/hms/common/internal/ConnectionManagerKey;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TOption extends com.huawei.hms.api.Api.ApiOptions"})]
		public static unsafe global::Huawei.Hms.Common.Internal.ConnectionManagerKey CreateConnectionManagerKey (global::Android.Content.Context p0, global::Huawei.Hms.Api.Api p1, global::Java.Lang.Object p2, string p3)
		{
			const string __id = "createConnectionManagerKey.(Landroid/content/Context;Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions;Ljava/lang/String;)Lcom/huawei/hms/common/internal/ConnectionManagerKey;";
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ConnectionManagerKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionManagerKey']/method[@name='createConnectionManagerKey' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.api.Api&lt;TOption&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("createConnectionManagerKey", "(Lcom/huawei/hms/api/Api;Ljava/lang/String;)Lcom/huawei/hms/common/internal/ConnectionManagerKey;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TOption extends com.huawei.hms.api.Api.ApiOptions"})]
		public static unsafe global::Huawei.Hms.Common.Internal.ConnectionManagerKey CreateConnectionManagerKey (global::Huawei.Hms.Api.Api p0, string p1)
		{
			const string __id = "createConnectionManagerKey.(Lcom/huawei/hms/api/Api;Ljava/lang/String;)Lcom/huawei/hms/common/internal/ConnectionManagerKey;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ConnectionManagerKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionManagerKey']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ConnectionManagerKey']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
