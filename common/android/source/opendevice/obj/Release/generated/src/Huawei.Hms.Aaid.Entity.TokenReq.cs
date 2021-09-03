using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/entity/TokenReq", DoNotGenerateAcw=true)]
	public partial class TokenReq : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/field[@name='isFastApp']"
		[Register ("isFastApp")]
		public bool IsFastApp {
			get {
				const string __id = "isFastApp.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isFastApp.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/field[@name='isMultiSender']"
		[Register ("isMultiSender")]
		public bool IsMultiSender {
			get {
				const string __id = "isMultiSender.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isMultiSender.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/entity/TokenReq", typeof (TokenReq));
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

		protected TokenReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/constructor[@name='TokenReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenReq ()
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

		static Delegate cb_getAaid;
#pragma warning disable 0169
		static Delegate GetGetAaidHandler ()
		{
			if (cb_getAaid == null)
				cb_getAaid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAaid);
			return cb_getAaid;
		}

		static IntPtr n_GetAaid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Aaid);
		}
#pragma warning restore 0169

		static Delegate cb_setAaid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAaid_Ljava_lang_String_Handler ()
		{
			if (cb_setAaid_Ljava_lang_String_ == null)
				cb_setAaid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAaid_Ljava_lang_String_);
			return cb_setAaid_Ljava_lang_String_;
		}

		static void n_SetAaid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Aaid = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Aaid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getAaid' and count(parameter)=0]"
			[Register ("getAaid", "()Ljava/lang/String;", "GetGetAaidHandler")]
			get {
				const string __id = "getAaid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setAaid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAaid", "(Ljava/lang/String;)V", "GetSetAaid_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAaid.(Ljava/lang/String;)V";
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

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				const string __id = "getAppId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppId.(Ljava/lang/String;)V";
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

		static Delegate cb_isFastApp;
#pragma warning disable 0169
		static Delegate GetIsFastAppHandler ()
		{
			if (cb_isFastApp == null)
				cb_isFastApp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFastApp);
			return cb_isFastApp;
		}

		static bool n_IsFastApp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FastApp;
		}
#pragma warning restore 0169

		static Delegate cb_setFastApp_Z;
#pragma warning disable 0169
		static Delegate GetSetFastApp_ZHandler ()
		{
			if (cb_setFastApp_Z == null)
				cb_setFastApp_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFastApp_Z);
			return cb_setFastApp_Z;
		}

		static void n_SetFastApp_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FastApp = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool FastApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='isFastApp' and count(parameter)=0]"
			[Register ("isFastApp", "()Z", "GetIsFastAppHandler")]
			get {
				const string __id = "isFastApp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setFastApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFastApp", "(Z)V", "GetSetFastApp_ZHandler")]
			set {
				const string __id = "setFastApp.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFirstTime;
#pragma warning disable 0169
		static Delegate GetIsFirstTimeHandler ()
		{
			if (cb_isFirstTime == null)
				cb_isFirstTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFirstTime);
			return cb_isFirstTime;
		}

		static bool n_IsFirstTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstTime;
		}
#pragma warning restore 0169

		static Delegate cb_setFirstTime_Z;
#pragma warning disable 0169
		static Delegate GetSetFirstTime_ZHandler ()
		{
			if (cb_setFirstTime_Z == null)
				cb_setFirstTime_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFirstTime_Z);
			return cb_setFirstTime_Z;
		}

		static void n_SetFirstTime_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FirstTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool FirstTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='isFirstTime' and count(parameter)=0]"
			[Register ("isFirstTime", "()Z", "GetIsFirstTimeHandler")]
			get {
				const string __id = "isFirstTime.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setFirstTime' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFirstTime", "(Z)V", "GetSetFirstTime_ZHandler")]
			set {
				const string __id = "setFirstTime.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMultiSender;
#pragma warning disable 0169
		static Delegate GetIsMultiSenderHandler ()
		{
			if (cb_isMultiSender == null)
				cb_isMultiSender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMultiSender);
			return cb_isMultiSender;
		}

		static bool n_IsMultiSender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiSender;
		}
#pragma warning restore 0169

		static Delegate cb_setMultiSender_Z;
#pragma warning disable 0169
		static Delegate GetSetMultiSender_ZHandler ()
		{
			if (cb_setMultiSender_Z == null)
				cb_setMultiSender_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMultiSender_Z);
			return cb_setMultiSender_Z;
		}

		static void n_SetMultiSender_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultiSender = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool MultiSender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='isMultiSender' and count(parameter)=0]"
			[Register ("isMultiSender", "()Z", "GetIsMultiSenderHandler")]
			get {
				const string __id = "isMultiSender.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setMultiSender' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMultiSender", "(Z)V", "GetSetMultiSender_ZHandler")]
			set {
				const string __id = "setMultiSender.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getProjectId;
#pragma warning disable 0169
		static Delegate GetGetProjectIdHandler ()
		{
			if (cb_getProjectId == null)
				cb_getProjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProjectId);
			return cb_getProjectId;
		}

		static IntPtr n_GetProjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProjectId);
		}
#pragma warning restore 0169

		static Delegate cb_setProjectId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProjectId_Ljava_lang_String_Handler ()
		{
			if (cb_setProjectId_Ljava_lang_String_ == null)
				cb_setProjectId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProjectId_Ljava_lang_String_);
			return cb_setProjectId_Ljava_lang_String_;
		}

		static void n_SetProjectId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProjectId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getProjectId' and count(parameter)=0]"
			[Register ("getProjectId", "()Ljava/lang/String;", "GetGetProjectIdHandler")]
			get {
				const string __id = "getProjectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setProjectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProjectId", "(Ljava/lang/String;)V", "GetSetProjectId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProjectId.(Ljava/lang/String;)V";
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

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static Delegate cb_setScope_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScope_Ljava_lang_String_Handler ()
		{
			if (cb_setScope_Ljava_lang_String_ == null)
				cb_setScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetScope_Ljava_lang_String_);
			return cb_setScope_Ljava_lang_String_;
		}

		static void n_SetScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scope = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScope", "(Ljava/lang/String;)V", "GetSetScope_Ljava_lang_String_Handler")]
			set {
				const string __id = "setScope.(Ljava/lang/String;)V";
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

		static Delegate cb_getSubjectId;
#pragma warning disable 0169
		static Delegate GetGetSubjectIdHandler ()
		{
			if (cb_getSubjectId == null)
				cb_getSubjectId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubjectId);
			return cb_getSubjectId;
		}

		static IntPtr n_GetSubjectId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubjectId);
		}
#pragma warning restore 0169

		static Delegate cb_setSubjectId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubjectId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubjectId_Ljava_lang_String_ == null)
				cb_setSubjectId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubjectId_Ljava_lang_String_);
			return cb_setSubjectId_Ljava_lang_String_;
		}

		static void n_SetSubjectId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.TokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubjectId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='getSubjectId' and count(parameter)=0]"
			[Register ("getSubjectId", "()Ljava/lang/String;", "GetGetSubjectIdHandler")]
			get {
				const string __id = "getSubjectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='TokenReq']/method[@name='setSubjectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubjectId", "(Ljava/lang/String;)V", "GetSetSubjectId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSubjectId.(Ljava/lang/String;)V";
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
