using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/hianalytics/CrashHianalyticsData", DoNotGenerateAcw=true)]
	public partial class CrashHianalyticsData : global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='EXCEPTION_NAME']"
		[Register ("EXCEPTION_NAME")]
		public const string ExceptionName = (string) "exception_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public const string Message = (string) "message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='PROCESS_ID']"
		[Register ("PROCESS_ID")]
		public const string ProcessId = (string) "process_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='STACK_TRACE']"
		[Register ("STACK_TRACE")]
		public const string StackTrace = (string) "stack_trace";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='THREAD_ID']"
		[Register ("THREAD_ID")]
		public const string ThreadId = (string) "thread_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='THREAD_NAME']"
		[Register ("THREAD_NAME")]
		public const string ThreadName = (string) "thread_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/field[@name='TIME']"
		[Register ("TIME")]
		public const string Time = (string) "time";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/hianalytics/CrashHianalyticsData", typeof (CrashHianalyticsData));
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

		protected CrashHianalyticsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='CrashHianalyticsData']/constructor[@name='CrashHianalyticsData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CrashHianalyticsData ()
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
