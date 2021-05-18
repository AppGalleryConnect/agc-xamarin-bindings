using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/FileUtil", DoNotGenerateAcw=true)]
	public abstract partial class FileUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/field[@name='LOCAL_REPORT_FILE']"
		[Register ("LOCAL_REPORT_FILE")]
		public const string LocalReportFile = (string) "hms/HwMobileServiceReport.txt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/field[@name='LOCAL_REPORT_FILE_CONFIG']"
		[Register ("LOCAL_REPORT_FILE_CONFIG")]
		public const string LocalReportFileConfig = (string) "hms/config.txt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/field[@name='LOCAL_REPORT_FILE_MAX_SIZE']"
		[Register ("LOCAL_REPORT_FILE_MAX_SIZE")]
		public const long LocalReportFileMaxSize = (long) 10240;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/field[@name='a']"
		[Register ("a")]
		public static bool A {
			get {
				const string __id = "a.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "a.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/field[@name='b']"
		[Register ("b")]
		public static global::Java.Util.Concurrent.IScheduledExecutorService B {
			get {
				const string __id = "b.Ljava/util/concurrent/ScheduledExecutorService;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledExecutorService> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/util/concurrent/ScheduledExecutorService;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/FileUtil", typeof (FileUtil));
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

		protected FileUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/constructor[@name='FileUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/method[@name='verifyHash' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("verifyHash", "(Ljava/lang/String;Ljava/io/File;)Z", "")]
		public static unsafe bool VerifyHash (string p0, global::Java.IO.File p1)
		{
			const string __id = "verifyHash.(Ljava/lang/String;Ljava/io/File;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/lang/String;J)V", "")]
		public static unsafe void WriteFile (global::Java.IO.File p0, string p1, long p2)
		{
			const string __id = "writeFile.(Ljava/io/File;Ljava/lang/String;J)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='FileUtil']/method[@name='writeFileReport' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.io.File'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='int']]"
		[Register ("writeFileReport", "(Landroid/content/Context;Ljava/io/File;Ljava/io/File;Ljava/lang/String;JI)V", "")]
		public static unsafe void WriteFileReport (global::Android.Content.Context p0, global::Java.IO.File p1, global::Java.IO.File p2, string p3, long p4, int p5)
		{
			const string __id = "writeFileReport.(Landroid/content/Context;Ljava/io/File;Ljava/io/File;Ljava/lang/String;JI)V";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/utils/FileUtil", DoNotGenerateAcw=true)]
	internal partial class FileUtilInvoker : FileUtil {

		public FileUtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/FileUtil", typeof (FileUtilInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
