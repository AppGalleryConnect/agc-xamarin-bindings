using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ApiException']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/ApiException", DoNotGenerateAcw=true)]
	public partial class ApiException : global::Java.Lang.Exception {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ApiException']/field[@name='mStatus']"
		[Register ("mStatus")]
		protected global::Huawei.Hms.Support.Api.Client.Status MStatus {
			get {
				const string __id = "mStatus.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mStatus.Lcom/huawei/hms/support/api/client/Status;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/ApiException", typeof (ApiException));
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

		protected ApiException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ApiException']/constructor[@name='ApiException' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/Status;)V", "")]
		public unsafe ApiException (global::Huawei.Hms.Support.Api.Client.Status p0)
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

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ApiException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ApiException']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStatusMessage;
#pragma warning disable 0169
		static Delegate GetGetStatusMessageHandler ()
		{
			if (cb_getStatusMessage == null)
				cb_getStatusMessage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStatusMessage);
			return cb_getStatusMessage;
		}

		static IntPtr n_GetStatusMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.ApiException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StatusMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string StatusMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='ApiException']/method[@name='getStatusMessage' and count(parameter)=0]"
			[Register ("getStatusMessage", "()Ljava/lang/String;", "GetGetStatusMessageHandler")]
			get {
				const string __id = "getStatusMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
