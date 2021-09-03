using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/ConnectInfo", DoNotGenerateAcw=true)]
	public partial class ConnectInfo : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/ConnectInfo", typeof (ConnectInfo));
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

		protected ConnectInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/constructor[@name='ConnectInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectInfo ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/constructor[@name='ConnectInfo' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ConnectInfo (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getApiNameList;
#pragma warning disable 0169
		static Delegate GetGetApiNameListHandler ()
		{
			if (cb_getApiNameList == null)
				cb_getApiNameList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiNameList);
			return cb_getApiNameList;
		}

		static IntPtr n_GetApiNameList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ApiNameList);
		}
#pragma warning restore 0169

		static Delegate cb_setApiNameList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetApiNameList_Ljava_util_List_Handler ()
		{
			if (cb_setApiNameList_Ljava_util_List_ == null)
				cb_setApiNameList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetApiNameList_Ljava_util_List_);
			return cb_setApiNameList_Ljava_util_List_;
		}

		static void n_SetApiNameList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiNameList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiNameList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='getApiNameList' and count(parameter)=0]"
			[Register ("getApiNameList", "()Ljava/util/List;", "GetGetApiNameListHandler")]
			get {
				const string __id = "getApiNameList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='setApiNameList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setApiNameList", "(Ljava/util/List;)V", "GetSetApiNameList_Ljava_util_List_Handler")]
			set {
				const string __id = "setApiNameList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getFingerprint;
#pragma warning disable 0169
		static Delegate GetGetFingerprintHandler ()
		{
			if (cb_getFingerprint == null)
				cb_getFingerprint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFingerprint);
			return cb_getFingerprint;
		}

		static IntPtr n_GetFingerprint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Fingerprint);
		}
#pragma warning restore 0169

		static Delegate cb_setFingerprint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFingerprint_Ljava_lang_String_Handler ()
		{
			if (cb_setFingerprint_Ljava_lang_String_ == null)
				cb_setFingerprint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFingerprint_Ljava_lang_String_);
			return cb_setFingerprint_Ljava_lang_String_;
		}

		static void n_SetFingerprint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Fingerprint = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Fingerprint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='getFingerprint' and count(parameter)=0]"
			[Register ("getFingerprint", "()Ljava/lang/String;", "GetGetFingerprintHandler")]
			get {
				const string __id = "getFingerprint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='setFingerprint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFingerprint", "(Ljava/lang/String;)V", "GetSetFingerprint_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFingerprint.(Ljava/lang/String;)V";
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

		static Delegate cb_getScopeList;
#pragma warning disable 0169
		static Delegate GetGetScopeListHandler ()
		{
			if (cb_getScopeList == null)
				cb_getScopeList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopeList);
			return cb_getScopeList;
		}

		static IntPtr n_GetScopeList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.ScopeList);
		}
#pragma warning restore 0169

		static Delegate cb_setScopeList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetScopeList_Ljava_util_List_Handler ()
		{
			if (cb_setScopeList_Ljava_util_List_ == null)
				cb_setScopeList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScopeList_Ljava_util_List_);
			return cb_setScopeList_Ljava_util_List_;
		}

		static void n_SetScopeList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScopeList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> ScopeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='getScopeList' and count(parameter)=0]"
			[Register ("getScopeList", "()Ljava/util/List;", "GetGetScopeListHandler")]
			get {
				const string __id = "getScopeList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='setScopeList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;']]"
			[Register ("setScopeList", "(Ljava/util/List;)V", "GetSetScopeList_Ljava_util_List_Handler")]
			set {
				const string __id = "setScopeList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.ConnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubAppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='getSubAppID' and count(parameter)=0]"
			[Register ("getSubAppID", "()Ljava/lang/String;", "GetGetSubAppIDHandler")]
			get {
				const string __id = "getSubAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='ConnectInfo']/method[@name='setSubAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
