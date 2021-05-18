using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ResponseHeader", DoNotGenerateAcw=true)]
	public partial class ResponseHeader : global::Java.Lang.Object, global::Huawei.Hms.Common.Internal.IResponseErrorCode, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ResponseHeader", typeof (ResponseHeader));
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

		protected ResponseHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/constructor[@name='ResponseHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseHeader ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/constructor[@name='ResponseHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;)V", "")]
		public unsafe ResponseHeader (int p0, int p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActualAppID);
		}
#pragma warning restore 0169

		public virtual unsafe string ActualAppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getActualAppID' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ApiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getApiName' and count(parameter)=0]"
			[Register ("getApiName", "()Ljava/lang/String;", "GetGetApiNameHandler")]
			get {
				const string __id = "getApiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setApiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_I;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_IHandler ()
		{
			if (cb_setErrorCode_I == null)
				cb_setErrorCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetErrorCode_I);
			return cb_setErrorCode_I;
		}

		static void n_SetErrorCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorCode", "(I)V", "GetSetErrorCode_IHandler")]
			set {
				const string __id = "setErrorCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorReason = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getErrorReason' and count(parameter)=0]"
			[Register ("getErrorReason", "()Ljava/lang/String;", "GetGetErrorReasonHandler")]
			get {
				const string __id = "getErrorReason.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setErrorReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parcelable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.IParcelable Parcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getParcelable' and count(parameter)=0]"
			[Register ("getParcelable", "()Landroid/os/Parcelable;", "GetGetParcelableHandler")]
			get {
				const string __id = "getParcelable.()Landroid/os/Parcelable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setParcelable' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PkgName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getPkgName' and count(parameter)=0]"
			[Register ("getPkgName", "()Ljava/lang/String;", "GetGetPkgNameHandler")]
			get {
				const string __id = "getPkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Resolution);
		}
#pragma warning restore 0169

		static Delegate cb_setResolution_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResolution_Ljava_lang_String_Handler ()
		{
			if (cb_setResolution_Ljava_lang_String_ == null)
				cb_setResolution_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResolution_Ljava_lang_String_);
			return cb_setResolution_Ljava_lang_String_;
		}

		static void n_SetResolution_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Resolution = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Ljava/lang/String;", "GetGetResolutionHandler")]
			get {
				const string __id = "getResolution.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setResolution' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResolution", "(Ljava/lang/String;)V", "GetSetResolution_Ljava_lang_String_Handler")]
			set {
				const string __id = "setResolution.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SrvName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SrvName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getSrvName' and count(parameter)=0]"
			[Register ("getSrvName", "()Ljava/lang/String;", "GetGetSrvNameHandler")]
			get {
				const string __id = "getSrvName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setSrvName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetStatusCode_IHandler ()
		{
			if (cb_setStatusCode_I == null)
				cb_setStatusCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStatusCode_I);
			return cb_setStatusCode_I;
		}

		static void n_SetStatusCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusCode", "(I)V", "GetSetStatusCode_IHandler")]
			set {
				const string __id = "setStatusCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				const string __id = "getTransactionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.FromJson (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.ResponseHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='ResponseHeader']/method[@name='toJson' and count(parameter)=0]"
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
