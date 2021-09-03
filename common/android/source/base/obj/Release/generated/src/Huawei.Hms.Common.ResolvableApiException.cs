using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ResolvableApiException']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/ResolvableApiException", DoNotGenerateAcw=true)]
	public partial class ResolvableApiException : global::Huawei.Hms.Common.ApiException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/ResolvableApiException", typeof (ResolvableApiException));
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

		protected ResolvableApiException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ResolvableApiException']/constructor[@name='ResolvableApiException' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/Status;)V", "")]
		public unsafe ResolvableApiException (global::Huawei.Hms.Support.Api.Client.Status p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/Status;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
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

		static Delegate cb_getResolution;
#pragma warning disable 0169
		static Delegate GetGetResolutionHandler ()
		{
			if (cb_getResolution == null)
				cb_getResolution = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResolution);
			return cb_getResolution;
		}

		static IntPtr n_GetResolution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ResolvableApiException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resolution);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.PendingIntent Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ResolvableApiException']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Landroid/app/PendingIntent;", "GetGetResolutionHandler")]
			get {
				const string __id = "getResolution.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_startResolutionForResult_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetStartResolutionForResult_Landroid_app_Activity_IHandler ()
		{
			if (cb_startResolutionForResult_Landroid_app_Activity_I == null)
				cb_startResolutionForResult_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_StartResolutionForResult_Landroid_app_Activity_I);
			return cb_startResolutionForResult_Landroid_app_Activity_I;
		}

		static void n_StartResolutionForResult_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ResolvableApiException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartResolutionForResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ResolvableApiException']/method[@name='startResolutionForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("startResolutionForResult", "(Landroid/app/Activity;I)V", "GetStartResolutionForResult_Landroid_app_Activity_IHandler")]
		public virtual unsafe void StartResolutionForResult (global::Android.App.Activity p0, int p1)
		{
			const string __id = "startResolutionForResult.(Landroid/app/Activity;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
