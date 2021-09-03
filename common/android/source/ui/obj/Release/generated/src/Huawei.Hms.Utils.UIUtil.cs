using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/UIUtil", DoNotGenerateAcw=true)]
	public partial class UIUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/UIUtil", typeof (UIUtil));
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

		protected UIUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']/constructor[@name='UIUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UIUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']/method[@name='getActiveActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.content.Context']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']/method[@name='getProcessName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']/method[@name='isActivityFullscreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isActivityFullscreen", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool IsActivityFullscreen (global::Android.App.Activity p0)
		{
			const string __id = "isActivityFullscreen.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='UIUtil']/method[@name='isBackground' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isBackground", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsBackground (global::Android.Content.Context p0)
		{
			const string __id = "isBackground.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
