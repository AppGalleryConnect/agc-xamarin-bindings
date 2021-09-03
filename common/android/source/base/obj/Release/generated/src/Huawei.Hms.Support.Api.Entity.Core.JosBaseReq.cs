using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/JosBaseReq", DoNotGenerateAcw=true)]
	public partial class JosBaseReq : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/JosBaseReq", typeof (JosBaseReq));
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

		protected JosBaseReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/constructor[@name='JosBaseReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JosBaseReq ()
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

		static Delegate cb_getChannelId;
#pragma warning disable 0169
		static Delegate GetGetChannelIdHandler ()
		{
			if (cb_getChannelId == null)
				cb_getChannelId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChannelId);
			return cb_getChannelId;
		}

		static IntPtr n_GetChannelId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelId);
		}
#pragma warning restore 0169

		static Delegate cb_setChannelId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannelId_Ljava_lang_String_Handler ()
		{
			if (cb_setChannelId_Ljava_lang_String_ == null)
				cb_setChannelId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetChannelId_Ljava_lang_String_);
			return cb_setChannelId_Ljava_lang_String_;
		}

		static void n_SetChannelId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChannelId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChannelId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='getChannelId' and count(parameter)=0]"
			[Register ("getChannelId", "()Ljava/lang/String;", "GetGetChannelIdHandler")]
			get {
				const string __id = "getChannelId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='setChannelId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChannelId", "(Ljava/lang/String;)V", "GetSetChannelId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChannelId.(Ljava/lang/String;)V";
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

		static Delegate cb_getCpID;
#pragma warning disable 0169
		static Delegate GetGetCpIDHandler ()
		{
			if (cb_getCpID == null)
				cb_getCpID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCpID);
			return cb_getCpID;
		}

		static IntPtr n_GetCpID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CpID);
		}
#pragma warning restore 0169

		static Delegate cb_setCpID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCpID_Ljava_lang_String_Handler ()
		{
			if (cb_setCpID_Ljava_lang_String_ == null)
				cb_setCpID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCpID_Ljava_lang_String_);
			return cb_setCpID_Ljava_lang_String_;
		}

		static void n_SetCpID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CpID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CpID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='getCpID' and count(parameter)=0]"
			[Register ("getCpID", "()Ljava/lang/String;", "GetGetCpIDHandler")]
			get {
				const string __id = "getCpID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='setCpID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCpID", "(Ljava/lang/String;)V", "GetSetCpID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCpID.(Ljava/lang/String;)V";
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

		static Delegate cb_getHmsSdkVersionName;
#pragma warning disable 0169
		static Delegate GetGetHmsSdkVersionNameHandler ()
		{
			if (cb_getHmsSdkVersionName == null)
				cb_getHmsSdkVersionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHmsSdkVersionName);
			return cb_getHmsSdkVersionName;
		}

		static IntPtr n_GetHmsSdkVersionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HmsSdkVersionName);
		}
#pragma warning restore 0169

		static Delegate cb_setHmsSdkVersionName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHmsSdkVersionName_Ljava_lang_String_Handler ()
		{
			if (cb_setHmsSdkVersionName_Ljava_lang_String_ == null)
				cb_setHmsSdkVersionName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHmsSdkVersionName_Ljava_lang_String_);
			return cb_setHmsSdkVersionName_Ljava_lang_String_;
		}

		static void n_SetHmsSdkVersionName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HmsSdkVersionName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HmsSdkVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='getHmsSdkVersionName' and count(parameter)=0]"
			[Register ("getHmsSdkVersionName", "()Ljava/lang/String;", "GetGetHmsSdkVersionNameHandler")]
			get {
				const string __id = "getHmsSdkVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosBaseReq']/method[@name='setHmsSdkVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHmsSdkVersionName", "(Ljava/lang/String;)V", "GetSetHmsSdkVersionName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHmsSdkVersionName.(Ljava/lang/String;)V";
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
