using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ContainerUtils", DoNotGenerateAcw=true)]
	public partial class ContainerUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/field[@name='FIELD_DELIMITER']"
		[Register ("FIELD_DELIMITER")]
		public const string FieldDelimiter = (string) "&";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/field[@name='KEY_VALUE_DELIMITER']"
		[Register ("KEY_VALUE_DELIMITER")]
		public const string KeyValueDelimiter = (string) "=";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ContainerUtils", typeof (ContainerUtils));
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

		protected ContainerUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/constructor[@name='ContainerUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContainerUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;K, V&gt;'] and parameter[2][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("equals", "(Ljava/util/Map;Ljava/util/Map;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe bool Equals (global::System.Collections.IDictionary p0, global::System.Collections.IDictionary p1)
		{
			const string __id = "equals.(Ljava/util/Map;Ljava/util/Map;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("hashCode", "(Ljava/util/Map;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe int HashCode (global::System.Collections.IDictionary p0)
		{
			const string __id = "hashCode.(Ljava/util/Map;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;K&gt;']]"
		[Register ("toString", "(Ljava/util/List;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public static unsafe string ToString (global::System.Collections.IList p0)
		{
			const string __id = "toString.(Ljava/util/List;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("toString", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe string ToString (global::System.Collections.IDictionary p0)
		{
			const string __id = "toString.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ContainerUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;K&gt;']]"
		[Register ("toString", "(Ljava/util/Set;)Ljava/lang/String;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public static unsafe string ToString (global::System.Collections.ICollection p0)
		{
			const string __id = "toString.(Ljava/util/Set;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaSet.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
