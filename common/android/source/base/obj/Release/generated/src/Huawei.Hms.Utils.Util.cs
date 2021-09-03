using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/Util", typeof (Util));
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

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
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

		public static unsafe bool IsChinaROM {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='isChinaROM' and count(parameter)=0]"
			[Register ("isChinaROM", "()Z", "")]
			get {
				const string __id = "isChinaROM.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsEMUI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='isEMUI' and count(parameter)=0]"
			[Register ("isEMUI", "()Z", "")]
			get {
				const string __id = "isEMUI.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string ProductCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getProductCountry' and count(parameter)=0]"
			[Register ("getProductCountry", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getProductCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='compareHmsVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareHmsVersion", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareHmsVersion (string p0, string p1)
		{
			const string __id = "compareHmsVersion.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getActiveActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.content.Context']]"
		[Register ("getActiveActivity", "(Landroid/app/Activity;Landroid/content/Context;)Landroid/app/Activity;", "")]
		public static unsafe global::Android.App.Activity GetActiveActivity (global::Android.App.Activity p0, global::Android.Content.Context p1)
		{
			const string __id = "getActiveActivity.(Landroid/app/Activity;Landroid/content/Context;)Landroid/app/Activity;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getAppId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppId (global::Android.Content.Context p0)
		{
			const string __id = "getAppId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getAppName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAppName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAppName (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getAppName.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getCpId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCpId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCpId (global::Android.Content.Context p0)
		{
			const string __id = "getCpId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getHmsVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getHmsVersion", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetHmsVersion (global::Android.Content.Context p0)
		{
			const string __id = "getHmsVersion.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getNetType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetType", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetNetType (global::Android.Content.Context p0)
		{
			const string __id = "getNetType.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getProcessName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getProcessName", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetProcessName (global::Android.Content.Context p0, int p1)
		{
			const string __id = "getProcessName.(Landroid/content/Context;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getServiceActionMetadata' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getServiceActionMetadata", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetServiceActionMetadata (global::Android.Content.Context p0)
		{
			const string __id = "getServiceActionMetadata.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getSystemProperties' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSystemProperties", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSystemProperties (string p0, string p1)
		{
			const string __id = "getSystemProperties.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='getValidActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.app.Activity']]"
		[Register ("getValidActivity", "(Landroid/app/Activity;Landroid/app/Activity;)Landroid/app/Activity;", "")]
		public static unsafe global::Android.App.Activity GetValidActivity (global::Android.App.Activity p0, global::Android.App.Activity p1)
		{
			const string __id = "getValidActivity.(Landroid/app/Activity;Landroid/app/Activity;)Landroid/app/Activity;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='isAvailableLibExist' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAvailableLibExist", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsAvailableLibExist (global::Android.Content.Context p0)
		{
			const string __id = "isAvailableLibExist.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='Util']/method[@name='unBindServiceCatchException' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.ServiceConnection']]"
		[Register ("unBindServiceCatchException", "(Landroid/content/Context;Landroid/content/ServiceConnection;)V", "")]
		public static unsafe void UnBindServiceCatchException (global::Android.Content.Context p0, global::Android.Content.IServiceConnection p1)
		{
			const string __id = "unBindServiceCatchException.(Landroid/content/Context;Landroid/content/ServiceConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
