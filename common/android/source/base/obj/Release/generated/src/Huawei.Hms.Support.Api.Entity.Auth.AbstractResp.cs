using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/auth/AbstractResp", DoNotGenerateAcw=true)]
	public abstract partial class AbstractResp : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/auth/AbstractResp", typeof (AbstractResp));
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

		protected AbstractResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']/constructor[@name='AbstractResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractResp ()
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

		static Delegate cb_getErrorReason;
#pragma warning disable 0169
		static Delegate GetGetErrorReasonHandler ()
		{
			if (cb_getErrorReason == null)
				cb_getErrorReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorReason);
			return cb_getErrorReason;
		}

		static IntPtr n_GetErrorReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Auth.AbstractResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorReason);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorReason_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorReason_Ljava_lang_String_ == null)
				cb_setErrorReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetErrorReason_Ljava_lang_String_);
			return cb_setErrorReason_Ljava_lang_String_;
		}

		static void n_SetErrorReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Auth.AbstractResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorReason = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']/method[@name='getErrorReason' and count(parameter)=0]"
			[Register ("getErrorReason", "()Ljava/lang/String;", "GetGetErrorReasonHandler")]
			get {
				const string __id = "getErrorReason.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']/method[@name='setErrorReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorReason", "(Ljava/lang/String;)V", "GetSetErrorReason_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorReason.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRtnCode;
#pragma warning disable 0169
		static Delegate GetGetRtnCodeHandler ()
		{
			if (cb_getRtnCode == null)
				cb_getRtnCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRtnCode);
			return cb_getRtnCode;
		}

		static int n_GetRtnCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Auth.AbstractResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RtnCode;
		}
#pragma warning restore 0169

		static Delegate cb_setRtnCode_I;
#pragma warning disable 0169
		static Delegate GetSetRtnCode_IHandler ()
		{
			if (cb_setRtnCode_I == null)
				cb_setRtnCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRtnCode_I);
			return cb_setRtnCode_I;
		}

		static void n_SetRtnCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Auth.AbstractResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RtnCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RtnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']/method[@name='getRtnCode' and count(parameter)=0]"
			[Register ("getRtnCode", "()I", "GetGetRtnCodeHandler")]
			get {
				const string __id = "getRtnCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/class[@name='AbstractResp']/method[@name='setRtnCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRtnCode", "(I)V", "GetSetRtnCode_IHandler")]
			set {
				const string __id = "setRtnCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/auth/AbstractResp", DoNotGenerateAcw=true)]
	internal partial class AbstractRespInvoker : AbstractResp {

		public AbstractRespInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/auth/AbstractResp", typeof (AbstractRespInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
