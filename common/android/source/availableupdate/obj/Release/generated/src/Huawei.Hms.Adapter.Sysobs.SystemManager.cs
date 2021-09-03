using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Sysobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/sysobs/SystemManager", DoNotGenerateAcw=true)]
	public sealed partial class SystemManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/field[@name='a']"
		[Register ("a")]
		public static global::Huawei.Hms.Adapter.Sysobs.SystemManager A {
			get {
				const string __id = "a.Lcom/huawei/hms/adapter/sysobs/SystemManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.SystemManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/huawei/hms/adapter/sysobs/SystemManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/field[@name='b']"
		[Register ("b")]
		public static global::Java.Lang.Object B {
			get {
				const string __id = "b.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/field[@name='c']"
		[Register ("c")]
		public static global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier C {
			get {
				const string __id = "c.Lcom/huawei/hms/adapter/sysobs/SystemNotifier;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/adapter/sysobs/SystemNotifier;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/sysobs/SystemManager", typeof (SystemManager));
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

		internal SystemManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/constructor[@name='SystemManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemManager ()
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

		public static unsafe global::Huawei.Hms.Adapter.Sysobs.SystemManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/adapter/sysobs/SystemManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/adapter/sysobs/SystemManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.SystemManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier SystemNotifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/method[@name='getSystemNotifier' and count(parameter)=0]"
			[Register ("getSystemNotifier", "()Lcom/huawei/hms/adapter/sysobs/SystemNotifier;", "")]
			get {
				const string __id = "getSystemNotifier.()Lcom/huawei/hms/adapter/sysobs/SystemNotifier;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/method[@name='notifyResolutionResult' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyResolutionResult", "(Landroid/content/Intent;Ljava/lang/String;)V", "")]
		public unsafe void NotifyResolutionResult (global::Android.Content.Intent p0, string p1)
		{
			const string __id = "notifyResolutionResult.(Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/class[@name='SystemManager']/method[@name='notifyUpdateResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyUpdateResult", "(I)V", "")]
		public unsafe void NotifyUpdateResult (int p0)
		{
			const string __id = "notifyUpdateResult.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
