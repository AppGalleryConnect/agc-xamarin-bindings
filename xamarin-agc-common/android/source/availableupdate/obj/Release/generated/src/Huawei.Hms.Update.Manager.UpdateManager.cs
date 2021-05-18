using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Update.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']"
	[global::Android.Runtime.Register ("com/huawei/hms/update/manager/UpdateManager", DoNotGenerateAcw=true)]
	public partial class UpdateManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/manager/UpdateManager", typeof (UpdateManager));
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

		protected UpdateManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/constructor[@name='UpdateManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UpdateManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Integer&gt;']]"
		[Register ("a", "(Landroid/app/Activity;Ljava/util/ArrayList;)V", "")]
		public static unsafe void A (global::Android.App.Activity p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			const string __id = "a.(Landroid/app/Activity;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool A (global::Android.Content.Context p0, string p1)
		{
			const string __id = "a.(Landroid/content/Context;Ljava/lang/String;)Z";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Integer&gt;']]"
		[Register ("a", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			const string __id = "a.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool B (global::Android.Content.Context p0)
		{
			const string __id = "b.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Integer&gt;']]"
		[Register ("b", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void B (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			const string __id = "b.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool C (global::Android.Content.Context p0)
		{
			const string __id = "c.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Integer&gt;']]"
		[Register ("c", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public static unsafe void C (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			const string __id = "c.(Landroid/content/Context;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("d", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool D (global::Android.Content.Context p0)
		{
			const string __id = "d.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='getStartUpdateIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.update.ui.UpdateBean']]"
		[Register ("getStartUpdateIntent", "(Landroid/app/Activity;Lcom/huawei/hms/update/ui/UpdateBean;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetStartUpdateIntent (global::Android.App.Activity p0, global::Huawei.Hms.Update.Ui.UpdateBean p1)
		{
			const string __id = "getStartUpdateIntent.(Landroid/app/Activity;Lcom/huawei/hms/update/ui/UpdateBean;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='getStartUpdateIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.update.ui.UpdateBean']]"
		[Register ("getStartUpdateIntent", "(Landroid/content/Context;Lcom/huawei/hms/update/ui/UpdateBean;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetStartUpdateIntent (global::Android.Content.Context p0, global::Huawei.Hms.Update.Ui.UpdateBean p1)
		{
			const string __id = "getStartUpdateIntent.(Landroid/content/Context;Lcom/huawei/hms/update/ui/UpdateBean;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='startUpdate' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='com.huawei.hms.update.ui.UpdateBean']]"
		[Register ("startUpdate", "(Landroid/app/Activity;ILcom/huawei/hms/update/ui/UpdateBean;)V", "")]
		public static unsafe void StartUpdate (global::Android.App.Activity p0, int p1, global::Huawei.Hms.Update.Ui.UpdateBean p2)
		{
			const string __id = "startUpdate.(Landroid/app/Activity;ILcom/huawei/hms/update/ui/UpdateBean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='UpdateManager']/method[@name='startUpdateIntent' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("startUpdateIntent", "(Landroid/app/Activity;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent StartUpdateIntent (global::Android.App.Activity p0)
		{
			const string __id = "startUpdateIntent.(Landroid/app/Activity;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
