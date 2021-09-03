using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/android/SystemUtils", DoNotGenerateAcw=true)]
	public partial class SystemUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/android/SystemUtils", typeof (SystemUtils));
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

		protected SystemUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/constructor[@name='SystemUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemUtils ()
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='isChinaROM' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='isEMUI' and count(parameter)=0]"
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

		public static unsafe bool IsTVDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='isTVDevice' and count(parameter)=0]"
			[Register ("isTVDevice", "()Z", "")]
			get {
				const string __id = "isTVDevice.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string LocalCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='getLocalCountry' and count(parameter)=0]"
			[Register ("getLocalCountry", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLocalCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public static unsafe string A ()
		{
			const string __id = "a.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "")]
		public static unsafe string B ()
		{
			const string __id = "b.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='getNetType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='getSystemProperties' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='SystemUtils']/method[@name='isSystemApp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isSystemApp", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsSystemApp (global::Android.Content.Context p0, string p1)
		{
			const string __id = "isSystemApp.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
