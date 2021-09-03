using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='SubAppInfo']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/SubAppInfo", DoNotGenerateAcw=true)]
	public partial class SubAppInfo : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/SubAppInfo", typeof (SubAppInfo));
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

		protected SubAppInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='SubAppInfo']/constructor[@name='SubAppInfo' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)V", "")]
		public unsafe SubAppInfo (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/SubAppInfo;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='SubAppInfo']/constructor[@name='SubAppInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SubAppInfo (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSubAppID;
#pragma warning disable 0169
		static Delegate GetGetSubAppIDHandler ()
		{
			if (cb_getSubAppID == null)
				cb_getSubAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubAppID);
			return cb_getSubAppID;
		}

		static IntPtr n_GetSubAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubAppID);
		}
#pragma warning restore 0169

		static Delegate cb_setSubAppID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubAppID_Ljava_lang_String_Handler ()
		{
			if (cb_setSubAppID_Ljava_lang_String_ == null)
				cb_setSubAppID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubAppID_Ljava_lang_String_);
			return cb_setSubAppID_Ljava_lang_String_;
		}

		static void n_SetSubAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubAppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='SubAppInfo']/method[@name='getSubAppID' and count(parameter)=0]"
			[Register ("getSubAppID", "()Ljava/lang/String;", "GetGetSubAppIDHandler")]
			get {
				const string __id = "getSubAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='SubAppInfo']/method[@name='setSubAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubAppID", "(Ljava/lang/String;)V", "GetSetSubAppID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubAppID.(Ljava/lang/String;)V";
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

	}
}
