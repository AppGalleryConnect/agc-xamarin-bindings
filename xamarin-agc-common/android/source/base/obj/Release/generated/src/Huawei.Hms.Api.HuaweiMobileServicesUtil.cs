using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiMobileServicesUtil", DoNotGenerateAcw=true)]
	public abstract partial class HuaweiMobileServicesUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/field[@name='HMS_ERROR_DIALOG']"
		[Register ("HMS_ERROR_DIALOG")]
		public const string HmsErrorDialog = (string) "HuaweiMobileServicesErrorDialog";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiMobileServicesUtil", typeof (HuaweiMobileServicesUtil));
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

		protected HuaweiMobileServicesUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/constructor[@name='HuaweiMobileServicesUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiMobileServicesUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getErrorDialog' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int']]"
		[Register ("getErrorDialog", "(ILandroid/app/Activity;I)Landroid/app/Dialog;", "")]
		public static unsafe global::Android.App.Dialog GetErrorDialog (int p0, global::Android.App.Activity p1, int p2)
		{
			const string __id = "getErrorDialog.(ILandroid/app/Activity;I)Landroid/app/Dialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getErrorDialog' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("getErrorDialog", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;", "")]
		public static unsafe global::Android.App.Dialog GetErrorDialog (int p0, global::Android.App.Activity p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3)
		{
			const string __id = "getErrorDialog.(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Landroid/app/Dialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorString (int p0)
		{
			const string __id = "getErrorString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getOpenSourceSoftwareLicenseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetOpenSourceSoftwareLicenseInfo (global::Android.Content.Context p0)
		{
			const string __id = "getOpenSourceSoftwareLicenseInfo.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getRemoteContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteContext", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public static unsafe global::Android.Content.Context GetRemoteContext (global::Android.Content.Context p0)
		{
			const string __id = "getRemoteContext.(Landroid/content/Context;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='getRemoteResource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteResource", "(Landroid/content/Context;)Landroid/content/res/Resources;", "")]
		public static unsafe global::Android.Content.Res.Resources GetRemoteResource (global::Android.Content.Context p0)
		{
			const string __id = "getRemoteResource.(Landroid/content/Context;)Landroid/content/res/Resources;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;)I", "")]
		public static unsafe int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0)
		{
			const string __id = "isHuaweiMobileServicesAvailable.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;I)I", "")]
		public static unsafe int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0, int p1)
		{
			const string __id = "isHuaweiMobileServicesAvailable.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='isUserRecoverableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserRecoverableError", "(I)Z", "")]
		public static unsafe bool IsUserRecoverableError (int p0)
		{
			const string __id = "isUserRecoverableError.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='popupErrDlgFragment' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='android.app.Fragment'] and parameter[4][@type='int'] and parameter[5][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("popupErrDlgFragment", "(ILandroid/app/Activity;Landroid/app/Fragment;ILandroid/content/DialogInterface$OnCancelListener;)Z", "")]
		public static unsafe bool PopupErrDlgFragment (int p0, global::Android.App.Activity p1, global::Android.App.Fragment p2, int p3, global::Android.Content.IDialogInterfaceOnCancelListener p4)
		{
			const string __id = "popupErrDlgFragment.(ILandroid/app/Activity;Landroid/app/Fragment;ILandroid/content/DialogInterface$OnCancelListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='popupErrDlgFragment' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int'] and parameter[4][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register ("popupErrDlgFragment", "(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Z", "")]
		public static unsafe bool PopupErrDlgFragment (int p0, global::Android.App.Activity p1, int p2, global::Android.Content.IDialogInterfaceOnCancelListener p3)
		{
			const string __id = "popupErrDlgFragment.(ILandroid/app/Activity;ILandroid/content/DialogInterface$OnCancelListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("setApplication", "(Landroid/app/Application;)V", "")]
		public static unsafe void SetApplication (global::Android.App.Application p0)
		{
			const string __id = "setApplication.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='showErrorDialogFragment' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='int']]"
		[Register ("showErrorDialogFragment", "(ILandroid/app/Activity;I)Z", "")]
		public static unsafe bool ShowErrorDialogFragment (int p0, global::Android.App.Activity p1, int p2)
		{
			const string __id = "showErrorDialogFragment.(ILandroid/app/Activity;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiMobileServicesUtil']/method[@name='showErrorNotification' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("showErrorNotification", "(ILandroid/content/Context;)V", "")]
		public static unsafe void ShowErrorNotification (int p0, global::Android.Content.Context p1)
		{
			const string __id = "showErrorNotification.(ILandroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiMobileServicesUtil", DoNotGenerateAcw=true)]
	internal partial class HuaweiMobileServicesUtilInvoker : HuaweiMobileServicesUtil {

		public HuaweiMobileServicesUtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiMobileServicesUtil", typeof (HuaweiMobileServicesUtilInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
