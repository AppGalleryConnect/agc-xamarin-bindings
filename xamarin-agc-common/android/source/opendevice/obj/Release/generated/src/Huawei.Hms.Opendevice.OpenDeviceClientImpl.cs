using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']"
	[global::Android.Runtime.Register ("com/huawei/hms/opendevice/OpenDeviceClientImpl", DoNotGenerateAcw=true)]
	public partial class OpenDeviceClientImpl : global::Huawei.Hms.Common.HuaweiApi, global::Huawei.Hms.Opendevice.IOpenDeviceClient {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/field[@name='a']"
		[Register ("a")]
		public static global::Huawei.Hms.Opendevice.OpenDeviceHmsClientBuilder A {
			get {
				const string __id = "a.Lcom/huawei/hms/opendevice/OpenDeviceHmsClientBuilder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceHmsClientBuilder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/field[@name='b']"
		[Register ("b")]
		public static global::Huawei.Hms.Api.Api B {
			get {
				const string __id = "b.Lcom/huawei/hms/api/Api;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/field[@name='c']"
		[Register ("c")]
		public static global::Huawei.Hms.Opendevice.OpenDeviceOptions C {
			get {
				const string __id = "c.Lcom/huawei/hms/opendevice/OpenDeviceOptions;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/opendevice/OpenDeviceOptions;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/opendevice/OpenDeviceClientImpl", typeof (OpenDeviceClientImpl));
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

		protected OpenDeviceClientImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/constructor[@name='OpenDeviceClientImpl' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe OpenDeviceClientImpl (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/constructor[@name='OpenDeviceClientImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe OpenDeviceClientImpl (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getOdid;
#pragma warning disable 0169
		static Delegate GetGetOdidHandler ()
		{
			if (cb_getOdid == null)
				cb_getOdid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOdid);
			return cb_getOdid;
		}

		static IntPtr n_GetOdid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Opendevice.OpenDeviceClientImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Odid);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.Task Odid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceClientImpl']/method[@name='getOdid' and count(parameter)=0]"
			[Register ("getOdid", "()Lcom/huawei/hmf/tasks/Task;", "GetGetOdidHandler")]
			get {
				const string __id = "getOdid.()Lcom/huawei/hmf/tasks/Task;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
