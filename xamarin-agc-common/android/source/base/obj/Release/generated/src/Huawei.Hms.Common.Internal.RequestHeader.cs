using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/RequestHeader", DoNotGenerateAcw=true)]
	public partial class RequestHeader : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/RequestHeader", typeof (RequestHeader));
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/constructor[@name='RequestHeader' and count(parameter)=0]"
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

		static Delegate cb_getActualAppID;
#pragma warning disable 0169
		static Delegate GetGetActualAppIDHandler ()
		{
			if (cb_getActualAppID == null)
				cb_getActualAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActualAppID);
			return cb_getActualAppID;
		}

		static IntPtr n_GetActualAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActualAppID);
		}
#pragma warning restore 0169

		public virtual unsafe string ActualAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getActualAppID' and count(parameter)=0]"
			[Register ("getActualAppID", "()Ljava/lang/String;", "GetGetActualAppIDHandler")]
			get {
				const string __id = "getActualAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApiLevel;
#pragma warning disable 0169
		static Delegate GetGetApiLevelHandler ()
		{
			if (cb_getApiLevel == null)
				cb_getApiLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetApiLevel);
			return cb_getApiLevel;
		}

		static int n_GetApiLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApiLevel;
		}
#pragma warning restore 0169

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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApiLevel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getApiLevel' and count(parameter)=0]"
			[Register ("getApiLevel", "()I", "GetGetApiLevelHandler")]
			get {
				const string __id = "getApiLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setApiLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setApiLevel", "(I)V", "GetSetApiLevel_IHandler")]
			set {
				const string __id = "setApiLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getApiName;
#pragma warning disable 0169
		static Delegate GetGetApiNameHandler ()
		{
			if (cb_getApiName == null)
				cb_getApiName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiName);
			return cb_getApiName;
		}

		static IntPtr n_GetApiName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiName);
		}
#pragma warning restore 0169

		static Delegate cb_setApiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiName_Ljava_lang_String_Handler ()
		{
			if (cb_setApiName_Ljava_lang_String_ == null)
				cb_setApiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetApiName_Ljava_lang_String_);
			return cb_setApiName_Ljava_lang_String_;
		}

		static void n_SetApiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ApiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getApiName' and count(parameter)=0]"
			[Register ("getApiName", "()Ljava/lang/String;", "GetGetApiNameHandler")]
			get {
				const string __id = "getApiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setApiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApiName", "(Ljava/lang/String;)V", "GetSetApiName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setApiName.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getKitSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetKitSdkVersionHandler ()
		{
			if (cb_getKitSdkVersion == null)
				cb_getKitSdkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetKitSdkVersion);
			return cb_getKitSdkVersion;
		}

		static int n_GetKitSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KitSdkVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setKitSdkVersion_I;
#pragma warning disable 0169
		static Delegate GetSetKitSdkVersion_IHandler ()
		{
			if (cb_setKitSdkVersion_I == null)
				cb_setKitSdkVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetKitSdkVersion_I);
			return cb_setKitSdkVersion_I;
		}

		static void n_SetKitSdkVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KitSdkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int KitSdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getKitSdkVersion' and count(parameter)=0]"
			[Register ("getKitSdkVersion", "()I", "GetGetKitSdkVersionHandler")]
			get {
				const string __id = "getKitSdkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setKitSdkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setKitSdkVersion", "(I)V", "GetSetKitSdkVersion_IHandler")]
			set {
				const string __id = "setKitSdkVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParcelable;
#pragma warning disable 0169
		static Delegate GetGetParcelableHandler ()
		{
			if (cb_getParcelable == null)
				cb_getParcelable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParcelable);
			return cb_getParcelable;
		}

		static IntPtr n_GetParcelable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parcelable);
		}
#pragma warning restore 0169

		static Delegate cb_setParcelable_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetSetParcelable_Landroid_os_Parcelable_Handler ()
		{
			if (cb_setParcelable_Landroid_os_Parcelable_ == null)
				cb_setParcelable_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetParcelable_Landroid_os_Parcelable_);
			return cb_setParcelable_Landroid_os_Parcelable_;
		}

		static void n_SetParcelable_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parcelable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.IParcelable Parcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getParcelable' and count(parameter)=0]"
			[Register ("getParcelable", "()Landroid/os/Parcelable;", "GetGetParcelableHandler")]
			get {
				const string __id = "getParcelable.()Landroid/os/Parcelable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setParcelable' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
			[Register ("setParcelable", "(Landroid/os/Parcelable;)V", "GetSetParcelable_Landroid_os_Parcelable_Handler")]
			set {
				const string __id = "setParcelable.(Landroid/os/Parcelable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPkgName;
#pragma warning disable 0169
		static Delegate GetGetPkgNameHandler ()
		{
			if (cb_getPkgName == null)
				cb_getPkgName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPkgName);
			return cb_getPkgName;
		}

		static IntPtr n_GetPkgName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PkgName);
		}
#pragma warning restore 0169

		static Delegate cb_setPkgName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPkgName_Ljava_lang_String_Handler ()
		{
			if (cb_setPkgName_Ljava_lang_String_ == null)
				cb_setPkgName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPkgName_Ljava_lang_String_);
			return cb_setPkgName_Ljava_lang_String_;
		}

		static void n_SetPkgName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PkgName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getPkgName' and count(parameter)=0]"
			[Register ("getPkgName", "()Ljava/lang/String;", "GetGetPkgNameHandler")]
			get {
				const string __id = "getPkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPkgName", "(Ljava/lang/String;)V", "GetSetPkgName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPkgName.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SdkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()I", "GetGetSdkVersionHandler")]
			get {
				const string __id = "getSdkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setSdkVersion' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSrvName;
#pragma warning disable 0169
		static Delegate GetGetSrvNameHandler ()
		{
			if (cb_getSrvName == null)
				cb_getSrvName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSrvName);
			return cb_getSrvName;
		}

		static IntPtr n_GetSrvName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SrvName);
		}
#pragma warning restore 0169

		static Delegate cb_setSrvName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSrvName_Ljava_lang_String_Handler ()
		{
			if (cb_setSrvName_Ljava_lang_String_ == null)
				cb_setSrvName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSrvName_Ljava_lang_String_);
			return cb_setSrvName_Ljava_lang_String_;
		}

		static void n_SetSrvName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SrvName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SrvName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getSrvName' and count(parameter)=0]"
			[Register ("getSrvName", "()Ljava/lang/String;", "GetGetSrvNameHandler")]
			get {
				const string __id = "getSrvName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setSrvName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSrvName", "(Ljava/lang/String;)V", "GetSetSrvName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSrvName.(Ljava/lang/String;)V";
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

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				const string __id = "getTransactionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTransactionId.(Ljava/lang/String;)V";
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

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVersion.(Ljava/lang/String;)V";
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

		static Delegate cb_fromJson_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromJson_Ljava_lang_String_Handler ()
		{
			if (cb_fromJson_Ljava_lang_String_ == null)
				cb_fromJson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_FromJson_Ljava_lang_String_);
			return cb_fromJson_Ljava_lang_String_;
		}

		static bool n_FromJson_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.FromJson (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Z", "GetFromJson_Ljava_lang_String_Handler")]
		public virtual unsafe bool FromJson (string p0)
		{
			const string __id = "fromJson.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='RequestHeader']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler")]
		public virtual unsafe string ToJson ()
		{
			const string __id = "toJson.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
