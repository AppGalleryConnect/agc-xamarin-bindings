using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.init']/class[@name='AutoInitHelper']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/init/AutoInitHelper", DoNotGenerateAcw=true)]
	public partial class AutoInitHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/init/AutoInitHelper", typeof (AutoInitHelper));
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

		protected AutoInitHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.init']/class[@name='AutoInitHelper']/constructor[@name='AutoInitHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AutoInitHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.init']/class[@name='AutoInitHelper']/method[@name='doAutoInit' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("doAutoInit", "(Landroid/content/Context;)V", "")]
		public static unsafe void DoAutoInit (global::Android.Content.Context p0)
		{
			const string __id = "doAutoInit.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.init']/class[@name='AutoInitHelper']/method[@name='isAutoInitEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAutoInitEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsAutoInitEnabled (global::Android.Content.Context p0)
		{
			const string __id = "isAutoInitEnabled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.init']/class[@name='AutoInitHelper']/method[@name='setAutoInitEnabled' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setAutoInitEnabled", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetAutoInitEnabled (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setAutoInitEnabled.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
