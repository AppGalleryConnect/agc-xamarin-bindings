using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/BinderAdapter", DoNotGenerateAcw=true)]
	public partial class BinderAdapter : global::Java.Lang.Object, global::Android.Content.IServiceConnection {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']"
		[Register ("com/huawei/hms/adapter/BinderAdapter$BinderCallBack", "", "Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker")]
		public partial interface IBinderCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']/method[@name='onBinderFailed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onBinderFailed", "(I)V", "GetOnBinderFailed_IHandler:Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker, Huawei.Hms.Base")]
			void OnBinderFailed (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']/method[@name='onBinderFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onBinderFailed", "(ILandroid/content/Intent;)V", "GetOnBinderFailed_ILandroid_content_Intent_Handler:Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker, Huawei.Hms.Base")]
			void OnBinderFailed (int p0, global::Android.Content.Intent p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']/method[@name='onNullBinding' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
			[Register ("onNullBinding", "(Landroid/content/ComponentName;)V", "GetOnNullBinding_Landroid_content_ComponentName_Handler:Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker, Huawei.Hms.Base")]
			void OnNullBinding (global::Android.Content.ComponentName p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
			[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler:Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker, Huawei.Hms.Base")]
			void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BinderAdapter.BinderCallBack']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
			[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler:Huawei.Hms.Adapter.BinderAdapter/IBinderCallBackInvoker, Huawei.Hms.Base")]
			void OnServiceDisconnected (global::Android.Content.ComponentName p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/adapter/BinderAdapter$BinderCallBack", DoNotGenerateAcw=true)]
		internal partial class IBinderCallBackInvoker : global::Java.Lang.Object, IBinderCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/BinderAdapter$BinderCallBack", typeof (IBinderCallBackInvoker));

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

			public static IBinderCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBinderCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.adapter.BinderAdapter.BinderCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBinderCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBinderFailed_I;
#pragma warning disable 0169
			static Delegate GetOnBinderFailed_IHandler ()
			{
				if (cb_onBinderFailed_I == null)
					cb_onBinderFailed_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnBinderFailed_I);
				return cb_onBinderFailed_I;
			}

			static void n_OnBinderFailed_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBinderFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBinderFailed_I;
			public unsafe void OnBinderFailed (int p0)
			{
				if (id_onBinderFailed_I == IntPtr.Zero)
					id_onBinderFailed_I = JNIEnv.GetMethodID (class_ref, "onBinderFailed", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBinderFailed_I, __args);
			}

			static Delegate cb_onBinderFailed_ILandroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnBinderFailed_ILandroid_content_Intent_Handler ()
			{
				if (cb_onBinderFailed_ILandroid_content_Intent_ == null)
					cb_onBinderFailed_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnBinderFailed_ILandroid_content_Intent_);
				return cb_onBinderFailed_ILandroid_content_Intent_;
			}

			static void n_OnBinderFailed_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBinderFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBinderFailed_ILandroid_content_Intent_;
			public unsafe void OnBinderFailed (int p0, global::Android.Content.Intent p1)
			{
				if (id_onBinderFailed_ILandroid_content_Intent_ == IntPtr.Zero)
					id_onBinderFailed_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBinderFailed", "(ILandroid/content/Intent;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBinderFailed_ILandroid_content_Intent_, __args);
			}

			static Delegate cb_onNullBinding_Landroid_content_ComponentName_;
#pragma warning disable 0169
			static Delegate GetOnNullBinding_Landroid_content_ComponentName_Handler ()
			{
				if (cb_onNullBinding_Landroid_content_ComponentName_ == null)
					cb_onNullBinding_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNullBinding_Landroid_content_ComponentName_);
				return cb_onNullBinding_Landroid_content_ComponentName_;
			}

			static void n_OnNullBinding_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNullBinding (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNullBinding_Landroid_content_ComponentName_;
			public unsafe void OnNullBinding (global::Android.Content.ComponentName p0)
			{
				if (id_onNullBinding_Landroid_content_ComponentName_ == IntPtr.Zero)
					id_onNullBinding_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "onNullBinding", "(Landroid/content/ComponentName;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNullBinding_Landroid_content_ComponentName_, __args);
			}

			static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
			static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
			{
				if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
					cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
				return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			}

			static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceConnected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			public unsafe void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
			{
				if (id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == IntPtr.Zero)
					id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, __args);
			}

			static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
			static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
			{
				if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
					cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
				return cb_onServiceDisconnected_Landroid_content_ComponentName_;
			}

			static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnServiceDisconnected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
			public unsafe void OnServiceDisconnected (global::Android.Content.ComponentName p0)
			{
				if (id_onServiceDisconnected_Landroid_content_ComponentName_ == IntPtr.Zero)
					id_onServiceDisconnected_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceDisconnected_Landroid_content_ComponentName_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/BinderAdapter", typeof (BinderAdapter));
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

		protected BinderAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/constructor[@name='BinderAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BinderAdapter (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_;
#pragma warning disable 0169
		static Delegate GetBinder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_Handler ()
		{
			if (cb_binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_ == null)
				cb_binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_);
			return cb_binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_;
		}

		static void n_Binder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Binder (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/method[@name='binder' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.adapter.BinderAdapter.BinderCallBack']]"
		[Register ("binder", "(Lcom/huawei/hms/adapter/BinderAdapter$BinderCallBack;)V", "GetBinder_Lcom_huawei_hms_adapter_BinderAdapter_BinderCallBack_Handler")]
		public virtual unsafe void Binder (global::Huawei.Hms.Adapter.BinderAdapter.IBinderCallBack p0)
		{
			const string __id = "binder.(Lcom/huawei/hms/adapter/BinderAdapter$BinderCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onNullBinding_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnNullBinding_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onNullBinding_Landroid_content_ComponentName_ == null)
				cb_onNullBinding_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNullBinding_Landroid_content_ComponentName_);
			return cb_onNullBinding_Landroid_content_ComponentName_;
		}

		static void n_OnNullBinding_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNullBinding (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/method[@name='onNullBinding' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onNullBinding", "(Landroid/content/ComponentName;)V", "GetOnNullBinding_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnNullBinding (global::Android.Content.ComponentName p0)
		{
			const string __id = "onNullBinding.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
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

		static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName p0)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_unBind;
#pragma warning disable 0169
		static Delegate GetUnBindHandler ()
		{
			if (cb_unBind == null)
				cb_unBind = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UnBind);
			return cb_unBind;
		}

		static void n_UnBind (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BinderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnBind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BinderAdapter']/method[@name='unBind' and count(parameter)=0]"
		[Register ("unBind", "()V", "GetUnBindHandler")]
		public virtual unsafe void UnBind ()
		{
			const string __id = "unBind.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
