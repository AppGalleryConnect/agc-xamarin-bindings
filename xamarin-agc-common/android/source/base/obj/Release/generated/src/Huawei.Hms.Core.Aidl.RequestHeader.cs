using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Core.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']"
	[global::Android.Runtime.Register ("com/huawei/hms/core/aidl/RequestHeader", DoNotGenerateAcw=true)]
	public partial class RequestHeader : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/core/aidl/RequestHeader", typeof (RequestHeader));
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

		protected RequestHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/constructor[@name='RequestHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestHeader ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/constructor[@name='RequestHeader' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe RequestHeader (string p0, string p1, int p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiNameList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiNameList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='getApiNameList' and count(parameter)=0]"
			[Register ("getApiNameList", "()Ljava/util/List;", "GetGetApiNameListHandler")]
			get {
				const string __id = "getApiNameList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setApiNameList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
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

		static Delegate cb_getAppID;
#pragma warning disable 0169
		static Delegate GetGetAppIDHandler ()
		{
			if (cb_getAppID == null)
				cb_getAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppID);
			return cb_getAppID;
		}

		static IntPtr n_GetAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		static Delegate cb_setAppID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppID_Ljava_lang_String_Handler ()
		{
			if (cb_setAppID_Ljava_lang_String_ == null)
				cb_setAppID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppID_Ljava_lang_String_);
			return cb_setAppID_Ljava_lang_String_;
		}

		static void n_SetAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppID", "(Ljava/lang/String;)V", "GetSetAppID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppID.(Ljava/lang/String;)V";
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

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setPackageName_Ljava_lang_String_ == null)
				cb_setPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackageName_Ljava_lang_String_);
			return cb_setPackageName_Ljava_lang_String_;
		}

		static void n_SetPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPackageName", "(Ljava/lang/String;)V", "GetSetPackageName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPackageName.(Ljava/lang/String;)V";
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

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static int n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SdkVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setSdkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetSdkVersion_IHandler ()
		{
			if (cb_setSdkVersion_I == null)
				cb_setSdkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSdkVersion_I);
			return cb_setSdkVersion_I;
		}

		static void n_SetSdkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SdkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()I", "GetGetSdkVersionHandler")]
			get {
				const string __id = "getSdkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setSdkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSdkVersion", "(I)V", "GetSetSdkVersion_IHandler")]
			set {
				const string __id = "setSdkVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionId_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionId_Ljava_lang_String_ == null)
				cb_setSessionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSessionId_Ljava_lang_String_);
			return cb_setSessionId_Ljava_lang_String_;
		}

		static void n_SetSessionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionId", "(Ljava/lang/String;)V", "GetSetSessionId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSessionId.(Ljava/lang/String;)V";
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

		static Delegate cb_setApiLevel_I;
#pragma warning disable 0169
		static Delegate GetSetApiLevel_IHandler ()
		{
			if (cb_setApiLevel_I == null)
				cb_setApiLevel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetApiLevel_I);
			return cb_setApiLevel_I;
		}

		static void n_SetApiLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Core.Aidl.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetApiLevel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.core.aidl']/class[@name='RequestHeader']/method[@name='setApiLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setApiLevel", "(I)V", "GetSetApiLevel_IHandler")]
		public virtual unsafe void SetApiLevel (int p0)
		{
			const string __id = "setApiLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
