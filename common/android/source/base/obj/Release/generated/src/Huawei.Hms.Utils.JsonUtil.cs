using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/JsonUtil", DoNotGenerateAcw=true)]
	public partial class JsonUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_BYTE']"
		[Register ("VAL_BYTE")]
		protected const int ValByte = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_ENTITY']"
		[Register ("VAL_ENTITY")]
		protected const int ValEntity = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_LIST']"
		[Register ("VAL_LIST")]
		protected const int ValList = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_MAP']"
		[Register ("VAL_MAP")]
		protected const int ValMap = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_NULL']"
		[Register ("VAL_NULL")]
		protected const int ValNull = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/field[@name='VAL_TYPE']"
		[Register ("VAL_TYPE")]
		protected const string ValType = (string) "_val_type_";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/JsonUtil", typeof (JsonUtil));
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

		protected JsonUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/constructor[@name='JsonUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/method[@name='createJsonString' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.core.aidl.IMessageEntity']]"
		[Register ("createJsonString", "(Lcom/huawei/hms/core/aidl/IMessageEntity;)Ljava/lang/String;", "")]
		public static unsafe string CreateJsonString (global::Huawei.Hms.Core.Aidl.IMessageEntity p0)
		{
			const string __id = "createJsonString.(Lcom/huawei/hms/core/aidl/IMessageEntity;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/method[@name='getInfoFromJsonobject' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInfoFromJsonobject", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetInfoFromJsonobject (string p0, string p1)
		{
			const string __id = "getInfoFromJsonobject.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/method[@name='getIntValue' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIntValue", "(Lorg/json/JSONObject;Ljava/lang/String;)I", "")]
		public static unsafe int GetIntValue (global::Org.Json.JSONObject p0, string p1)
		{
			const string __id = "getIntValue.(Lorg/json/JSONObject;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/method[@name='getStringValue' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringValue", "(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetStringValue (global::Org.Json.JSONObject p0, string p1)
		{
			const string __id = "getStringValue.(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='JsonUtil']/method[@name='jsonToEntity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.core.aidl.IMessageEntity']]"
		[Register ("jsonToEntity", "(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;)Lcom/huawei/hms/core/aidl/IMessageEntity;", "")]
		public static unsafe global::Huawei.Hms.Core.Aidl.IMessageEntity JsonToEntity (string p0, global::Huawei.Hms.Core.Aidl.IMessageEntity p1)
		{
			const string __id = "jsonToEntity.(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;)Lcom/huawei/hms/core/aidl/IMessageEntity;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.IMessageEntity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
