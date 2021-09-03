using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/BundleResult", DoNotGenerateAcw=true)]
	public partial class BundleResult : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/BundleResult", typeof (BundleResult));
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

		protected BundleResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']/constructor[@name='BundleResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register (".ctor", "(ILandroid/os/Bundle;)V", "")]
		public unsafe BundleResult (int p0, global::Android.OS.Bundle p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/os/Bundle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetResultCode);
			return cb_getResultCode;
		}

		static int n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.BundleResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultCode;
		}
#pragma warning restore 0169

		static Delegate cb_setResultCode_I;
#pragma warning disable 0169
		static Delegate GetSetResultCode_IHandler ()
		{
			if (cb_setResultCode_I == null)
				cb_setResultCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetResultCode_I);
			return cb_setResultCode_I;
		}

		static void n_SetResultCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.BundleResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResultCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()I", "GetGetResultCodeHandler")]
			get {
				const string __id = "getResultCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']/method[@name='setResultCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResultCode", "(I)V", "GetSetResultCode_IHandler")]
			set {
				const string __id = "setResultCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRspBody;
#pragma warning disable 0169
		static Delegate GetGetRspBodyHandler ()
		{
			if (cb_getRspBody == null)
				cb_getRspBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRspBody);
			return cb_getRspBody;
		}

		static IntPtr n_GetRspBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.BundleResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RspBody);
		}
#pragma warning restore 0169

		static Delegate cb_setRspBody_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetRspBody_Landroid_os_Bundle_Handler ()
		{
			if (cb_setRspBody_Landroid_os_Bundle_ == null)
				cb_setRspBody_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRspBody_Landroid_os_Bundle_);
			return cb_setRspBody_Landroid_os_Bundle_;
		}

		static void n_SetRspBody_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.BundleResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RspBody = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle RspBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']/method[@name='getRspBody' and count(parameter)=0]"
			[Register ("getRspBody", "()Landroid/os/Bundle;", "GetGetRspBodyHandler")]
			get {
				const string __id = "getRspBody.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='BundleResult']/method[@name='setRspBody' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setRspBody", "(Landroid/os/Bundle;)V", "GetSetRspBody_Landroid_os_Bundle_Handler")]
			set {
				const string __id = "setRspBody.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
