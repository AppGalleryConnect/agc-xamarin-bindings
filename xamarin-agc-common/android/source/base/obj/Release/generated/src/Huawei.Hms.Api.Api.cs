using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/Api", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"O extends com.huawei.hms.api.Api.ApiOptions"})]
	public partial class Api : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/field[@name='mConnetctPostList']"
		[Register ("mConnetctPostList")]
		public global::System.Collections.IList MConnetctPostList {
			get {
				const string __id = "mConnetctPostList.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConnetctPostList.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='Api.ApiOptions.HasOptions']"
		[Register ("com/huawei/hms/api/Api$ApiOptions$HasOptions", "", "Huawei.Hms.Api.Api/IApiOptionsHasOptionsInvoker")]
		public partial interface IApiOptionsHasOptions : global::Huawei.Hms.Api.Api.IApiOptions {

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$ApiOptions$HasOptions", DoNotGenerateAcw=true)]
		internal partial class IApiOptionsHasOptionsInvoker : global::Java.Lang.Object, IApiOptionsHasOptions {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$ApiOptions$HasOptions", typeof (IApiOptionsHasOptionsInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IApiOptionsHasOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IApiOptionsHasOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.Api.ApiOptions.HasOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IApiOptionsHasOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.ApiOptions.NoOptions']"
		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$ApiOptions$NoOptions", DoNotGenerateAcw=true)]
		public sealed partial class ApiOptionsNoOptions : global::Java.Lang.Object, global::Huawei.Hms.Api.Api.IApiOptionsNotRequiredOptions {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$ApiOptions$NoOptions", typeof (ApiOptionsNoOptions));
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

			internal ApiOptionsNoOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.ApiOptions.NoOptions']/constructor[@name='Api.ApiOptions.NoOptions' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ApiOptionsNoOptions ()
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='Api.ApiOptions.NotRequiredOptions']"
		[Register ("com/huawei/hms/api/Api$ApiOptions$NotRequiredOptions", "", "Huawei.Hms.Api.Api/IApiOptionsNotRequiredOptionsInvoker")]
		public partial interface IApiOptionsNotRequiredOptions : global::Huawei.Hms.Api.Api.IApiOptions {

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$ApiOptions$NotRequiredOptions", DoNotGenerateAcw=true)]
		internal partial class IApiOptionsNotRequiredOptionsInvoker : global::Java.Lang.Object, IApiOptionsNotRequiredOptions {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$ApiOptions$NotRequiredOptions", typeof (IApiOptionsNotRequiredOptionsInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IApiOptionsNotRequiredOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IApiOptionsNotRequiredOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.Api.ApiOptions.NotRequiredOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IApiOptionsNotRequiredOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='Api.ApiOptions.Optional']"
		[Register ("com/huawei/hms/api/Api$ApiOptions$Optional", "", "Huawei.Hms.Api.Api/IApiOptionsOptionalInvoker")]
		public partial interface IApiOptionsOptional : global::Huawei.Hms.Api.Api.IApiOptionsHasOptions, global::Huawei.Hms.Api.Api.IApiOptionsNotRequiredOptions {

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$ApiOptions$Optional", DoNotGenerateAcw=true)]
		internal partial class IApiOptionsOptionalInvoker : global::Java.Lang.Object, IApiOptionsOptional {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$ApiOptions$Optional", typeof (IApiOptionsOptionalInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IApiOptionsOptional GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IApiOptionsOptional> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.Api.ApiOptions.Optional"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IApiOptionsOptionalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='Api.ApiOptions']"
		[Register ("com/huawei/hms/api/Api$ApiOptions", "", "Huawei.Hms.Api.Api/IApiOptionsInvoker")]
		public partial interface IApiOptions : IJavaObject, IJavaPeerable {

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$ApiOptions", DoNotGenerateAcw=true)]
		internal partial class IApiOptionsInvoker : global::Java.Lang.Object, IApiOptions {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$ApiOptions", typeof (IApiOptionsInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IApiOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IApiOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.Api.ApiOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IApiOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.Options']"
		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$Options", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"O"})]
		public abstract partial class Options : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$Options", typeof (Options));
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

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.Options']/constructor[@name='Api.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options ()
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

			static Delegate cb_getPermissionInfoList_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetPermissionInfoList_Ljava_lang_Object_Handler ()
			{
				if (cb_getPermissionInfoList_Ljava_lang_Object_ == null)
					cb_getPermissionInfoList_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPermissionInfoList_Ljava_lang_Object_);
				return cb_getPermissionInfoList_Ljava_lang_Object_;
			}

			static IntPtr n_GetPermissionInfoList_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.ToLocalJniHandle (__this.GetPermissionInfoList (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.Options']/method[@name='getPermissionInfoList' and count(parameter)=1 and parameter[1][@type='O']]"
			[Register ("getPermissionInfoList", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetPermissionInfoList_Ljava_lang_Object_Handler")]
			public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo> GetPermissionInfoList (global::Java.Lang.Object p0)
			{
				const string __id = "getPermissionInfoList.(Ljava/lang/Object;)Ljava/util/List;";
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate cb_getScopeList_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetScopeList_Ljava_lang_Object_Handler ()
			{
				if (cb_getScopeList_Ljava_lang_Object_ == null)
					cb_getScopeList_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetScopeList_Ljava_lang_Object_);
				return cb_getScopeList_Ljava_lang_Object_;
			}

			static IntPtr n_GetScopeList_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.GetScopeList (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api.Options']/method[@name='getScopeList' and count(parameter)=1 and parameter[1][@type='O']]"
			[Register ("getScopeList", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetScopeList_Ljava_lang_Object_Handler")]
			public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> GetScopeList (global::Java.Lang.Object p0)
			{
				const string __id = "getScopeList.(Ljava/lang/Object;)Ljava/util/List;";
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/Api$Options", DoNotGenerateAcw=true)]
		internal partial class OptionsInvoker : Options {

			public OptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api$Options", typeof (OptionsInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/Api", typeof (Api));
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

		protected Api (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/constructor[@name='Api' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Api (string p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/constructor[@name='Api' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.api.Api.Options&lt;O&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/huawei/hms/api/Api$Options;)V", "")]
		public unsafe Api (string p0, global::Huawei.Hms.Api.Api.Options p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/huawei/hms/api/Api$Options;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiName);
		}
#pragma warning restore 0169

		public virtual unsafe string ApiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/method[@name='getApiName' and count(parameter)=0]"
			[Register ("getApiName", "()Ljava/lang/String;", "GetGetApiNameHandler")]
			get {
				const string __id = "getApiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptions);
			return cb_getOptions;
		}

		static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOptions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/method[@name='getOptions' and count(parameter)=0]"
		[Register ("getOptions", "()Lcom/huawei/hms/api/Api$Options;", "GetGetOptionsHandler")]
		public virtual unsafe global::Huawei.Hms.Api.Api.Options GetOptions ()
		{
			const string __id = "getOptions.()Lcom/huawei/hms/api/Api$Options;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getmConnetctPostList;
#pragma warning disable 0169
		static Delegate GetGetmConnetctPostListHandler ()
		{
			if (cb_getmConnetctPostList == null)
				cb_getmConnetctPostList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetmConnetctPostList);
			return cb_getmConnetctPostList;
		}

		static IntPtr n_GetmConnetctPostList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor>.ToLocalJniHandle (__this.GetmConnetctPostList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/method[@name='getmConnetctPostList' and count(parameter)=0]"
		[Register ("getmConnetctPostList", "()Ljava/util/List;", "GetGetmConnetctPostListHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor> GetmConnetctPostList ()
		{
			const string __id = "getmConnetctPostList.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setmConnetctPostList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetmConnetctPostList_Ljava_util_List_Handler ()
		{
			if (cb_setmConnetctPostList_Ljava_util_List_ == null)
				cb_setmConnetctPostList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetmConnetctPostList_Ljava_util_List_);
			return cb_setmConnetctPostList_Ljava_util_List_;
		}

		static void n_SetmConnetctPostList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetmConnetctPostList (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='Api']/method[@name='setmConnetctPostList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.huawei.hms.common.api.ConnectionPostProcessor&gt;']]"
		[Register ("setmConnetctPostList", "(Ljava/util/List;)V", "GetSetmConnetctPostList_Ljava_util_List_Handler")]
		public virtual unsafe void SetmConnetctPostList (global::System.Collections.Generic.IList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor> p0)
		{
			const string __id = "setmConnetctPostList.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Common.Api.IConnectionPostProcessor>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
