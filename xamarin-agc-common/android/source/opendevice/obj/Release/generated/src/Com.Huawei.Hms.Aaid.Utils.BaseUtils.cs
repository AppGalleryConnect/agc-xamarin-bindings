using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Hms.Aaid.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/utils/BaseUtils", DoNotGenerateAcw=true)]
	public partial class BaseUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/utils/BaseUtils", typeof (BaseUtils));
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

		protected BaseUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/constructor[@name='BaseUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='clearSubjectIds' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearSubjectIds", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearSubjectIds (global::Android.Content.Context p0)
		{
			const string __id = "clearSubjectIds.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='delLocalToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("delLocalToken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DelLocalToken (global::Android.Content.Context p0, string p1)
		{
			const string __id = "delLocalToken.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='deleteAllTokenCache' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("deleteAllTokenCache", "(Landroid/content/Context;)V", "")]
		public static unsafe void DeleteAllTokenCache (global::Android.Content.Context p0)
		{
			const string __id = "deleteAllTokenCache.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='deleteCacheData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteCacheData", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteCacheData (global::Android.Content.Context p0, string p1)
		{
			const string __id = "deleteCacheData.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='getBaseUrl' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getBaseUrl", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetBaseUrl (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "getBaseUrl.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='getCacheData' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getCacheData", "(Landroid/content/Context;Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string GetCacheData (global::Android.Content.Context p0, string p1, bool p2)
		{
			const string __id = "getCacheData.(Landroid/content/Context;Ljava/lang/String;Z)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='getLocalToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLocalToken", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLocalToken (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getLocalToken.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='getSubjectIds' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSubjectIds", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetSubjectIds (global::Android.Content.Context p0)
		{
			const string __id = "getSubjectIds.(Landroid/content/Context;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='initSecret' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initSecret", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitSecret (global::Android.Content.Context p0)
		{
			const string __id = "initSecret.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='reportAaidToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportAaidToken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportAaidToken (global::Android.Content.Context p0, string p1)
		{
			const string __id = "reportAaidToken.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='saveCacheData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("saveCacheData", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool SaveCacheData (global::Android.Content.Context p0, string p1, string p2, bool p3)
		{
			const string __id = "saveCacheData.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='saveToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SaveToken (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "saveToken.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='BaseUtils']/method[@name='sendPostRequest' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("sendPostRequest", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string SendPostRequest (global::Android.Content.Context p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			const string __id = "sendPostRequest.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
