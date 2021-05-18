using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/AvailableAdapter", DoNotGenerateAcw=true)]
	public partial class AvailableAdapter : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/field[@name='b']"
		[Register ("b")]
		public global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack B {
			get {
				const string __id = "b.Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/field[@name='c']"
		[Register ("c")]
		public global::Huawei.Hms.Adapter.Sysobs.ISystemObserver C {
			get {
				const string __id = "c.Lcom/huawei/hms/adapter/sysobs/SystemObserver;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemObserver> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/adapter/sysobs/SystemObserver;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/field[@name='d']"
		[Register ("d")]
		public static global::Java.Util.Concurrent.Atomic.AtomicBoolean D {
			get {
				const string __id = "d.Ljava/util/concurrent/atomic/AtomicBoolean;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicBoolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/util/concurrent/atomic/AtomicBoolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/field[@name='e']"
		[Register ("e")]
		public static int E {
			get {
				const string __id = "e.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "e.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='AvailableAdapter.AvailableCallBack']"
		[Register ("com/huawei/hms/adapter/AvailableAdapter$AvailableCallBack", "", "Huawei.Hms.Adapter.AvailableAdapter/IAvailableCallBackInvoker")]
		public partial interface IAvailableCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='AvailableAdapter.AvailableCallBack']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onComplete", "(I)V", "GetOnComplete_IHandler:Huawei.Hms.Adapter.AvailableAdapter/IAvailableCallBackInvoker, Huawei.Hms.Availableupdate")]
			void OnComplete (int p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/adapter/AvailableAdapter$AvailableCallBack", DoNotGenerateAcw=true)]
		internal partial class IAvailableCallBackInvoker : global::Java.Lang.Object, IAvailableCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/AvailableAdapter$AvailableCallBack", typeof (IAvailableCallBackInvoker));

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

			public static IAvailableCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAvailableCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.adapter.AvailableAdapter.AvailableCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAvailableCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_I;
#pragma warning disable 0169
			static Delegate GetOnComplete_IHandler ()
			{
				if (cb_onComplete_I == null)
					cb_onComplete_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnComplete_I);
				return cb_onComplete_I;
			}

			static void n_OnComplete_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_I;
			public unsafe void OnComplete (int p0)
			{
				if (id_onComplete_I == IntPtr.Zero)
					id_onComplete_I = JNIEnv.GetMethodID (class_ref, "onComplete", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_I, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/AvailableAdapter", typeof (AvailableAdapter));
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

		protected AvailableAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/constructor[@name='AvailableAdapter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AvailableAdapter (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;", "")]
		public unsafe global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack A ()
		{
			const string __id = "a.()Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_Handler ()
		{
			if (cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_ == null)
				cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_);
			return cb_isHuaweiMobileServicesAvailable_Landroid_content_Context_;
		}

		static int n_IsHuaweiMobileServicesAvailable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsHuaweiMobileServicesAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/method[@name='isHuaweiMobileServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isHuaweiMobileServicesAvailable", "(Landroid/content/Context;)I", "GetIsHuaweiMobileServicesAvailable_Landroid_content_Context_Handler")]
		public virtual unsafe int IsHuaweiMobileServicesAvailable (global::Android.Content.Context p0)
		{
			const string __id = "isHuaweiMobileServicesAvailable.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_isUserResolvableError_I;
#pragma warning disable 0169
		static Delegate GetIsUserResolvableError_IHandler ()
		{
			if (cb_isUserResolvableError_I == null)
				cb_isUserResolvableError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsUserResolvableError_I);
			return cb_isUserResolvableError_I;
		}

		static bool n_IsUserResolvableError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUserResolvableError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/method[@name='isUserResolvableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserResolvableError", "(I)Z", "GetIsUserResolvableError_IHandler")]
		public virtual unsafe bool IsUserResolvableError (int p0)
		{
			const string __id = "isUserResolvableError.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_;
#pragma warning disable 0169
		static Delegate GetStartResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_Handler ()
		{
			if (cb_startResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_ == null)
				cb_startResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_);
			return cb_startResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_;
		}

		static void n_StartResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartResolution (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='AvailableAdapter']/method[@name='startResolution' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.adapter.AvailableAdapter.AvailableCallBack']]"
		[Register ("startResolution", "(Landroid/app/Activity;Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;)V", "GetStartResolution_Landroid_app_Activity_Lcom_huawei_hms_adapter_AvailableAdapter_AvailableCallBack_Handler")]
		public virtual unsafe void StartResolution (global::Android.App.Activity p0, global::Huawei.Hms.Adapter.AvailableAdapter.IAvailableCallBack p1)
		{
			const string __id = "startResolution.(Landroid/app/Activity;Lcom/huawei/hms/adapter/AvailableAdapter$AvailableCallBack;)V";
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
}
