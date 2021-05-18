using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Uı {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']"
	[global::Android.Runtime.Register ("com/huawei/hms/ui/AbstractDialog", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDialog : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/field[@name='b']"
		[Register ("b")]
		public global::Android.App.AlertDialog B {
			get {
				const string __id = "b.Landroid/app/AlertDialog;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Landroid/app/AlertDialog;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/field[@name='c']"
		[Register ("c")]
		public global::Huawei.Hms.Uı.AbstractDialog.ICallback C {
			get {
				const string __id = "c.Lcom/huawei/hms/ui/AbstractDialog$Callback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog.ICallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/ui/AbstractDialog$Callback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.ui']/interface[@name='AbstractDialog.Callback']"
		[Register ("com/huawei/hms/ui/AbstractDialog$Callback", "", "Huawei.Hms.Uı.AbstractDialog/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/interface[@name='AbstractDialog.Callback']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.ui.AbstractDialog']]"
			[Register ("onCancel", "(Lcom/huawei/hms/ui/AbstractDialog;)V", "GetOnCancel_Lcom_huawei_hms_ui_AbstractDialog_Handler:Huawei.Hms.Uı.AbstractDialog/ICallbackInvoker, Huawei.Hms.Ui")]
			void OnCancel (global::Huawei.Hms.Uı.AbstractDialog p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/interface[@name='AbstractDialog.Callback']/method[@name='onDoWork' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.ui.AbstractDialog']]"
			[Register ("onDoWork", "(Lcom/huawei/hms/ui/AbstractDialog;)V", "GetOnDoWork_Lcom_huawei_hms_ui_AbstractDialog_Handler:Huawei.Hms.Uı.AbstractDialog/ICallbackInvoker, Huawei.Hms.Ui")]
			void OnDoWork (global::Huawei.Hms.Uı.AbstractDialog p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/ui/AbstractDialog$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/AbstractDialog$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.ui.AbstractDialog.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCancel_Lcom_huawei_hms_ui_AbstractDialog_;
#pragma warning disable 0169
			static Delegate GetOnCancel_Lcom_huawei_hms_ui_AbstractDialog_Handler ()
			{
				if (cb_onCancel_Lcom_huawei_hms_ui_AbstractDialog_ == null)
					cb_onCancel_Lcom_huawei_hms_ui_AbstractDialog_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCancel_Lcom_huawei_hms_ui_AbstractDialog_);
				return cb_onCancel_Lcom_huawei_hms_ui_AbstractDialog_;
			}

			static void n_OnCancel_Lcom_huawei_hms_ui_AbstractDialog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCancel_Lcom_huawei_hms_ui_AbstractDialog_;
			public unsafe void OnCancel (global::Huawei.Hms.Uı.AbstractDialog p0)
			{
				if (id_onCancel_Lcom_huawei_hms_ui_AbstractDialog_ == IntPtr.Zero)
					id_onCancel_Lcom_huawei_hms_ui_AbstractDialog_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Lcom/huawei/hms/ui/AbstractDialog;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Lcom_huawei_hms_ui_AbstractDialog_, __args);
			}

			static Delegate cb_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_;
#pragma warning disable 0169
			static Delegate GetOnDoWork_Lcom_huawei_hms_ui_AbstractDialog_Handler ()
			{
				if (cb_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_ == null)
					cb_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDoWork_Lcom_huawei_hms_ui_AbstractDialog_);
				return cb_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_;
			}

			static void n_OnDoWork_Lcom_huawei_hms_ui_AbstractDialog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDoWork (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_;
			public unsafe void OnDoWork (global::Huawei.Hms.Uı.AbstractDialog p0)
			{
				if (id_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_ == IntPtr.Zero)
					id_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_ = JNIEnv.GetMethodID (class_ref, "onDoWork", "(Lcom/huawei/hms/ui/AbstractDialog;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoWork_Lcom_huawei_hms_ui_AbstractDialog_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/AbstractDialog", typeof (AbstractDialog));
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

		protected AbstractDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/constructor[@name='AbstractDialog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractDialog ()
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDialogThemeId;
#pragma warning disable 0169
		static Delegate GetGetDialogThemeIdHandler ()
		{
			if (cb_getDialogThemeId == null)
				cb_getDialogThemeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDialogThemeId);
			return cb_getDialogThemeId;
		}

		static int n_GetDialogThemeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DialogThemeId;
		}
#pragma warning restore 0169

		public virtual unsafe int DialogThemeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='getDialogThemeId' and count(parameter)=0]"
			[Register ("getDialogThemeId", "()I", "GetGetDialogThemeIdHandler")]
			get {
				const string __id = "getDialogThemeId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)I", "")]
		public static unsafe int A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dismiss;
#pragma warning disable 0169
		static Delegate GetDismissHandler ()
		{
			if (cb_dismiss == null)
				cb_dismiss = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dismiss);
			return cb_dismiss;
		}

		static void n_Dismiss (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "GetDismissHandler")]
		public virtual unsafe void Dismiss ()
		{
			const string __id = "dismiss.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireCancel;
#pragma warning disable 0169
		static Delegate GetFireCancelHandler ()
		{
			if (cb_fireCancel == null)
				cb_fireCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FireCancel);
			return cb_fireCancel;
		}

		static void n_FireCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='fireCancel' and count(parameter)=0]"
		[Register ("fireCancel", "()V", "GetFireCancelHandler")]
		public virtual unsafe void FireCancel ()
		{
			const string __id = "fireCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fireDoWork;
#pragma warning disable 0169
		static Delegate GetFireDoWorkHandler ()
		{
			if (cb_fireDoWork == null)
				cb_fireDoWork = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FireDoWork);
			return cb_fireDoWork;
		}

		static void n_FireDoWork (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FireDoWork ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='fireDoWork' and count(parameter)=0]"
		[Register ("fireDoWork", "()V", "GetFireDoWorkHandler")]
		public virtual unsafe void FireDoWork ()
		{
			const string __id = "fireDoWork.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreateDialog_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnCreateDialog_Landroid_app_Activity_Handler ()
		{
			if (cb_onCreateDialog_Landroid_app_Activity_ == null)
				cb_onCreateDialog_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnCreateDialog_Landroid_app_Activity_);
			return cb_onCreateDialog_Landroid_app_Activity_;
		}

		static IntPtr n_OnCreateDialog_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateDialog (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onCreateDialog' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onCreateDialog", "(Landroid/app/Activity;)Landroid/app/AlertDialog;", "GetOnCreateDialog_Landroid_app_Activity_Handler")]
		public virtual unsafe global::Android.App.AlertDialog OnCreateDialog (global::Android.App.Activity p0)
		{
			const string __id = "onCreateDialog.(Landroid/app/Activity;)Landroid/app/AlertDialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onGetMessageString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetMessageString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetMessageString_Landroid_content_Context_ == null)
				cb_onGetMessageString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetMessageString_Landroid_content_Context_);
			return cb_onGetMessageString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetMessageString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetMessageString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetMessageString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetMessageString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetMessageString_Landroid_content_Context_Handler")]
		public abstract string OnGetMessageString (global::Android.Content.Context p0);

		static Delegate cb_onGetNegativeButtonString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetNegativeButtonString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetNegativeButtonString_Landroid_content_Context_ == null)
				cb_onGetNegativeButtonString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetNegativeButtonString_Landroid_content_Context_);
			return cb_onGetNegativeButtonString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetNegativeButtonString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetNegativeButtonString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetNegativeButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetNegativeButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetNegativeButtonString_Landroid_content_Context_Handler")]
		public abstract string OnGetNegativeButtonString (global::Android.Content.Context p0);

		static Delegate cb_onGetPositiveButtonString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetPositiveButtonString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetPositiveButtonString_Landroid_content_Context_ == null)
				cb_onGetPositiveButtonString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetPositiveButtonString_Landroid_content_Context_);
			return cb_onGetPositiveButtonString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetPositiveButtonString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetPositiveButtonString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetPositiveButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetPositiveButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetPositiveButtonString_Landroid_content_Context_Handler")]
		public abstract string OnGetPositiveButtonString (global::Android.Content.Context p0);

		static Delegate cb_onGetTitleString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetTitleString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetTitleString_Landroid_content_Context_ == null)
				cb_onGetTitleString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetTitleString_Landroid_content_Context_);
			return cb_onGetTitleString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetTitleString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetTitleString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetTitleString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetTitleString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetTitleString_Landroid_content_Context_Handler")]
		public abstract string OnGetTitleString (global::Android.Content.Context p0);

		static Delegate cb_setMessage_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setMessage_Ljava_lang_CharSequence_ == null)
				cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMessage_Ljava_lang_CharSequence_);
			return cb_setMessage_Ljava_lang_CharSequence_;
		}

		static void n_SetMessage_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setMessage", "(Ljava/lang/CharSequence;)V", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetMessage (global::Java.Lang.ICharSequence p0)
		{
			const string __id = "setMessage.(Ljava/lang/CharSequence;)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		public void SetMessage (string p0)
		{
			var jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetMessage (jls_p0);
			jls_p0?.Dispose ();
		}

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetTitle (global::Java.Lang.ICharSequence p0)
		{
			const string __id = "setTitle.(Ljava/lang/CharSequence;)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		public void SetTitle (string p0)
		{
			var jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetTitle (jls_p0);
			jls_p0?.Dispose ();
		}

		static Delegate cb_show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_Handler ()
		{
			if (cb_show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_ == null)
				cb_show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_);
			return cb_show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_;
		}

		static void n_Show_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Uı.AbstractDialog.ICallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractDialog.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.ui.AbstractDialog.Callback']]"
		[Register ("show", "(Landroid/app/Activity;Lcom/huawei/hms/ui/AbstractDialog$Callback;)V", "GetShow_Landroid_app_Activity_Lcom_huawei_hms_ui_AbstractDialog_Callback_Handler")]
		public virtual unsafe void Show (global::Android.App.Activity p0, global::Huawei.Hms.Uı.AbstractDialog.ICallback p1)
		{
			const string __id = "show.(Landroid/app/Activity;Lcom/huawei/hms/ui/AbstractDialog$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/ui/AbstractDialog", DoNotGenerateAcw=true)]
	internal partial class AbstractDialogInvoker : AbstractDialog {

		public AbstractDialogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/AbstractDialog", typeof (AbstractDialogInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetMessageString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetMessageString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetMessageString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetMessageString (global::Android.Content.Context p0)
		{
			const string __id = "onGetMessageString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetNegativeButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetNegativeButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetNegativeButtonString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetNegativeButtonString (global::Android.Content.Context p0)
		{
			const string __id = "onGetNegativeButtonString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetPositiveButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetPositiveButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetPositiveButtonString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetPositiveButtonString (global::Android.Content.Context p0)
		{
			const string __id = "onGetPositiveButtonString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetTitleString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetTitleString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetTitleString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetTitleString (global::Android.Content.Context p0)
		{
			const string __id = "onGetTitleString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
