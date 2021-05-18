using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/TaskApiCall", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"ClientT extends com.huawei.hms.common.internal.AnyClient", "ResultT"})]
	public abstract partial class TaskApiCall : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/TaskApiCall", typeof (TaskApiCall));
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

		protected TaskApiCall (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/constructor[@name='TaskApiCall' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TaskApiCall (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/constructor[@name='TaskApiCall' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TaskApiCall (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/constructor[@name='TaskApiCall' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe TaskApiCall (string p0, string p1, string p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApiLevel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getApiLevel' and count(parameter)=0]"
			[Register ("getApiLevel", "()I", "GetGetApiLevelHandler")]
			get {
				const string __id = "getApiLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='setApiLevel' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getMinApkVersion;
#pragma warning disable 0169
		static Delegate GetGetMinApkVersionHandler ()
		{
			if (cb_getMinApkVersion == null)
				cb_getMinApkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinApkVersion);
			return cb_getMinApkVersion;
		}

		static int n_GetMinApkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinApkVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int MinApkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getMinApkVersion' and count(parameter)=0]"
			[Register ("getMinApkVersion", "()I", "GetGetMinApkVersionHandler")]
			get {
				const string __id = "getMinApkVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parcelable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.IParcelable Parcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getParcelable' and count(parameter)=0]"
			[Register ("getParcelable", "()Landroid/os/Parcelable;", "GetGetParcelableHandler")]
			get {
				const string __id = "getParcelable.()Landroid/os/Parcelable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='setParcelable' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
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

		static Delegate cb_getRequestJson;
#pragma warning disable 0169
		static Delegate GetGetRequestJsonHandler ()
		{
			if (cb_getRequestJson == null)
				cb_getRequestJson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestJson);
			return cb_getRequestJson;
		}

		static IntPtr n_GetRequestJson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestJson);
		}
#pragma warning restore 0169

		public virtual unsafe string RequestJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getRequestJson' and count(parameter)=0]"
			[Register ("getRequestJson", "()Ljava/lang/String;", "GetGetRequestJsonHandler")]
			get {
				const string __id = "getRequestJson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Lcom_huawei_hmf_tasks_CancellationToken_;
#pragma warning disable 0169
		static Delegate GetSetToken_Lcom_huawei_hmf_tasks_CancellationToken_Handler ()
		{
			if (cb_setToken_Lcom_huawei_hmf_tasks_CancellationToken_ == null)
				cb_setToken_Lcom_huawei_hmf_tasks_CancellationToken_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetToken_Lcom_huawei_hmf_tasks_CancellationToken_);
			return cb_setToken_Lcom_huawei_hmf_tasks_CancellationToken_;
		}

		static void n_SetToken_Lcom_huawei_hmf_tasks_CancellationToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.CancellationToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.CancellationToken Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Lcom/huawei/hmf/tasks/CancellationToken;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Lcom/huawei/hmf/tasks/CancellationToken;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.CancellationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.CancellationToken']]"
			[Register ("setToken", "(Lcom/huawei/hmf/tasks/CancellationToken;)V", "GetSetToken_Lcom_huawei_hmf_tasks_CancellationToken_Handler")]
			set {
				const string __id = "setToken.(Lcom/huawei/hmf/tasks/CancellationToken;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				const string __id = "getTransactionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.TaskApiCall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uri);
		}
#pragma warning restore 0169

		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				const string __id = "getUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='TaskApiCall']/method[@name='onResponse' and count(parameter)=4 and parameter[1][@type='ClientT'] and parameter[2][@type='com.huawei.hms.common.internal.ResponseErrorCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;ResultT&gt;']]"
		[Register ("onResponse", "(Lcom/huawei/hms/common/internal/AnyClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "")]
		public unsafe void OnResponse (global::Java.Lang.Object p0, global::Huawei.Hms.Common.Internal.IResponseErrorCode p1, string p2, global::Huawei.Hmf.Tasks.TaskCompletionSource p3)
		{
			const string __id = "onResponse.(Lcom/huawei/hms/common/internal/AnyClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/TaskApiCall", DoNotGenerateAcw=true)]
	internal partial class TaskApiCallInvoker : TaskApiCall {

		public TaskApiCallInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/TaskApiCall", typeof (TaskApiCallInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
