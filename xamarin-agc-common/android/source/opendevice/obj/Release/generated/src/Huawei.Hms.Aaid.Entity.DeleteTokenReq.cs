using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/entity/DeleteTokenReq", DoNotGenerateAcw=true)]
	public partial class DeleteTokenReq : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/field[@name='isFastApp']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/field[@name='isMultiSender']"
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
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/entity/DeleteTokenReq", typeof (DeleteTokenReq));
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

		protected DeleteTokenReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/constructor[@name='DeleteTokenReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeleteTokenReq ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				const string __id = "getAppId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getDeleteType;
#pragma warning disable 0169
		static Delegate GetGetDeleteTypeHandler ()
		{
			if (cb_getDeleteType == null)
				cb_getDeleteType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDeleteType);
			return cb_getDeleteType;
		}

		static int n_GetDeleteType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeleteType;
		}
#pragma warning restore 0169

		static Delegate cb_setDeleteType_I;
#pragma warning disable 0169
		static Delegate GetSetDeleteType_IHandler ()
		{
			if (cb_setDeleteType_I == null)
				cb_setDeleteType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDeleteType_I);
			return cb_setDeleteType_I;
		}

		static void n_SetDeleteType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int DeleteType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getDeleteType' and count(parameter)=0]"
			[Register ("getDeleteType", "()I", "GetGetDeleteTypeHandler")]
			get {
				const string __id = "getDeleteType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setDeleteType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDeleteType", "(I)V", "GetSetDeleteType_IHandler")]
			set {
				const string __id = "setDeleteType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FastApp = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool FastApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='isFastApp' and count(parameter)=0]"
			[Register ("isFastApp", "()Z", "GetIsFastAppHandler")]
			get {
				const string __id = "isFastApp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setFastApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MultiSender = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool MultiSender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='isMultiSender' and count(parameter)=0]"
			[Register ("isMultiSender", "()Z", "GetIsMultiSenderHandler")]
			get {
				const string __id = "isMultiSender.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setMultiSender' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PkgName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getPkgName' and count(parameter)=0]"
			[Register ("getPkgName", "()Ljava/lang/String;", "GetGetPkgNameHandler")]
			get {
				const string __id = "getPkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProjectId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getProjectId' and count(parameter)=0]"
			[Register ("getProjectId", "()Ljava/lang/String;", "GetGetProjectIdHandler")]
			get {
				const string __id = "getProjectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setProjectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Scope = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubjectId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SubjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getSubjectId' and count(parameter)=0]"
			[Register ("getSubjectId", "()Ljava/lang/String;", "GetGetSubjectIdHandler")]
			get {
				const string __id = "getSubjectId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setSubjectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenReq']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setToken.(Ljava/lang/String;)V";
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
